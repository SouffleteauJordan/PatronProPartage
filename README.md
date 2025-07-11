# PatronProPartage

Skeleton for the "PatronProPartage" Blazor Server project. This repository only contains a minimal set of files to provide an initial structure, as the full application requires tooling not available in this environment.


## Structure

- `src/PatronProPartage` — Minimal Blazor Server project skeleton.
- `src/PatronProPartage/Models` — Data models.
- `src/PatronProPartage/Services` — Service interfaces and stubs.
- `src/PatronProPartage/Pages` — Razor components/pages.
- `src/PatronProPartage/Shared` — Shared layout components.

This code does **not** build or run in this environment because the .NET SDK is missing. However, it provides an outline of the intended architecture.

## Future setup

Once a .NET development environment is available, you can run `dotnet restore` and `dotnet build` to compile the project. MudBlazor should be added as a package reference, and the service implementations should be completed to interact with the database and file system.
