namespace mit
{
    partial class LineStyleDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_dashdot = new System.Windows.Forms.RadioButton();
            this.radio_dot = new System.Windows.Forms.RadioButton();
            this.radio_dash = new System.Windows.Forms.RadioButton();
            this.radio_solid = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_green = new System.Windows.Forms.RadioButton();
            this.radio_red = new System.Windows.Forms.RadioButton();
            this.radio_blue = new System.Windows.Forms.RadioButton();
            this.radio_black = new System.Windows.Forms.RadioButton();
            this.LineStyle_OK = new System.Windows.Forms.Button();
            this.LineStyle_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_dashdot);
            this.groupBox1.Controls.Add(this.radio_dot);
            this.groupBox1.Controls.Add(this.radio_dash);
            this.groupBox1.Controls.Add(this.radio_solid);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pattern";
            // 
            // radio_dashdot
            // 
            this.radio_dashdot.AutoSize = true;
            this.radio_dashdot.Location = new System.Drawing.Point(30, 107);
            this.radio_dashdot.Name = "radio_dashdot";
            this.radio_dashdot.Size = new System.Drawing.Size(67, 17);
            this.radio_dashdot.TabIndex = 3;
            this.radio_dashdot.Text = "DashDot";
            this.radio_dashdot.UseVisualStyleBackColor = true;
            // 
            // radio_dot
            // 
            this.radio_dot.AutoSize = true;
            this.radio_dot.Location = new System.Drawing.Point(30, 84);
            this.radio_dot.Name = "radio_dot";
            this.radio_dot.Size = new System.Drawing.Size(42, 17);
            this.radio_dot.TabIndex = 2;
            this.radio_dot.Text = "Dot";
            this.radio_dot.UseVisualStyleBackColor = true;
            // 
            // radio_dash
            // 
            this.radio_dash.AutoSize = true;
            this.radio_dash.Location = new System.Drawing.Point(30, 61);
            this.radio_dash.Name = "radio_dash";
            this.radio_dash.Size = new System.Drawing.Size(50, 17);
            this.radio_dash.TabIndex = 1;
            this.radio_dash.Text = "Dash";
            this.radio_dash.UseVisualStyleBackColor = true;
            // 
            // radio_solid
            // 
            this.radio_solid.AutoSize = true;
            this.radio_solid.Checked = true;
            this.radio_solid.Location = new System.Drawing.Point(30, 38);
            this.radio_solid.Name = "radio_solid";
            this.radio_solid.Size = new System.Drawing.Size(48, 17);
            this.radio_solid.TabIndex = 0;
            this.radio_solid.TabStop = true;
            this.radio_solid.Text = "Solid";
            this.radio_solid.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_green);
            this.groupBox2.Controls.Add(this.radio_red);
            this.groupBox2.Controls.Add(this.radio_blue);
            this.groupBox2.Controls.Add(this.radio_black);
            this.groupBox2.Location = new System.Drawing.Point(196, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // radio_green
            // 
            this.radio_green.AutoSize = true;
            this.radio_green.Location = new System.Drawing.Point(32, 107);
            this.radio_green.Name = "radio_green";
            this.radio_green.Size = new System.Drawing.Size(54, 17);
            this.radio_green.TabIndex = 3;
            this.radio_green.Text = "Green";
            this.radio_green.UseVisualStyleBackColor = true;
            // 
            // radio_red
            // 
            this.radio_red.AutoSize = true;
            this.radio_red.Location = new System.Drawing.Point(32, 82);
            this.radio_red.Name = "radio_red";
            this.radio_red.Size = new System.Drawing.Size(45, 17);
            this.radio_red.TabIndex = 2;
            this.radio_red.Text = "Red";
            this.radio_red.UseVisualStyleBackColor = true;
            // 
            // radio_blue
            // 
            this.radio_blue.AutoSize = true;
            this.radio_blue.Location = new System.Drawing.Point(32, 59);
            this.radio_blue.Name = "radio_blue";
            this.radio_blue.Size = new System.Drawing.Size(46, 17);
            this.radio_blue.TabIndex = 1;
            this.radio_blue.Text = "Blue";
            this.radio_blue.UseVisualStyleBackColor = true;
            // 
            // radio_black
            // 
            this.radio_black.AutoSize = true;
            this.radio_black.Checked = true;
            this.radio_black.Location = new System.Drawing.Point(32, 36);
            this.radio_black.Name = "radio_black";
            this.radio_black.Size = new System.Drawing.Size(52, 17);
            this.radio_black.TabIndex = 0;
            this.radio_black.TabStop = true;
            this.radio_black.Text = "Black";
            this.radio_black.UseVisualStyleBackColor = true;
            // 
            // LineStyle_OK
            // 
            this.LineStyle_OK.Location = new System.Drawing.Point(157, 279);
            this.LineStyle_OK.Name = "LineStyle_OK";
            this.LineStyle_OK.Size = new System.Drawing.Size(75, 23);
            this.LineStyle_OK.TabIndex = 3;
            this.LineStyle_OK.Text = "OK";
            this.LineStyle_OK.UseVisualStyleBackColor = true;
            this.LineStyle_OK.Click += new System.EventHandler(this.LineStyle_OK_Click);
            // 
            // LineStyle_Cancel
            // 
            this.LineStyle_Cancel.Location = new System.Drawing.Point(257, 279);
            this.LineStyle_Cancel.Name = "LineStyle_Cancel";
            this.LineStyle_Cancel.Size = new System.Drawing.Size(75, 23);
            this.LineStyle_Cancel.TabIndex = 4;
            this.LineStyle_Cancel.Text = "Cancel";
            this.LineStyle_Cancel.UseVisualStyleBackColor = true;
            // 
            // LineStyleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 315);
            this.Controls.Add(this.LineStyle_Cancel);
            this.Controls.Add(this.LineStyle_OK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LineStyleDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Line Style Details";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LineStyleDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_dashdot;
        private System.Windows.Forms.RadioButton radio_dot;
        private System.Windows.Forms.RadioButton radio_dash;
        private System.Windows.Forms.RadioButton radio_solid;
        private System.Windows.Forms.RadioButton radio_green;
        private System.Windows.Forms.RadioButton radio_red;
        private System.Windows.Forms.RadioButton radio_blue;
        private System.Windows.Forms.RadioButton radio_black;
        private System.Windows.Forms.Button LineStyle_OK;
        private System.Windows.Forms.Button LineStyle_Cancel;

        //this is the pen whose value we get through this form and returned to set our drawing pen
        System.Drawing.Pen p;//default pen
    }
}