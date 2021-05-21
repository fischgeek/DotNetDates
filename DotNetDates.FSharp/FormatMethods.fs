namespace DotNetDates.FSharp

open System
open System.Windows.Forms
open Global

module FormatMethods = 
    let private toShortDateString () = toFormat "ToShortDateString()" (DateTime.Now.ToShortDateString())
    let private toLongDateString () = toFormat "ToLongDateString()" (DateTime.Now.ToLongDateString())
    let private toShortTimeString () = toFormat "ToShortTimeString()" (DateTime.Now.ToShortTimeString())
    let private toLongTimeString () = toFormat "ToLongTimeString()" (DateTime.Now.ToLongTimeString())

    let AddMethods (flp: FlowLayoutPanel) =
        flp.Controls.Add(toShortDateString())
        flp.Controls.Add(toLongDateString())
        flp.Controls.Add(toShortTimeString())
        flp.Controls.Add(toLongTimeString())
