FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/MockEcommerce.Web.Host/MockEcommerce.Web.Host.csproj", "src/MockEcommerce.Web.Host/"]
COPY ["src/MockEcommerce.Web.Core/MockEcommerce.Web.Core.csproj", "src/MockEcommerce.Web.Core/"]
COPY ["src/MockEcommerce.Application/MockEcommerce.Application.csproj", "src/MockEcommerce.Application/"]
COPY ["src/MockEcommerce.Core/MockEcommerce.Core.csproj", "src/MockEcommerce.Core/"]
COPY ["src/MockEcommerce.EntityFrameworkCore/MockEcommerce.EntityFrameworkCore.csproj", "src/MockEcommerce.EntityFrameworkCore/"]
WORKDIR "/src/src/MockEcommerce.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/MockEcommerce.Web.Host", "src/MockEcommerce.Web.Host"]
COPY ["src/MockEcommerce.Web.Core", "src/MockEcommerce.Web.Core"]
COPY ["src/MockEcommerce.Application", "src/MockEcommerce.Application"]
COPY ["src/MockEcommerce.Core", "src/MockEcommerce.Core"]
COPY ["src/MockEcommerce.EntityFrameworkCore", "src/MockEcommerce.EntityFrameworkCore"]
WORKDIR "/src/src/MockEcommerce.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "MockEcommerce.Web.Host.dll"]
