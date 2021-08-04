FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base
WORKDIR /src
COPY *.sln .
COPY ELibrary.CloudinaryService/*.csproj ELibrary.CloudinarService/
COPY ELibrary.Common/*.csproj ELibrary.Common/
COPY ELibrary.Core/*.csproj ELibrary.Core/
COPY ELibrary.Data/*.csproj ELibrary.Data/
COPY ELibrary.Dtos/*.csproj ELibrary.Dtos/
COPY ELibrary.EmailServices/*.csproj ELibrary.EmailServices/
COPY ELibrary.Models/*.csproj ELibrary.Models/
COPY ELibrary.MVC/*.csproj ELibrary.MVC/
COPY ELibrary.ViewModels/*.csproj ELibrary.ViewModels/
COPY . .
RUN dotnet restore

COPY . .

#Publishing
FROM base AS publish
WORKDIR /src/ELibrary.MVC
RUN dotnet publish -c Release -o /src/publish

#Get the runtime into a folder called app
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=publish /src/publish .

COPY . .

#ENTRYPOINT ["dotnet", "ELibrary.MVC.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet ELibrary.MVC.dll
