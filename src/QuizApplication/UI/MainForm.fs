namespace QuizApplication.UI

open System.Drawing
open System.Windows.Forms

type MainForm() as this =
    inherit Form()

    do
        this.Text <- "Quiz Application"
        this.StartPosition <- FormStartPosition.CenterScreen
        this.ClientSize <- Size(640, 360)
        this.MinimumSize <- Size(480, 300)

        let heading = new Label()
        heading.Text <- "Quiz Application"
        heading.AutoSize <- true
        heading.Font <- new Font("Segoe UI", 20.0f, FontStyle.Bold)
        heading.Location <- Point(32, 32)

        let message = new Label()
        message.Text <- "F# Windows Forms project is ready. Quiz features will be added after the team agrees on the shared models."
        message.AutoSize <- false
        message.MaximumSize <- Size(560, 0)
        message.Size <- Size(560, 64)
        message.Location <- Point(36, 100)

        this.Controls.Add(heading)
        this.Controls.Add(message)
