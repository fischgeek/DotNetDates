using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetDates.FSharp;

namespace DotNetDates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var form = this;
            FormBuilder.Build(form, flpFormatMethods, flpFormatSpecifiers, flpCustomFormats, flpCreateYourOwn, flpCreateYourOwnResult);
        }
    }
}
