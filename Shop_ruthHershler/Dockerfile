#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Shop_ruthHershler/Shop.API.csproj", "Shop_ruthHershler/"]
COPY ["Shop.Core/Shop.Core.csproj", "Shop.Core/"]
COPY ["Shop.Data/Shop.Data.csproj", "Shop.Data/"]
COPY ["Shop.Service/Shop.Service.csproj", "Shop.Service/"]
RUN dotnet restore "Shop_ruthHershler/Shop.API.csproj"
COPY . .
WORKDIR "/src/Shop_ruthHershler"
RUN dotnet build "Shop.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Shop.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shop.API.dll"]