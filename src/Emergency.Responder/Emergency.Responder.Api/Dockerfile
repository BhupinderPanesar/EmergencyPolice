FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["/Emergency.Responder.Api/Emergency.Responder.Api.csproj", "Emergency.Responder.Api/"]
RUN dotnet restore "Emergency.Responder.Api/Emergency.Responder.Api.csproj"
COPY . .
WORKDIR "/src/Emergency.Responder.Api"
RUN dotnet build "Emergency.Responder.Api.csproj" -c release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Emergency.Responder.Api.dll"]
