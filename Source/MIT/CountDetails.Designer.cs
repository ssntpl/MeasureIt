namespace mit
{
    partial class CountDetails
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
            this.CountName_OK = new System.Windows.Forms.Button();
            this.CountDetails_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CountName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CountName_OK
            // 
            this.CountName_OK.Location = new System.Drawing.Point(23, 71);
            this.CountName_OK.Name = "CountName_OK";
            this.CountName_OK.Size = new System.Drawing.Size(75, 23);
            this.CountName_OK.TabIndex = 0;
            this.CountName_OK.Text = "OK";
            this.CountName_OK.UseVisualStyleBackColor = true;
            this.CountName_OK.Click += new System.EventHandler(this.CountName_OK_Click);
            // 
            // CountDetails_Cancel
            // 
            this.CountDetails_Cancel.Location = new System.Drawing.Point(110, 71);
            this.CountDetails_Cancel.Name = "CountDetails_Cancel";
            this.CountDetails_Cancel.Size = new System.Drawing.Size(75, 23);
            this.CountDetails_Cancel.TabIndex = 1;
            this.CountDetails_Cancel.Text = "Cancel";
            this.CountDetails_Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Specify the name of the entity to be counted";
            // 
            // CountName
            // 
            this.CountName.Location = new System.Drawing.Point(23, 34);
            this.CountName.Name = "CountName";
            this.CountName.Size = new System.Drawing.Size(162, 20);
            this.CountName.TabIndex = 3;
            // 
            // CountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 115);
            this.Controls.Add(this.CountName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountDetails_Cancel);
            this.Controls.Add(this.CountName_OK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountDetails";
            this.Text = "CountDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CountName_OK;
        private System.Windows.Forms.Button CountDetails_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountName;
    }
}