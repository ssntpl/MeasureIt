namespace mit
{
    partial class LineDetails
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
            if (disposing && (components != null))
            {
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
            this.label1 = new System.Windows.Forms.Label();
            this.LineName = new System.Windows.Forms.TextBox();
            this.LineName_ok = new System.Windows.Forms.Button();
            this.LineName_Cancel = new System.Windows.Forms.Button();
            this.error_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specify a Name for the line";
            // 
            // LineName
            // 
            this.LineName.Location = new System.Drawing.Point(85, 39);
            this.LineName.Name = "LineName";
            this.LineName.Size = new System.Drawing.Size(174, 20);
            this.LineName.TabIndex = 1;
            // 
            // LineName_ok
            // 
            this.LineName_ok.Location = new System.Drawing.Point(85, 76);
            this.LineName_ok.Name = "LineName_ok";
            this.LineName_ok.Size = new System.Drawing.Size(75, 23);
            this.LineName_ok.TabIndex = 2;
            this.LineName_ok.Text = "OK";
            this.LineName_ok.UseVisualStyleBackColor = true;
            this.LineName_ok.Click += new System.EventHandler(this.LineName_ok_Click);
            // 
            // LineName_Cancel
            // 
            this.LineName_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LineName_Cancel.Location = new System.Drawing.Point(184, 76);
            this.LineName_Cancel.Name = "LineName_Cancel";
            this.LineName_Cancel.Size = new System.Drawing.Size(75, 23);
            this.LineName_Cancel.TabIndex = 3;
            this.LineName_Cancel.Text = "Cancel";
            this.LineName_Cancel.UseVisualStyleBackColor = true;
            // 
            // error_Label
            // 
            this.error_Label.AutoSize = true;
            this.error_Label.ForeColor = System.Drawing.Color.Red;
            this.error_Label.Location = new System.Drawing.Point(33, 111);
            this.error_Label.Name = "error_Label";
            this.error_Label.Size = new System.Drawing.Size(13, 13);
            this.error_Label.TabIndex = 4;
            this.error_Label.Text = "..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Line Name";
            // 
            // LineDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 129);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.error_Label);
            this.Controls.Add(this.LineName_Cancel);
            this.Controls.Add(this.LineName_ok);
            this.Controls.Add(this.LineName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LineDetails";
            this.ShowInTaskbar = false;
            this.Text = "Line Details";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LineName;
        private System.Windows.Forms.Button LineName_ok;
        private System.Windows.Forms.Button LineName_Cancel;
        private System.Windows.Forms.Label error_Label;

        #region Used for user made variables

        private string linename;

        #endregion
        private System.Windows.Forms.Label label2;


    }
}