#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["jeudontonestlehero.Web.UI/jeudontonestlehero.Web.UI.csproj", "jeudontonestlehero.Web.UI/"]
RUN dotnet restore "jeudontonestlehero.Web.UI/jeudontonestlehero.Web.UI.csproj"
COPY . .
WORKDIR "/src/jeudontonestlehero.Web.UI"
RUN dotnet build "jeudontonestlehero.Web.UI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "jeudontonestlehero.Web.UI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "jeudontonestlehero.Web.UI.dll"]