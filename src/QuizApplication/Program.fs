namespace QuizApplication

open System
open System.Windows.Forms
open QuizApplication.UI

module Program =
    [<STAThread>]
    [<EntryPoint>]
    let main _ =
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(false)
        Application.Run(new MainForm())
        0
