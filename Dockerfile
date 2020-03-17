# Build Image
# Copy the csproj file and do a restore of all the packages.
# Then builds the app and puts the executable in the "/app/out" folder.
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-image
WORKDIR /app
COPY *.csproj ./
RUN dotnet restore
COPY . ./
RUN dotnet publish -c Release -o ./out

# Final Image
# Put the executables from the previous stage into the "/app" folder.
# Then run "dotnet" passing the build generated library *.dll
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-image /app/out .
ENTRYPOINT ["dotnet", "fibonacci.dll"]