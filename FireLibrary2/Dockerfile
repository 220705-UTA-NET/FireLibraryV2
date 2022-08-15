#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app
    
# Copy csproj and restore as distinct layers
COPY ./FireLibrary2/*.csproj ./FireLibrary2/
# COPY ./Project3.sln ./
RUN dotnet restore ./FireLibrary2/
    
# Copy everything else and build
COPY ./ ./
RUN dotnet publish -c Release -o out
    
# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build-env /app/out .

EXPOSE 7208

# ENTRYPOINT ["dotnet", "Project3.dll"]
CMD dotnet FireLibrary2.dll --urls=http://0.0.0.0:7208
