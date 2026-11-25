# Shared Models and Contracts

**Status: confirmed choices supplied by the team (2026-11-25).**

These types and rules are the shared contract for all seven work areas. Coordinate any later changes with the team because other modules depend on them.

## Agreed decisions

1. **Written answers:** grade by exact text equality. Case and whitespace matter; do not trim or normalize the answer before comparing it with the expected answer.
2. **Multiple-choice answers:** identify each option by an integer ID. Store the selected option ID, not its display text. Option IDs must be unique within a question, and the correct option ID must exist in that question's options.
3. **Navigation:** Next and Previous stop at the last and first question; they never wrap. At a boundary, the current question stays selected. An empty quiz has no current question, and navigation leaves it empty.
4. **Categories:** optional. A question may have no category.

## Shared types

- `AnswerOption` has an integer `Id` and display `Text`.
- `QuestionKind` is either `MultipleChoice` (options and correct option ID) or `Written` (expected answer text).
- `Question` contains its ID, prompt, kind, points, and optional category.
- `UserAnswer` stores a selected option ID or written text.
- `QuizState` holds the questions, current index, and answers keyed by question ID.
- `QuizResult` contains earned and possible points plus correct, incorrect, and unanswered counts.

The implementation is in `src/QuizApplication/Models.fs`. Keep this file first in F# compile order; modules that use these types come after it, and `Program.fs` stays last.
