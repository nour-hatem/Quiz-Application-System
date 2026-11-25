# Shared Models and Contracts — Proposal

**Status: proposed; ask all seven members to review before parallel implementation.**

This file starts the team discussion. The public types in `src/QuizApplication/Models.fs` are a first draft, not a final contract.

## Proposed types

- `QuestionKind` distinguishes multiple-choice questions (options plus the expected answer) from written questions (an expected answer for the initial simple evaluator).
- `Question` contains an integer ID, prompt text, kind, points, and category.
- `UserAnswer` distinguishes a selected option from written text.
- `QuizState` keeps the question list, current index, and answers keyed by question ID.
- `QuizResult` contains earned and possible points plus correct, incorrect, and unanswered counts.

## Questions the team should settle

1. Should written answers be graded by exact match, manually, or with a simple rule agreed by the instructor?
2. Should answer payloads remain strings, or should MCQ answers use option IDs?
3. Should navigation stop at the first/last question or wrap around?
4. Is a category required for every question?

Once everyone agrees, update this document and `Models.fs` together in one reviewed change. Keep `Models.fs` first in F# compile order; keep `Program.fs` last.
