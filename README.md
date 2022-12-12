# Victual.Backend.Api

## Introduction


## Tools

-   [.Net 7](https://dotnet.microsoft.com/download/dotnet/7.0)
-   [C#11](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11)
-   [.editorconfig](https://editorconfig.org/)
-   [PlantUML](https://plantuml.com/)
-   [Docker](https://docs.docker.com/docker-for-windows/install/)

## Configuration

### Local Developer Environment


### Cloud Environments


### Properties\launchSettings.json

Please use `launchSettings.json` to define developer environment specific configuration. File ignored in git and any changes available.

```json
{

}
```

Please add key-value into `environmentVariables` object.

## Project Structure

### API

Web API layer exposed for consumption

### Application

Contains business logic

### Infrastructure

Implement dependencies/adapters for specific infrastructure

### Domain

Contains entities, types

### Database

## Restore/Build/Test/Format/Run/Update Nuget packages

Navigate to root repository. Run command:

```bash
dotnet restore
```

### Build

```bash
dotnet build
```

### Test

```bash
dotnet test ./test/Victual.Backend.Api.UnitTests/Victual.Backend.Api.UnitTests.csproj --collect "XPlat Code coverage"
dotnet reportgenerator -reports:**/coverage.cobertura.xml -targetdir:./coverlet/reports -reporttypes:html
```

#### API Tests

API tests are running using a unit test framework with a test web host and an in-memory test server.
SQL server with database, used by API during the tests execution, is running in docker container.

To run the API tests on local environment:

-   Build `Victual.Backend.Infrastructure.SqlDatabase` project to generate `*.dacpac` file, required for the database setup
-   Verify that .dacpac file path in `appsettings.json` of `Victual.Backend.ApiTests` project is setup correctly:

    ```json
    {
        "DacpacFilePath": "../../../../../src/Victual.Backend.Infrastructure.SqlDatabase/bin/Debug/Victual.Backend.Infrastructure.SqlDatabase.dacpac"
    }
    ```

-   Run the tests.

### Format

```bash
dotnet format -w -s -a -v diagnostic
```

### Run

```bash
dotnet run -p src/Victual.Backend.Api/Victual.Backend.Api.csproj
```

### Update Nuget packages

```bash
dotnet outdated -u
```
