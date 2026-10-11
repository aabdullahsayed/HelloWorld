# Stage 1: Build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

# Copy project file
COPY ["HelloWorld.csproj", "./"]

# Restore dependencies
RUN dotnet restore "HelloWorld.csproj"

# Copy source code
COPY . .

# Publish application
RUN dotnet publish "HelloWorld.csproj" \
    -c Release \
    -o /app/publish \
    --no-restore


# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime

WORKDIR /app

# Copy published application
COPY --from=build /app/publish .

# Configure HTTP port
ENV ASPNETCORE_HTTP_PORTS=8080

EXPOSE 8080

# Start application
ENTRYPOINT ["dotnet", "HelloWorld.dll"]