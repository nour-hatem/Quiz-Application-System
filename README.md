# Quiz Application (F#)

A PL-3 team project: a Windows Forms quiz application with multiple-choice and written questions, saved answers, question navigation, scoring, and results.

## Requirements

- .NET 10 SDK
- Windows (the app uses Windows Forms)

## Build and run

From this folder:

```powershell
dotnet build .\src\QuizApplication\QuizApplication.fsproj
dotnet run --project .\src\QuizApplication\QuizApplication.fsproj
```

## Team workflow

The shared model contract is recorded in `docs/TEAM_CONTRACT.md`. All modules should follow it. Each member should use a feature branch and open a pull request to `main`.

F# source files must be listed in dependency order in the `.fsproj` file. Shared types come first; modules that use them come later; `Program.fs` stays last.

## Planned work areas

1. Shared models and contracts
2. Question bank
3. Quiz engine and navigation
4. Answer management
5. Scoring
6. Windows Forms UI
7. Results and integration checks
