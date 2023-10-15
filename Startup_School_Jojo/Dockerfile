#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Startup_School_Jojo.csproj", "./"]
RUN dotnet restore "Startup_School_Jojo.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "Startup_School_Jojo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Startup_School_Jojo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
RUN apt-get update 
RUN apt-get --yes install curl
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Startup_School_Jojo.dll"]