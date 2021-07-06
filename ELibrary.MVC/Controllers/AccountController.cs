using ELibrary.Common.Helpers;
using ELibrary.Dtos;
using ELibrary.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System. Text.Json;
using System.Threading.Tasks;

namespace ELibrary.MVC.Controllers
{
    public class AccountController : Controller
    {
        private const string BASE_URL = "https://localhost:44326/";

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {

            var userDto = new LoginDetailDto();

            if (ModelState.IsValid)
            {
                userDto.Email = model.Email;
                userDto.Password = model.Password;
            }
            else
            {
                return View(model);
            }
            var url = BASE_URL + "api/auth/login";
            var client = new ApiHttpClient();
            var postRequest = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = JsonContent.Create(userDto)
            };

            var response = await client.Client.SendAsync(postRequest);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var responseObject = JsonConvert.DeserializeObject<ResponseDto<LoginResponseDto>>(content);

            if (responseObject.StatusCode == 200 && !string.IsNullOrEmpty(responseObject.Data.Token))
            {
                HttpContext.Session.SetString("Token", responseObject.Data.Token);
                HttpContext.Session.SetString("UserId", responseObject.Data.UserId);
                HttpContext.Session.SetString("Role", responseObject.Data.Role);
                HttpContext.Session.SetString("Name", responseObject.Data.Name);
            }
            else
            {
                ModelState.AddModelError("LoginError" , "Incorrect Username and Password");
                return View(model);
            }

            if (!string.IsNullOrEmpty(returnUrl))
            {

                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                
                var registerDto = new RegistrationDto()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Password = model.Password,
                    ConfirmPassword = model.ConfirmPassword,
                    Email = model.Email,
                };
                var url = BASE_URL + "api/auth/register";
                var client = new ApiHttpClient();
                var postRequest = new HttpRequestMessage(HttpMethod.Post, url)
                {
                    Content = JsonContent.Create(registerDto)
                };

                var response = await client.Client.SendAsync(postRequest);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var responseDto = JsonConvert.DeserializeObject<RegisterViewModel>(content);
                return RedirectToAction("ConfirmEmailModelView");
            }

            else
            {
                return View(model);
            }


        }

        public async Task<IActionResult> ConfirmEmail(string userid, string token)
        {

            var confirm = new EmailConfirmation
            {
                Token = token,
                userid = userid
            };

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44326/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var stringContent = new StringContent(JsonConvert.SerializeObject(confirm), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("api/Auth/ConfirmEmail", stringContent).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var resultFromApi = await response.Content.ReadAsStringAsync();
            var book = JsonConvert.DeserializeObject<ResponseDto<ConfirmEmailResponseDto>>(resultFromApi);
            if (book.Success == true)
            {
                return RedirectToAction("Login");
            }
            return RedirectToAction("Register");
        }

        [HttpGet]
        public IActionResult ConfirmEmailModelView()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            var url = BASE_URL + "api/auth/forget-password";
            var client = new ApiHttpClient();
            var postRequest = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = JsonContent.Create(model)
            };

            var response = await client.Client.SendAsync(postRequest);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var responseDto = JsonConvert.DeserializeObject<RegisterViewModel>(content);
            return View();
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

    }
}
