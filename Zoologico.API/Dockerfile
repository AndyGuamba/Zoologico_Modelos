# 1. Imagen Base
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# 2. COPIAR LOS PROYECTOS (¡Aquí estaba el error!)
# Le decimos: "Entra a la carpeta y busca el archivo"
COPY ["Zoologico.API/Zoologico.API.csproj", "Zoologico.API/"]
COPY ["Zoologico_Modelos/Zoologico_Modelos.csproj", "Zoologico_Modelos/"]

# 3. RESTAURAR
RUN dotnet restore "Zoologico.API/Zoologico.API.csproj"

# 4. COPIAR TODO LO DEMÁS
COPY . .

# 5. CONSTRUIR
WORKDIR "/src/Zoologico.API"
RUN dotnet build "Zoologico.API.csproj" -c Release -o /app/build

# 6. PUBLICAR
FROM build AS publish
RUN dotnet publish "Zoologico.API.csproj" -c Release -o /app/publish

# 7. EJECUTAR
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Zoologico.API.dll"]