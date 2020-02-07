FROM mcr.microsoft.com/dotnet/core/aspnet:2.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.1 AS build
WORKDIR /src
COPY ["AlumnosApp/AlumnosApp.csproj", "AlumnosApp/"]

RUN dotnet restore "AlumnosApp/AlumnosApp.csproj"
COPY . .
WORKDIR "/src/AlumnosApp"
RUN dotnet build "AlumnosApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AlumnosApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AlumnosApp.dll"]