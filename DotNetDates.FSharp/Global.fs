namespace DotNetDates.FSharp

open System
open System.Windows.Forms
open System.Drawing

module Global =
    let basicLabel str = 
        let lbl = new Label()
        lbl.Font <- new Font("Consolas", 12.0f) 
        lbl.Text <- str
        lbl.AutoSize <- true
        lbl

    let headerLabel str =
        let lbl = basicLabel str
        let headerFont = new Font("Consolas", 16.f)
        lbl.Font <- headerFont
        lbl

    let boldLabel str = 
        let lbl = basicLabel str
        let boldFont = new Font("Consolas", 14.f, FontStyle.Bold)
        lbl.Font <- boldFont
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

