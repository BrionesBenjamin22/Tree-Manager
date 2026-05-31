FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY src/TreeManager.Api/TreeManager.Api.csproj src/TreeManager.Api/

RUN dotnet restore src/TreeManager.Api/TreeManager.Api.csproj

COPY . .

RUN dotnet publish src/TreeManager.Api/TreeManager.Api.csproj \
    -c Release \
    -o /app/publish \
    --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080

ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "TreeManager.Api.dll"]