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
            this.Record = new System.Windows.Forms.Button();
            this.StopRecord = new System.Windows.Forms.Button();
            this.SendText = new System.Windows.Forms.Button();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TranslateFromAudio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TranlatetoAudio = new System.Windows.Forms.ComboBox();
            this.TranslateToText = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TranslateFromText = new System.Windows.Forms.ComboBox();
            this.Timer = new System.Windows.Forms.Label();
            this.SendAudio = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Record
            // 
            this.Record.Location = new System.Drawing.Point(73, 375);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(75, 23);
            this.Record.TabIndex = 0;
            this.Record.Text = "Record";
            this.Record.UseVisualStyleBackColor = true;
            this.Record.Click += new System.EventHandler(this.RecordStart);
            // 
            // StopRecord
            // 
            this.StopRecord.Location = new System.Drawing.Point(181, 375);
            this.StopRecord.Name = "StopRecord";
            this.StopRecord.Size = new System.Drawing.Size(75, 23);
            this.StopRecord.TabIndex = 1;
            this.StopRecord.Text = "Stop";
            this.StopRecord.UseVisualStyleBackColor = true;
            this.StopRecord.Click += new System.EventHandler(this.RecordStop);
            // 
            // SendText
            // 
            this.SendText.Location = new System.Drawing.Point(586, 400);
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(75, 23);
            this.SendText.TabIndex = 2;
            this.SendText.Text = "Send";
            this.SendText.UseVisualStyleBackColor = true;
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(586, 161);
            this.TextInput.Multiline = true;
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(348, 58);
            this.TextInput.TabIndex = 3;
            this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Record to input";
            // 
            // TranslateFromAudio
            // 
            this.TranslateFromAudio.FormattingEnabled = true;
            this.TranslateFromAudio.Items.AddRange(new object[] {
            "Arabic",
            "Chinese Simplified",
            "Chinese Traditional",
            "English",
            "French",
            "German",
            "Italian",
            "Japanese",
            "Portuguese",
            "Russian",
            "Spanish"});
            this.TranslateFromAudio.Location = new System.Drawing.Point(151, 136);
            this.TranslateFromAudio.Name = "TranslateFromAudio";
            this.TranslateFromAudio.Size = new System.Drawing.Size(121, 21);
            this.TranslateFromAudio.TabIndex = 6;
            this.TranslateFromAudio.SelectedIndexChanged += new System.EventHandler(this.TranslateFrom1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Translate From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Translate To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Type to input";
            // 
            // TranlatetoAudio
            // 
            this.TranlatetoAudio.FormattingEnabled = true;
            this.TranlatetoAudio.Items.AddRange(new object[] {
            "Arabic",
            "Chinese Simplified",
            "Chinese Traditional",
            "English",
            "French",
            "German",
            "Italian",
            "Japanese",
            "Portuguese",
            "Russian",
            "Spanish"});
            this.TranlatetoAudio.Location = new System.Drawing.Point(151, 198);
            this.TranlatetoAudio.Name = "TranlatetoAudio";
            this.TranlatetoAudio.Size = new System.Drawing.Size(121, 21);
            this.TranlatetoAudio.TabIndex = 11;
            this.TranlatetoAudio.SelectedIndexChanged += new System.EventHandler(this.Tranlateto1_SelectedIndexChanged);
            // 
            // TranslateToText
            // 
            this.TranslateToText.FormattingEnabled = true;
            this.TranslateToText.Items.AddRange(new object[] {
            "Arabic",
            "Chinese Simplified",
            "Chinese Traditional",
            "English",
            "French",
            "German",
            "Italian",
            "Japanese",
            "Portuguese",
            "Russian",
            "Spanish"});
            this.TranslateToText.Location = new System.Drawing.Point(664, 319);
            this.TranslateToText.Name = "TranslateToText";
            this.TranslateToText.Size = new System.Drawing.Size(121, 21);
            this.TranslateToText.TabIndex = 16;
            this.TranslateToText.SelectedIndexChanged += new System.EventHandler(this.TranslateTo2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(585, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Translate To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(583, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Translate From";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(811, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 13;
            // 
            // TranslateFromText
            // 
            this.TranslateFromText.FormattingEnabled = true;
            this.TranslateFromText.Items.AddRange(new object[] {
            "Arabic",
            "Chinese Simplified",
            "Chinese Traditional",
            "English",
            "French",
            "German",
            "Italian",
            "Japanese",
            "Portuguese",
            "Russian",
            "Spanish"});
            this.TranslateFromText.Location = new System.Drawing.Point(664, 257);
            this.TranslateFromText.Name = "TranslateFromText";
            this.TranslateFromText.Size = new System.Drawing.Size(121, 21);
            this.TranslateFromText.TabIndex = 12;
            this.TranslateFromText.SelectedIndexChanged += new System.EventHandler(this.TranslateFrom2_SelectedIndexChanged);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(70, 326);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(33, 13);
            this.Timer.TabIndex = 17;
            this.Timer.Text = "Timer";
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // SendAudio
            // 
            this.SendAudio.Location = new System.Drawing.Point(73, 469);
            this.SendAudio.Name = "SendAudio";
            this.SendAudio.Size = new System.Drawing.Size(75, 23);
            this.SendAudio.TabIndex = 18;
            this.SendAudio.Text = "Send";
            this.SendAudio.UseVisualStyleBackColor = true;
            this.SendAudio.Click += new System.EventHandler(this.SendAudio_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Voice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 683);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SendAudio);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.TranslateToText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TranslateFromText);
            this.Controls.Add(this.TranlatetoAudio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TranslateFromAudio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.SendText);
            this.Controls.Add(this.StopRecord);
            this.Controls.Add(this.Record);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.Button StopRecord;
        private System.Windows.Forms.Button SendText;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TranslateFromAudio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TranlatetoAudio;
        private System.Windows.Forms.ComboBox TranslateToText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TranslateFromText;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Button SendAudio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
    }
}

