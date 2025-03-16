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
            label1 = new Label();
            label2 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 37);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 3;
            label1.Text = "Program Logs";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 37);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 4;
            label2.Text = "Input a Value";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logBox);
            Controls.Add(inptBox);
            Controls.Add(generateBtn);
            Name = "Form1";
            Text = "ValidateIT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generateBtn;
        private TextBox inptBox;
        private ListBox logBox;
        private Label label1;
        private Label label2;
    }
}
