#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/ResApi/Reservation.API/Reservation.API.csproj", "Services/ResApi/Reservation.API/"]
COPY ["Services/ResApi/Reservation.API.Infrastructure/Reservation.API.Infrastructure.csproj", "Services/ResApi/Reservation.API.Infrastructure/"]
COPY ["Services/ResApi/Reservation.API.Models/Reservation.API.Models.csproj", "Services/ResApi/Reservation.API.Models/"]
COPY ["Services/ResApi/Reservation.API.Services/Reservation.API.Services.csproj", "Services/ResApi/Reservation.API.Services/"]
RUN dotnet restore "Services/ResApi/Reservation.API/Reservation.API.csproj"
COPY . .
WORKDIR "/src/Services/ResApi/Reservation.API"
RUN dotnet build "Reservation.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Reservation.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Reservation.API.dll"]