// fsharplint:disable PublicValuesNames NonPublicValuesNames
namespace DotNetDates.FSharp

open System
open System.IO
open System.Drawing
open System.Windows.Forms
open System.Globalization
open Global
open CustomFormats

module CreateYourOwn = 
    let private createButton txt = 
        let btn = new Button()
        btn.Text <- txt
        btn

    let private createTextBox () =
        let txt = new TextBox()
        let f = new Font("Consolas", 12f)
        txt.Font <- f
        txt.Width <- 200
        txt

    let private saveToCustom (txt: TextBox) (resLbl: Label) (flpCustom: FlowLayoutPanel) = 
        File.AppendAllText(saveFile, txt.Text + "\r\n")
        AddCustomFormats flpCustom

    let TextboxChangedText (txt: TextBox) (lbl: Label) = 
        let fmt = txt.Text
        let dtResult = 
            try DateTime.Now.ToString(fmt, CultureInfo.InvariantCulture)
            with exn -> "Unrecognized format."
        lbl.Text <- dtResult

    let ConfigureCreateYourOwnPanel (flp: FlowLayoutPanel) (flpResult: FlowLayoutPanel) (flpCustom: FlowLayoutPanel) = 
        let lbl = basicLabel """DateTime.Now.ToString(" """
        let p = new Padding(0,6,0,0)
        lbl.Padding <- p
        let resLbl = basicLabel ""
        let txt = createTextBox()
        txt.TextChanged.Add(fun x -> TextboxChangedText txt resLbl)
        let lbl2 = basicLabel """ ") """
        lbl2.Padding <- p
        let btn = createButton "Save to Custom"
        btn.AutoSize <- true
        btn.Font <- new Font("Consolas", 10f)
        btn.Click.Add(fun x -> saveToCustom txt resLbl flpCustom)
        flp.Controls.Add(lbl)
        flp.Controls.Add(txt)
        flp.Controls.Add(lbl2)
        flpResult.Controls.Add(resLbl)
        flp.Controls.Add(btn)
