FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["MusicStoreApp/MusicStoreApp.csproj", "MusicStoreApp/"]
COPY ["MusicStore.Repository/MusicStore.Repository.csproj", "MusicStore.Repository/"]
COPY ["MusicStore.Service/MusicStore.Service.csproj", "MusicStore.Service/"]
COPY ["MusicStore.Domain/MusicStore.Domain.csproj", "MusicStore.Domain/"]
RUN dotnet restore "MusicStoreApp/MusicStoreApp.csproj"

COPY . .
WORKDIR "/src/MusicStoreApp"
RUN dotnet build "MusicStoreApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MusicStoreApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MusicStoreApp.dll"]
