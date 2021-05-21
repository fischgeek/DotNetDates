
namespace DotNetDates
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpFormatMethods = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFormatSpecifiers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCustomFormats = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCreateYourOwn = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCreateYourOwnResult = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // flpFormatMethods
            // 
            this.flpFormatMethods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpFormatMethods.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpFormatMethods.Location = new System.Drawing.Point(12, 74);
            this.flpFormatMethods.Name = "flpFormatMethods";
            this.flpFormatMethods.Size = new System.Drawing.Size(240, 306);
            this.flpFormatMethods.TabIndex = 0;
            // 
            // flpFormatSpecifiers
            // 
            this.flpFormatSpecifiers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpFormatSpecifiers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpFormatSpecifiers.Location = new System.Drawing.Point(258, 74);
            this.flpFormatSpecifiers.Name = "flpFormatSpecifiers";
            this.flpFormatSpecifiers.Size = new System.Drawing.Size(242, 306);
            this.flpFormatSpecifiers.TabIndex = 0;
            // 
            // flpCustomFormats
            // 
            this.flpCustomFormats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpCustomFormats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpCustomFormats.Location = new System.Drawing.Point(506, 74);
            this.flpCustomFormats.Name = "flpCustomFormats";
            this.flpCustomFormats.Size = new System.Drawing.Size(438, 306);
            this.flpCustomFormats.TabIndex = 0;
            // 
            // flpCreateYourOwn
            // 
            this.flpCreateYourOwn.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCreateYourOwn.Location = new System.Drawing.Point(0, 0);
            this.flpCreateYourOwn.Name = "flpCreateYourOwn";
            this.flpCreateYourOwn.Size = new System.Drawing.Size(1232, 33);
            this.flpCreateYourOwn.TabIndex = 2;
            // 
            // flpCreateYourOwnResult
            // 
            this.flpCreateYourOwnResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCreateYourOwnResult.Location = new System.Drawing.Point(0, 33);
            this.flpCreateYourOwnResult.Name = "flpCreateYourOwnResult";
            this.flpCreateYourOwnResult.Size = new System.Drawing.Size(1232, 35);
            this.flpCreateYourOwnResult.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1104, 316);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1232, 387);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.flpCustomFormats);
            this.Controls.Add(this.flpFormatSpecifiers);
            this.Controls.Add(this.flpFormatMethods);
            this.Controls.Add(this.flpCreateYourOwnResult);
            this.Controls.Add(this.flpCreateYourOwn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFormatMethods;
        private System.Windows.Forms.FlowLayoutPanel flpFormatSpecifiers;
        private System.Windows.Forms.FlowLayoutPanel flpCustomFormats;
        private System.Windows.Forms.FlowLayoutPanel flpCreateYourOwn;
        private System.Windows.Forms.FlowLayoutPanel flpCreateYourOwnResult;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

