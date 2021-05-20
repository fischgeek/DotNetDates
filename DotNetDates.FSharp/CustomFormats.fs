// fsharplint:disable PublicValuesNames NonPublicValuesNames
namespace DotNetDates.FSharp

open System
open System.Windows.Forms
open Global

module CustomFormats = 
    let private fmt (s: string) = toFormat $"""ToString("{s}")""" (DateTime.Now.ToString(s))
    let private MMddyyyy () = fmt "MMddyyyy"
    let private MMddyyyy_Dashes () = fmt "MM-dd-yyyy"
    let private MMddyyyy_Slashes () = fmt "MM/dd/yyyy"
    let private MMddyyyy_Underscores () = fmt "MM_dd_yyyy"

    let AddCustomFormats (flp: FlowLayoutPanel) = 
        flp.Controls.Add(MMddyyyy())
        flp.Controls.Add(MMddyyyy_Dashes())
        flp.Controls.Add(MMddyyyy_Slashes())
        flp.Controls.Add(MMddyyyy_Underscores())
        ()


