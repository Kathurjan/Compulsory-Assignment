FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["EF-Compulsory-Assignment.csproj", "./"]
RUN dotnet restore "EF-Compulsory-Assignment.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "EF-Compulsory-Assignment.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EF-Compulsory-Assignment.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EF-Compulsory-Assignment.dll"]
