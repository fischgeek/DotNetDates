
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flpFormatSpecifiers = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flpCustomFormats = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCreateYourOwn = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCreateYourOwnResult = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpFormatMethods
            // 
            this.flpFormatMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFormatMethods.Location = new System.Drawing.Point(0, 0);
            this.flpFormatMethods.Name = "flpFormatMethods";
            this.flpFormatMethods.Size = new System.Drawing.Size(242, 352);
            this.flpFormatMethods.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 138);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flpFormatMethods);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(932, 352);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.TabIndex = 1;
            // 
            // flpFormatSpecifiers
            // 
            this.flpFormatSpecifiers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFormatSpecifiers.Location = new System.Drawing.Point(0, 0);
            this.flpFormatSpecifiers.Name = "flpFormatSpecifiers";
            this.flpFormatSpecifiers.Size = new System.Drawing.Size(381, 352);
            this.flpFormatSpecifiers.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flpFormatSpecifiers);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flpCustomFormats);
            this.splitContainer2.Size = new System.Drawing.Size(686, 352);
            this.splitContainer2.SplitterDistance = 381;
            this.splitContainer2.TabIndex = 1;
            // 
            // flpCustomFormats
            // 
            this.flpCustomFormats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCustomFormats.Location = new System.Drawing.Point(0, 0);
            this.flpCustomFormats.Name = "flpCustomFormats";
            this.flpCustomFormats.Size = new System.Drawing.Size(301, 352);
            this.flpCustomFormats.TabIndex = 0;
            // 
            // flpCreateYourOwn
            // 
            this.flpCreateYourOwn.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCreateYourOwn.Location = new System.Drawing.Point(0, 0);
            this.flpCreateYourOwn.Name = "flpCreateYourOwn";
            this.flpCreateYourOwn.Size = new System.Drawing.Size(932, 45);
            this.flpCreateYourOwn.TabIndex = 2;
            // 
            // flpCreateYourOwnResult
            // 
            this.flpCreateYourOwnResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCreateYourOwnResult.Location = new System.Drawing.Point(0, 45);
            this.flpCreateYourOwnResult.Name = "flpCreateYourOwnResult";
            this.flpCreateYourOwnResult.Size = new System.Drawing.Size(932, 40);
            this.flpCreateYourOwnResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(932, 490);
            this.Controls.Add(this.flpCreateYourOwnResult);
            this.Controls.Add(this.flpCreateYourOwn);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFormatMethods;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flpFormatSpecifiers;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flpCustomFormats;
        private System.Windows.Forms.FlowLayoutPanel flpCreateYourOwn;
        private System.Windows.Forms.FlowLayoutPanel flpCreateYourOwnResult;
    }
}

