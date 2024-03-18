FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/MockEcommerce.Web.Mvc/MockEcommerce.Web.Mvc.csproj", "src/MockEcommerce.Web.Mvc/"]
COPY ["src/MockEcommerce.Web.Core/MockEcommerce.Web.Core.csproj", "src/MockEcommerce.Web.Core/"]
COPY ["src/MockEcommerce.Application/MockEcommerce.Application.csproj", "src/MockEcommerce.Application/"]
COPY ["src/MockEcommerce.Core/MockEcommerce.Core.csproj", "src/MockEcommerce.Core/"]
COPY ["src/MockEcommerce.EntityFrameworkCore/MockEcommerce.EntityFrameworkCore.csproj", "src/MockEcommerce.EntityFrameworkCore/"]
WORKDIR "/src/src/MockEcommerce.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/MockEcommerce.Web.Mvc", "src/MockEcommerce.Web.Mvc"]
COPY ["src/MockEcommerce.Web.Core", "src/MockEcommerce.Web.Core"]
COPY ["src/MockEcommerce.Application", "src/MockEcommerce.Application"]
COPY ["src/MockEcommerce.Core", "src/MockEcommerce.Core"]
COPY ["src/MockEcommerce.EntityFrameworkCore", "src/MockEcommerce.EntityFrameworkCore"]
WORKDIR "/src/src/MockEcommerce.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "MockEcommerce.Web.Mvc.dll"]
