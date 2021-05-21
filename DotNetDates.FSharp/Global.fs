namespace DotNetDates.FSharp

open System
open System.Windows.Forms
open System.Drawing
open System.Windows
open System.Text.RegularExpressions
open System.IO

module Global =
    let saveFile = @"c:\dev\temp\dotnetdates.txt"
    let basicLabel str = 
        let lbl = new Label()
        lbl.Font <- new Font("Consolas", 12.0f) 
        lbl.Text <- str
        lbl.AutoSize <- true
        lbl

    let private copyToClipboard (lbl: Label) =
        let orig = lbl.Text
        let rep = Regex.Replace(lbl.Text, "ToString\(\"", "")
        let reg = Regex.Replace(rep, "\"\)", "")
        Clipboard.SetText(reg)
        lbl.Text <- "Copied!"
        lbl.Refresh()
        System.Threading.Thread.Sleep(1000)
        lbl.Text <- orig

    let headerLabel str =
        let lbl = basicLabel str
        let headerFont = new Font("Consolas", 16.f)
        lbl.Font <- headerFont
        lbl

    let boldLabel str = 
        let lbl = basicLabel str
        let boldFont = new Font("Consolas", 14.f, FontStyle.Bold)
        lbl.Font <- boldFont
        lbl.ForeColor <- Color.FromArgb(0, 153, 76)
        lbl.DoubleClick.Add(fun x -> copyToClipboard lbl )
        lbl

    let toFormat format result = 
        let panel = new FlowLayoutPanel()
        let lbl1 = boldLabel format
        let lbl2 = basicLabel result
        panel.AutoSize <- true
        panel.FlowDirection <- FlowDirection.TopDown
        panel.Controls.Add(lbl1)
        panel.Controls.Add(lbl2)
        panel