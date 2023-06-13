FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /Source
Copy . .

RUN dotnet restore
RUN  dotnet publish -c Release -o /app


#Build servi
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app .

EXPOSE 5268
EXPOSE 7040

ENTRYPOINT ["dotnet","Api.dll"]
