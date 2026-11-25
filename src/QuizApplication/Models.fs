namespace QuizApplication

type AnswerOption =
    {
        Id: int
        Text: string
    }

type QuestionKind =
    | MultipleChoice of options: AnswerOption list * correctOptionId: int
    | Written of expectedAnswer: string

type Question =
    {
        Id: int
        Text: string
        Kind: QuestionKind
        Points: int
        Category: string option
    }

type UserAnswer =
    | SelectedOption of optionId: int
    | WrittenText of string

type QuizState =
    {
        Questions: Question list
        CurrentIndex: int
        Answers: Map<int, UserAnswer>
    }

type QuizResult =
    {
        EarnedPoints: int
        TotalPoints: int
        CorrectCount: int
        IncorrectCount: int
        UnansweredCount: int
    }
