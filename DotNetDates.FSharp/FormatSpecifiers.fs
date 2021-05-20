// fsharplint:disable NonPublicValuesNames
namespace DotNetDates.FSharp

open System
open Microsoft.Win32
open System.Windows.Forms
open System.Drawing
open Global

module FormatSpecifiers = 
    let private fmt (s: string) = toFormat $"""ToString("{s}")""" (DateTime.Now.ToString(s))
    let private d() = fmt "d"
    let private D() = fmt "D"
    let private f() = fmt "f"
    let private F() = fmt "F"
    let private g() = fmt "g"
    let private G() = fmt "G"
    let private m() = fmt "G"
    let private M() = fmt "M"
    let private o() = fmt "o"
    let private O() = fmt "O"
    let private r() = fmt "r"
    let private R() = fmt "R"
    let private s() = fmt "s"
    let private t() = fmt "t"
    let private T() = fmt "T"
    let private u() = fmt "u"
    let private U() = fmt "U"
    let private y() = fmt "y"
    let private Y() = fmt "Y"

    let AddSpecifiers (flp: FlowLayoutPanel) = 
        flp.Controls.Add(d())
        flp.Controls.Add(D())
        flp.Controls.Add(f())
        flp.Controls.Add(F())
        flp.Controls.Add(g())
        flp.Controls.Add(G())
        flp.Controls.Add(G())
        flp.Controls.Add(m())
        flp.Controls.Add(M())
        flp.Controls.Add(o())
        flp.Controls.Add(O())
        flp.Controls.Add(r())
        flp.Controls.Add(R())
        flp.Controls.Add(s())
        flp.Controls.Add(t())
        flp.Controls.Add(T())
        flp.Controls.Add(u())
        flp.Controls.Add(U())
        flp.Controls.Add(y())
        flp.Controls.Add(Y())