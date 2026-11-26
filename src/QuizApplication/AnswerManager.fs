
namespace QuizApplication

module AnswerManager =

    // Save or update an answer for a specific question
    let saveAnswer (questionId: int) (answer: UserAnswer) (state: QuizState) : QuizState =
        {
            state with
                Answers = Map.add questionId answer state.Answers
        }

    // Get the answer for a specific question
    let getAnswer (questionId: int) (state: QuizState) : UserAnswer option =
        Map.tryFind questionId state.Answers

    // Get all questions that have not been answered
    let getUnansweredQuestions (state: QuizState) : Question list =
        state.Questions
        |> List.filter (fun question ->
            not (Map.containsKey question.Id state.Answers)
        )
