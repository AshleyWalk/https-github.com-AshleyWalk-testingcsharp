namespace testing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_getresult = new System.Windows.Forms.Button();
            this.inputtextname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_getresult
            // 
            this.btn_getresult.Location = new System.Drawing.Point(83, 505);
            this.btn_getresult.Name = "btn_getresult";
            this.btn_getresult.Size = new System.Drawing.Size(225, 69);
            this.btn_getresult.TabIndex = 0;
            this.btn_getresult.Text = "button1";
            this.btn_getresult.UseVisualStyleBackColor = true;
            this.btn_getresult.Click += new System.EventHandler(this.btn_getresult_Click);
            // 
            // inputtextname
            // 
            this.inputtextname.Location = new System.Drawing.Point(12, 12);
            this.inputtextname.Name = "inputtextname";
            this.inputtextname.Size = new System.Drawing.Size(300, 55);
            this.inputtextname.TabIndex = 1;
            this.inputtextname.TextChanged += new System.EventHandler(this.textBox1_inputtextname);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 717);
            this.Controls.Add(this.inputtextname);
            this.Controls.Add(this.btn_getresult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_getresult;
        private TextBox inputtextname;
    }
}