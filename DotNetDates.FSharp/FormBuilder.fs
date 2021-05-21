namespace DotNetDates.FSharp

open System.Windows.Forms
open System.Drawing
open FormatMethods
open FormatSpecifiers
open CustomFormats
open CreateYourOwn

module FormBuilder =
    let private backColor = Color.FromArgb(24, 26, 27)
    let private foreColor = Color.FromArgb(211, 207, 201)
    let private configurePanel (flp: FlowLayoutPanel) = 
        flp.FlowDirection <- FlowDirection.TopDown
        flp.AutoScroll <- true
        flp.WrapContents <- false
        flp.BackColor <- backColor
        flp.ForeColor <- foreColor

    let private configureForm (frm: Form) = 
        frm.BackColor <- backColor
        frm.ForeColor <- foreColor

    let Build 
        (frm: Form)
        (flpFormatMethods: FlowLayoutPanel) 
        (flpFormatSpecifiers: FlowLayoutPanel) 
        (flpCustomFormats: FlowLayoutPanel) 
        (flpCreateYourOwn: FlowLayoutPanel)
        (flpCreateYourOwnResult: FlowLayoutPanel) = 
            configureForm frm
            configurePanel flpFormatMethods
            configurePanel flpFormatSpecifiers
            configurePanel flpCustomFormats
            ConfigureCreateYourOwnPanel flpCreateYourOwn flpCreateYourOwnResult flpCustomFormats
            AddMethods flpFormatMethods
            AddSpecifiers flpFormatSpecifiers
            AddCustomFormats flpCustomFormats