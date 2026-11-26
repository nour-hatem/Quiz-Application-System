namespace QuizApplication

open System

module Scoring =

    // Returns true only when the answer kind matches the question kind
    // and the value is right. MCQ compares option IDs, written answers
    // compare text exactly (case and whitespace are significant).
    let isCorrect (question: Question) (answer: UserAnswer) : bool =
        match question.Kind, answer with
        | MultipleChoice(_, correctOptionId), SelectedOption optionId ->
            optionId = correctOptionId
        | Written expectedAnswer, WrittenText text ->
            String.Equals(text, expectedAnswer, StringComparison.Ordinal)
        | _ -> false

    // Folds over every question once. A question with no entry in
    // state.Answers is unanswered, otherwise it is correct or incorrect
    // and only correct answers add the question points.
    let calculateResult (state: QuizState) : QuizResult =
        let initial =
            { EarnedPoints = 0
              TotalPoints = state.Questions |> List.sumBy (fun question -> question.Points)
              CorrectCount = 0
              IncorrectCount = 0
              UnansweredCount = 0 }

        state.Questions
        |> List.fold
            (fun (result: QuizResult) (question: Question) ->
                match Map.tryFind question.Id state.Answers with
                | None ->
                    { result with UnansweredCount = result.UnansweredCount + 1 }
                | Some answer when isCorrect question answer ->
                    { result with
                        EarnedPoints = result.EarnedPoints + question.Points
                        CorrectCount = result.CorrectCount + 1 }
                | Some _ ->
                    { result with IncorrectCount = result.IncorrectCount + 1 })
            initial

