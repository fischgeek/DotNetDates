// fsharplint:disable NonPublicValuesNames
namespace DotNetDates.FSharp

open System
open Microsoft.Win32
open System.Windows.Forms
open System.Drawing
open Global

module FormatSpecifiers = 
    let private fmt (s: string) = toFormat $"""ToString("{s}")""" (DateTime.Now.ToString(s))

    let AddSpecifiers (flp: FlowLayoutPanel) = 
        flp.Controls.Add(fmt "d")
        flp.Controls.Add(fmt "D")
        flp.Controls.Add(fmt "f")
        flp.Controls.Add(fmt "F")
        flp.Controls.Add(fmt "g")
        flp.Controls.Add(fmt "G")
        flp.Controls.Add(fmt "G")
        flp.Controls.Add(fmt "M")
        flp.Controls.Add(fmt "o")
        flp.Controls.Add(fmt "O")
        flp.Controls.Add(fmt "r")
        flp.Controls.Add(fmt "R")
        flp.Controls.Add(fmt "s")
        flp.Controls.Add(fmt "t")
        flp.Controls.Add(fmt "T")
        flp.Controls.Add(fmt "u")
        flp.Controls.Add(fmt "U")
        flp.Controls.Add(fmt "y")
        flp.Controls.Add(fmt "Y")