namespace QuizApplication

type QuestionKind =
    | MultipleChoice of options: string list * correctAnswer: string
    | Written of expectedAnswer: string

type Question =
    {
        Id: int
        Text: string
        Kind: QuestionKind
        Points: int
        Category: string
    }

type UserAnswer =
    | SelectedOption of string
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
