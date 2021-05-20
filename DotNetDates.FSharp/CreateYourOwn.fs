// fsharplint:disable PublicValuesNames NonPublicValuesNames
namespace DotNetDates.FSharp

open System
open System.Windows.Forms
open Global

module CreateYourOwn = 
    let private createTextBox () =
        let txt = new TextBox()
        txt

    let TextboxChangedText (txt: TextBox) (lbl: Label) = 
        let fmt = txt.Text
        let dtResult = 
            try
                DateTime.Now.ToString(fmt)
            with exn -> "Unrecognized format."
        lbl.Text <- dtResult

    let ConfigureCreateYourOwnPanel (flp: FlowLayoutPanel) (flpResult: FlowLayoutPanel) = 
        let lbl = basicLabel """DateTime.Now.ToString(" """
        let resLbl = basicLabel ""
        let txt = createTextBox()
        txt.TextChanged.Add(fun x -> TextboxChangedText txt resLbl)
        let lbl2 = basicLabel """ ") """
        flp.Controls.Add(lbl)
        flp.Controls.Add(txt)
        flp.Controls.Add(lbl2)
        flpResult.Controls.Add(resLbl)

