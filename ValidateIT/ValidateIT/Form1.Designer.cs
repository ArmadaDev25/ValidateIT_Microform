namespace ValidateIT
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
            generateBtn = new Button();
            inptBox = new TextBox();
            logBox = new ListBox();
            SuspendLayout();
            // 
            // generateBtn
            // 
            generateBtn.Location = new Point(46, 124);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(112, 34);
            generateBtn.TabIndex = 0;
            generateBtn.Text = "Generate";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // inptBox
            // 
            inptBox.Location = new Point(46, 87);
            inptBox.Name = "inptBox";
            inptBox.Size = new Size(150, 31);
            inptBox.TabIndex = 1;
            // 
            // logBox
            // 
            logBox.FormattingEnabled = true;
            logBox.ItemHeight = 25;
            logBox.Location = new Point(315, 87);
            logBox.Name = "logBox";
            logBox.Size = new Size(372, 304);
            logBox.TabIndex = 2;
            logBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logBox);
            Controls.Add(inptBox);
            Controls.Add(generateBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generateBtn;
        private TextBox inptBox;
        private ListBox logBox;
    }
}
