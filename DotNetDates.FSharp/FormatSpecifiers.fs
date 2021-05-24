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
        ["d";"D";"f";"F";"g";"G";"G";"M";"o";"O";"r";"R";"s";"t";"T";"u";"U";"y";"Y"]
        |> Seq.map fmt
        |> Seq.iter flp.Controls.Add