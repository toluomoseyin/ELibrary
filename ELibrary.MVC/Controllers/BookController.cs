using AutoMapper;
using ELibrary.Common.Helpers;
using ELibrary.Data.Repositories.Implementations;
using ELibrary.Dtos;
using ELibrary.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace ELibrary.MVC.Controllers
{
    public class BookController : Controller
    {
       
        private readonly IMapper _mapper;

        public BookController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet]
        public async Task<IActionResult> BookDetail(int bookId)
        {
            var token = HttpContext.Session.GetString("Token");
            var client = new ApiHttpClient(token);
            var BASE_URL = UrlHelper.BaseAddress(HttpContext);
            var url = BASE_URL +"/api/book/" + bookId;

            var res = await client.Client.GetAsync(url);

            var resultFromApi = await res.Content.ReadAsStringAsync();
            var book = JsonConvert.DeserializeObject<ResponseDto<GetBookDto>>(resultFromApi);

            var bookViewModel = _mapper.Map<BookDetailViewModel>(book.Data);

            var bookNewViewModel = new BookDetailAndReviewViewModel
            {
                BookDetailViewModel = bookViewModel
            };
            return View(bookNewViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddReview(AddReviewModel addReviewModel)
        {
            var token = HttpContext.Session.GetString("Token");
            var userId = HttpContext.Session.GetString("UserId");

            if(token == null || userId == null )
            {
                return RedirectToAction("Login", "Account");
            }

            var reviewDto = new ReviewDto
            {

                BookId = addReviewModel.BookId,
                Subject = addReviewModel.Subject,
                Body = addReviewModel.Body,
                AppUserId = userId
            };
            var BASE_URL = UrlHelper.BaseAddress(HttpContext);
            var client = new HttpClient();
            client.BaseAddress = new Uri(BASE_URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var jsonRsult = JsonConvert.SerializeObject(reviewDto);
            var stringContent = new StringContent(jsonRsult, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("/api/review/AddReview", stringContent).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("BookDetail", reviewDto);
            }

            return RedirectToAction("BookDetail", reviewDto);


        }

        public async Task<IActionResult> AdminBookView(int? pageIndex=1)
        {
            var BASE_URL = UrlHelper.BaseAddress(HttpContext);
            var httpClient = new ApiHttpClient();
            var bookResponse = await httpClient.Client.GetAsync($"{BASE_URL}/api/Book/?pageIndex="+pageIndex);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var deserializedBookResponseObject = JsonConvert.DeserializeObject<ResponseDto<AllBooks>>(await bookResponse.Content.ReadAsStringAsync());
            var booksAndPagination = new AllBooksAndPaginationViewModel();
            var deserializedBookResponse = deserializedBookResponseObject.Data;
            foreach (var bookDto in deserializedBookResponse.books)
            {
                

                var book = new AllBooksViewModel
                {
                    Title = bookDto.Title,
                    Author = bookDto.Author,
                    PublishedDate = bookDto.PublishedDate,
                    ISBN = bookDto.ISBN,
                    Publisher = bookDto.Publisher,
                    Id = bookDto.Id,
                    PhotoUrl = bookDto.PhotoUrl


                };
                booksAndPagination.AllBooksViewModel.Add(book);
            }
            ViewData["books"] = booksAndPagination;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddBook()
        {
           
            ViewData["category"] =  await GetCategory();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(AddBookViewModel model) 
        {
            var addBookDto = new AddBookDto();
            if (ModelState.IsValid)
            {
                
                int id;
                var categories = GetCategory();
                foreach (var category in categories.Result)
                {
                    if (category.Name == model.Category)
                    {
                        id = category.Id;
                        addBookDto.CategoryId = id;
                        addBookDto.Author = model.Author;
                        addBookDto.Copies = model.Copies;
                        addBookDto.ISBN = model.ISBN;
                        addBookDto.Language = model.Language;
                        addBookDto.AvailableCopies = model.AvailableCopies;

                        addBookDto.Pages = model.Pages;
                        addBookDto.Publisher = model.Publisher;
                        addBookDto.PublishedDate = model.PublishedDate;
                        addBookDto.Description = model.Description;
                        addBookDto.Title = model.Title;
                        addBookDto.AddedDate = model.AddedDate;


                        break;

                    }
                }
                var BASE_URL = UrlHelper.BaseAddress(HttpContext);
                var client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var stringContent = new StringContent(JsonConvert.SerializeObject(addBookDto), Encoding.UTF8, "application/json");
                var response = await client.PostAsync("/api/Book/AddBook", stringContent).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                var resultFromApi = await response.Content.ReadAsStringAsync();
                var book = JsonConvert.DeserializeObject<ResponseDto<GetBookDto>>(resultFromApi);


                using (var memoryStream = new MemoryStream())
                {
                    //Get the file stream from the multiform
                    model.PhotoFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                    var form = new MultipartFormDataContent();
                    var fileContent = new ByteArrayContent(memoryStream.ToArray());
                    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                    form.Add(fileContent, nameof(model.PhotoFile), model.PhotoFile.FileName);
                    form.Add(new StringContent("" + book.Data.Id), nameof(book.Data.Id));
                    var response1 = await client.PatchAsync("https://localhost:44326/api/Book/Update", form);
                    if (response1.IsSuccessStatusCode)
                    {
                        return RedirectToAction("AdminBookView", "Book");
                    }

                }

               
            }
            ViewData["category"] = await GetCategory();
            return View();
        }



        public async Task<List<CategoryOptionViewModel>> GetCategory()
        {
            var BASE_URL = UrlHelper.BaseAddress(HttpContext);
            var httpClient = new ApiHttpClient();
            var bookResponse = await httpClient.Client.GetAsync($"{BASE_URL}/api/Category/");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var deserializedBookResponseObject = JsonConvert.DeserializeObject<ResponseDto<Pagination<GetCategoryDto>>>(await bookResponse.Content.ReadAsStringAsync());
            var deserializedBookResponse = deserializedBookResponseObject.Data;
            var allCategory = new List<CategoryOptionViewModel>();
            foreach (var category in deserializedBookResponse)
            {
                var newCategory = new CategoryOptionViewModel
                {
                    Id = category.Id,
                    Name = category.Name
                };
                allCategory.Add(newCategory);
            }
            return allCategory;
            
        }
        [HttpGet]
        public async  Task<IActionResult> Edit(int id)
        {
            var BASE_URL = UrlHelper.BaseAddress(HttpContext);
            var httpClient = new ApiHttpClient();
            var bookResponse = await httpClient.Client.GetAsync($"{BASE_URL}/api/book/"+id);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var deserializedBookResponseObject = JsonConvert.DeserializeObject<ResponseDto<GetBookDto>>(await bookResponse.Content.ReadAsStringAsync());

            var book = deserializedBookResponseObject.Data;
            ViewData["book"] = book;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Edit(UpdateBookDto model)
        {
          
          
            var book = new UpdateBookDto
            {
                ISBN = model.ISBN,
                AddedDate = model.AddedDate,
                Author = model.Author,
                Description = model.Description,
                Language = model.Language,
                Id = model.Id,
                Copies = model.Copies,
                Pages = model.Pages,
                Publisher = model.Publisher,
                PublishedDate = model.PublishedDate,
                Title = model.Title,
                AvailableCopies=model.AvailableCopies
                

            };
            var BASE_URL = UrlHelper.BaseAddress(HttpContext);
            var client = new HttpClient();
            client.BaseAddress = new Uri(BASE_URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var stringContent = new StringContent(JsonConvert.SerializeObject(book), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/Book/UpdateBook", stringContent).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var resultFromApi = await response.Content.ReadAsStringAsync();
            var book1 = JsonConvert.DeserializeObject<ResponseDto<GetBookDto>>(resultFromApi);

            using (var memoryStream = new MemoryStream())
            {
                //Get the file stream from the multiform
                if (model.PhotoFile.Length > 1)
                {
                    model.PhotoFile.CopyToAsync(memoryStream).GetAwaiter().GetResult();
                }
                
                var form = new MultipartFormDataContent();
                var fileContent = new ByteArrayContent(memoryStream.ToArray());
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                if (model.PhotoFile.Length > 1)
                {
                    form.Add(fileContent, nameof(model.PhotoFile), model.PhotoFile.FileName);
                }
                
                form.Add(new StringContent("" + book1.Data.Id), nameof(book1.Data.Id));
                var response1 = await client.PatchAsync($"{BASE_URL}/api/Book/Update", form);
                if (response1.IsSuccessStatusCode)
                {
                    return RedirectToAction("AdminBookView", "Book");
                }

            }



            return View();

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var BASE_URL = UrlHelper.BaseAddress(HttpContext);
            var httpClient = new HttpClient();
            var baseUrl = $"{BASE_URL}/api/Book/delete/" +id;

            var response = await httpClient.DeleteAsync(baseUrl);

            return RedirectToAction("AdminBookView");
        }


    }
}
