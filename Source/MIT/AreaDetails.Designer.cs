namespace mit
{
    partial class AreaDetails
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
            this.AreaName = new System.Windows.Forms.TextBox();
            this.AreaName_OK = new System.Windows.Forms.Button();
            this.AreaName_Cancel = new System.Windows.Forms.Button();
            this.error_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Specify a Name of the area";
            // 
            // AreaName
            // 
            this.AreaName.Location = new System.Drawing.Point(102, 36);
            this.AreaName.Name = "AreaName";
            this.AreaName.Size = new System.Drawing.Size(156, 20);
            this.AreaName.TabIndex = 1;
            // 
            // AreaName_OK
            // 
            this.AreaName_OK.Location = new System.Drawing.Point(89, 71);
            this.AreaName_OK.Name = "AreaName_OK";
            this.AreaName_OK.Size = new System.Drawing.Size(75, 23);
            this.AreaName_OK.TabIndex = 2;
            this.AreaName_OK.Text = "OK";
            this.AreaName_OK.UseVisualStyleBackColor = true;
            this.AreaName_OK.Click += new System.EventHandler(this.AreaName_OK_Click);
            // 
            // AreaName_Cancel
            // 
            this.AreaName_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AreaName_Cancel.Location = new System.Drawing.Point(183, 71);
            this.AreaName_Cancel.Name = "AreaName_Cancel";
            this.AreaName_Cancel.Size = new System.Drawing.Size(75, 23);
            this.AreaName_Cancel.TabIndex = 3;
            this.AreaName_Cancel.Text = "Cancel";
            this.AreaName_Cancel.UseVisualStyleBackColor = true;
            this.AreaName_Cancel.Click += new System.EventHandler(this.AreaName_Cancel_Click);
            // 
            // error_Label
            // 
            this.error_Label.AutoSize = true;
            this.error_Label.ForeColor = System.Drawing.Color.Red;
            this.error_Label.Location = new System.Drawing.Point(21, 96);
            this.error_Label.Name = "error_Label";
            this.error_Label.Size = new System.Drawing.Size(16, 13);
            this.error_Label.TabIndex = 4;
            this.error_Label.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Area Name";
            // 
            // AreaDetails
            // 
            this.AcceptButton = this.AreaName_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AreaName_Cancel;
            this.ClientSize = new System.Drawing.Size(281, 120);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.error_Label);
            this.Controls.Add(this.AreaName_Cancel);
            this.Controls.Add(this.AreaName_OK);
            this.Controls.Add(this.AreaName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AreaDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Area Details";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AreaName;
        private System.Windows.Forms.Button AreaName_OK;
        private System.Windows.Forms.Button AreaName_Cancel;

        #region Used for user made variables

        private string areaname;

        #endregion
        private System.Windows.Forms.Label error_Label;
        private System.Windows.Forms.Label label2;
    }
}