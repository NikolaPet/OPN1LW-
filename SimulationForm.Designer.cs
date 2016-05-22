namespace OPN1LW_v1._2
{
    partial class SimulationForm
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
            this.ProteinInformationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BindProteinButton = new System.Windows.Forms.Button();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.UnbindProteinButton = new System.Windows.Forms.Button();
            this.AdditionalInfoLabel = new System.Windows.Forms.Label();
            this.SequenceTextBox = new System.Windows.Forms.TextBox();
            this.SequenceGuessButton = new System.Windows.Forms.Button();
            this.StartTranscriptionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProteinInformationLabel
            // 
            this.ProteinInformationLabel.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProteinInformationLabel.Location = new System.Drawing.Point(41, 407);
            this.ProteinInformationLabel.Name = "ProteinInformationLabel";
            this.ProteinInformationLabel.Size = new System.Drawing.Size(461, 181);
            this.ProteinInformationLabel.TabIndex = 1;
            this.ProteinInformationLabel.Text = "Селектирајте некој протеин.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Протеини";
            // 
            // BindProteinButton
            // 
            this.BindProteinButton.Enabled = false;
            this.BindProteinButton.Location = new System.Drawing.Point(22, 370);
            this.BindProteinButton.Name = "BindProteinButton";
            this.BindProteinButton.Size = new System.Drawing.Size(231, 23);
            this.BindProteinButton.TabIndex = 3;
            this.BindProteinButton.Text = "Сврзи го протеинот";
            this.BindProteinButton.UseVisualStyleBackColor = true;
            this.BindProteinButton.Click += new System.EventHandler(this.BindProteinButton_Click);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.Location = new System.Drawing.Point(546, 407);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(461, 181);
            this.InstructionsLabel.TabIndex = 4;
            this.InstructionsLabel.Text = "По селектирање на протеин, тука ќе бидат прикажани информации за инструкциите во " +
    "врска со тој протеин.";
            // 
            // UnbindProteinButton
            // 
            this.UnbindProteinButton.Enabled = false;
            this.UnbindProteinButton.Location = new System.Drawing.Point(286, 370);
            this.UnbindProteinButton.Name = "UnbindProteinButton";
            this.UnbindProteinButton.Size = new System.Drawing.Size(231, 23);
            this.UnbindProteinButton.TabIndex = 5;
            this.UnbindProteinButton.Text = "Отстрани го протеинот";
            this.UnbindProteinButton.UseVisualStyleBackColor = true;
            this.UnbindProteinButton.Click += new System.EventHandler(this.UnbindProteinButton_Click);
            // 
            // AdditionalInfoLabel
            // 
            this.AdditionalInfoLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalInfoLabel.Location = new System.Drawing.Point(1075, 407);
            this.AdditionalInfoLabel.Name = "AdditionalInfoLabel";
            this.AdditionalInfoLabel.Size = new System.Drawing.Size(253, 181);
            this.AdditionalInfoLabel.TabIndex = 6;
            this.AdditionalInfoLabel.Text = "Дополнителни информации во врска со селектираниот протеин:";
            // 
            // SequenceTextBox
            // 
            this.SequenceTextBox.Enabled = false;
            this.SequenceTextBox.Location = new System.Drawing.Point(587, 372);
            this.SequenceTextBox.Name = "SequenceTextBox";
            this.SequenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.SequenceTextBox.TabIndex = 7;
            // 
            // SequenceGuessButton
            // 
            this.SequenceGuessButton.Location = new System.Drawing.Point(748, 369);
            this.SequenceGuessButton.Name = "SequenceGuessButton";
            this.SequenceGuessButton.Size = new System.Drawing.Size(75, 23);
            this.SequenceGuessButton.TabIndex = 8;
            this.SequenceGuessButton.Text = "Погоди";
            this.SequenceGuessButton.UseVisualStyleBackColor = true;
            this.SequenceGuessButton.Click += new System.EventHandler(this.SequenceGuessButton_Click);
            // 
            // StartTranscriptionButton
            // 
            this.StartTranscriptionButton.Location = new System.Drawing.Point(863, 369);
            this.StartTranscriptionButton.Name = "StartTranscriptionButton";
            this.StartTranscriptionButton.Size = new System.Drawing.Size(157, 23);
            this.StartTranscriptionButton.TabIndex = 9;
            this.StartTranscriptionButton.Text = "Започни транскрипција";
            this.StartTranscriptionButton.UseVisualStyleBackColor = true;
            this.StartTranscriptionButton.Click += new System.EventHandler(this.StartTranscriptionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Секвенца:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "p300";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Arnt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "STAT1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "FOX04";
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 636);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartTranscriptionButton);
            this.Controls.Add(this.SequenceGuessButton);
            this.Controls.Add(this.SequenceTextBox);
            this.Controls.Add(this.AdditionalInfoLabel);
            this.Controls.Add(this.UnbindProteinButton);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.BindProteinButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProteinInformationLabel);
            this.Name = "SimulationForm";
            this.Text = "SimulationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimulationForm_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SimulationForm_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SimulationForm_MouseDoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProteinInformationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BindProteinButton;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.Button UnbindProteinButton;
        private System.Windows.Forms.Label AdditionalInfoLabel;
        private System.Windows.Forms.TextBox SequenceTextBox;
        private System.Windows.Forms.Button SequenceGuessButton;
        private System.Windows.Forms.Button StartTranscriptionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}