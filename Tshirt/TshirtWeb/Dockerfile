#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TshirtWeb/TshirtWeb.csproj", "TshirtWeb/"]
COPY ["T-shirt.Data/T-shirt.Data.csproj", "T-shirt.Data/"]
COPY ["T-shirt.Models/T-shirt.Models.csproj", "T-shirt.Models/"]
COPY ["T-shirt.Utility/T-shirtStore.Utility.csproj", "T-shirt.Utility/"]
RUN dotnet restore "TshirtWeb/TshirtWeb.csproj"
COPY . .
WORKDIR "/src/TshirtWeb"
RUN dotnet build "TshirtWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TshirtWeb.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TshirtWeb.dll"]