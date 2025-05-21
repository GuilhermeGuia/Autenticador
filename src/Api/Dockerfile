FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 43000
EXPOSE 42000

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG CONFIG=Release
WORKDIR /src
COPY ["Autenticador/Autenticador.csproj", "Autenticador/"]
RUN dotnet restore "Autenticador/Autenticador.csproj"
COPY . .
WORKDIR "/src/Autenticador"
RUN dotnet build "Autenticador.csproj" -c $CONFIG -o /app/build

FROM build AS publish
RUN dotnet publish "Autenticador.csproj" -c $CONFIG -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Autenticador.dll"]