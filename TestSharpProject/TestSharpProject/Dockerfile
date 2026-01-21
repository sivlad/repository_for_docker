FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app
COPY ./TestSharpProject.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o out
ENTRYPOINT ["dotnet", "/app/out/TestSharpProject.dll"]
