#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Bootcamp.Api/Bootcamp.Api.csproj", "Bootcamp.Api/"]
RUN dotnet restore "Bootcamp.Api/Bootcamp.Api.csproj"
COPY . .
WORKDIR "/src/Bootcamp.Api"
RUN dotnet build "Bootcamp.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Bootcamp.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bootcamp.Api.dll"]