﻿namespace DotNetDates.FSharp

open System.Windows.Forms
open System.Drawing
open Global
open FormatMethods
open FormatSpecifiers
open CustomFormats
open CreateYourOwn

module FormBuilder =
    let private backColor = Color.FromArgb(24, 26, 27)
    let private foreColor = Color.FromArgb(211, 207, 201)
    let private configurePanel (flp: FlowLayoutPanel) (baseWidth: int) = 
        flp.FlowDirection <- FlowDirection.TopDown
        flp.AutoScroll <- true
        flp.WrapContents <- false
        //flp.Width <- baseWidth
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
            configurePanel flpFormatMethods 250
            configurePanel flpFormatSpecifiers 700
            configurePanel flpCustomFormats 250
            ConfigureCreateYourOwnPanel flpCreateYourOwn flpCreateYourOwnResult flpCustomFormats
            AddMethods flpFormatMethods
            AddSpecifiers flpFormatSpecifiers
            AddCustomFormats flpCustomFormats