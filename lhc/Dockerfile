FROM mcr.microsoft.com/dotnet/sdk:5.0
WORKDIR /myapp
EXPOSE 8080
COPY "package.json" .
COPY . .
RUN dotnet build "HomeheroTest.csproj" -c Release -o /app
ENTRYPOINT ["npm", "run", "serve"]
