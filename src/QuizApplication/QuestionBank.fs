namespace QuizApplication

open System

module QuestionBank =
    let private questions =
        [
            {
                Id = 1
                Text = "Which F# keyword declares an immutable binding by default?"
                Kind =
                    MultipleChoice(
                        [
                            { Id = 1; Text = "let" }
                            { Id = 2; Text = "mutable" }
                            { Id = 3; Text = "ref" }
                            { Id = 4; Text = "var" }
                        ],
                        1
                    )
                Points = 1
                Category = Some "F# Basics"
            }
            {
                Id = 2
                Text = "Which F# type represents a value that may be present or absent?"
                Kind =
                    MultipleChoice(
                        [
                            { Id = 1; Text = "Option" }
                            { Id = 2; Text = "Array" }
                            { Id = 3; Text = "Unit" }
                        ],
                        1
                    )
                Points = 1
                Category = Some "F# Basics"
            }
            {
                Id = 3
                Text = "What does immutability mean?"
                Kind = Written "A value cannot be changed after it is created."
                Points = 2
                Category = Some "Functional Programming"
            }
            {
                Id = 4
                Text = "Which language is used to build this quiz application?"
                Kind =
                    MultipleChoice(
                        [
                            { Id = 1; Text = "F#" }
                            { Id = 2; Text = "C#" }
                            { Id = 3; Text = "Java" }
                        ],
                        1
                    )
                Points = 1
                Category = None
            }
        ]

    let getAllQuestions () = questions

    let getQuestionById questionId =
        questions
        |> List.tryFind (fun question -> question.Id = questionId)

    let getQuestionsByCategory category =
        questions
        |> List.filter (fun question ->
            question.Category
            |> Option.exists (fun questionCategory ->
                String.Equals(questionCategory, category, StringComparison.OrdinalIgnoreCase)))
