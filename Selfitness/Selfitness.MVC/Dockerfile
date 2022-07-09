#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Selfitness.MVC/Selfitness.MVC.csproj", "Selfitness.MVC/"]
RUN dotnet restore "Selfitness.MVC/Selfitness.MVC.csproj"
COPY . .
WORKDIR "/src/Selfitness.MVC"
RUN dotnet build "Selfitness.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Selfitness.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Selfitness.MVC.dll"]