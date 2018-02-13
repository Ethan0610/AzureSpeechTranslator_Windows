namespace AzureSpeechTranslator_Windows_
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
            this.SendText = new System.Windows.Forms.Button();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TranslateToText = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TranslateFromText = new System.Windows.Forms.ComboBox();
            this.textOutputLabel = new System.Windows.Forms.Label();
            this.speakButton = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendText
            // 
            this.SendText.Location = new System.Drawing.Point(56, 427);
            this.SendText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(100, 27);
            this.SendText.TabIndex = 2;
            this.SendText.Text = "Send";
            this.SendText.UseVisualStyleBackColor = true;
            this.SendText.Click += new System.EventHandler(this.SendText_Click);
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(55, 132);
            this.TextInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(463, 116);
            this.TextInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type in or ";
            // 
            // TranslateToText
            // 
            this.TranslateToText.FormattingEnabled = true;
            this.TranslateToText.Location = new System.Drawing.Point(195, 353);
            this.TranslateToText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TranslateToText.Name = "TranslateToText";
            this.TranslateToText.Size = new System.Drawing.Size(160, 23);
            this.TranslateToText.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 361);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Translate To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 281);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Translate From";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(355, 220);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 13;
            // 
            // TranslateFromText
            // 
            this.TranslateFromText.FormattingEnabled = true;
            this.TranslateFromText.Location = new System.Drawing.Point(195, 281);
            this.TranslateFromText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TranslateFromText.Name = "TranslateFromText";
            this.TranslateFromText.Size = new System.Drawing.Size(160, 23);
            this.TranslateFromText.TabIndex = 12;
            // 
            // textOutputLabel
            // 
            this.textOutputLabel.BackColor = System.Drawing.SystemColors.Window;
            this.textOutputLabel.Location = new System.Drawing.Point(57, 487);
            this.textOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textOutputLabel.Name = "textOutputLabel";
            this.textOutputLabel.Size = new System.Drawing.Size(461, 203);
            this.textOutputLabel.TabIndex = 21;
            // 
            // speakButton
            // 
            this.speakButton.Enabled = false;
            this.speakButton.Location = new System.Drawing.Point(61, 693);
            this.speakButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.speakButton.Name = "speakButton";
            this.speakButton.Size = new System.Drawing.Size(100, 27);
            this.speakButton.TabIndex = 22;
            this.speakButton.Text = "Speak";
            this.speakButton.UseVisualStyleBackColor = true;
            this.speakButton.Click += new System.EventHandler(this.speakButton_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(135, 88);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(100, 27);
            this.StartBtn.TabIndex = 23;
            this.StartBtn.Text = "Record";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(243, 88);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(100, 27);
            this.StopBtn.TabIndex = 24;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 788);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.speakButton);
            this.Controls.Add(this.textOutputLabel);
            this.Controls.Add(this.TranslateToText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TranslateFromText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.SendText);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SendText;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TranslateToText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TranslateFromText;
        private System.Windows.Forms.Label textOutputLabel;
        private System.Windows.Forms.Button speakButton;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
    }
}

