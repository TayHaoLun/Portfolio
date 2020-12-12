namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.studentNumTextBox = new System.Windows.Forms.TextBox();
            this.amdDualRadioButton = new System.Windows.Forms.RadioButton();
            this.amd64MRadioButton = new System.Windows.Forms.RadioButton();
            this.amdXMRadiotButton = new System.Windows.Forms.RadioButton();
            this.IntelRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hd100GCheckBox = new System.Windows.Forms.CheckBox();
            this.lcd17CheckBox = new System.Windows.Forms.CheckBox();
            this.eceStudCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "High end 80G HD, 14\'\' wide LCD notebooks";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(119, 50);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(134, 26);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // studentNumTextBox
            // 
            this.studentNumTextBox.Location = new System.Drawing.Point(119, 92);
            this.studentNumTextBox.Multiline = true;
            this.studentNumTextBox.Name = "studentNumTextBox";
            this.studentNumTextBox.Size = new System.Drawing.Size(134, 23);
            this.studentNumTextBox.TabIndex = 4;
            // 
            // amdDualRadioButton
            // 
            this.amdDualRadioButton.AutoSize = true;
            this.amdDualRadioButton.Location = new System.Drawing.Point(19, 37);
            this.amdDualRadioButton.Name = "amdDualRadioButton";
            this.amdDualRadioButton.Size = new System.Drawing.Size(152, 17);
            this.amdDualRadioButton.TabIndex = 7;
            this.amdDualRadioButton.TabStop = true;
            this.amdDualRadioButton.Text = "AMD 64 Dualcore ($3,180)";
            this.amdDualRadioButton.UseVisualStyleBackColor = true;
            // 
            // amd64MRadioButton
            // 
            this.amd64MRadioButton.AutoSize = true;
            this.amd64MRadioButton.Location = new System.Drawing.Point(19, 61);
            this.amd64MRadioButton.Name = "amd64MRadioButton";
            this.amd64MRadioButton.Size = new System.Drawing.Size(121, 17);
            this.amd64MRadioButton.TabIndex = 8;
            this.amd64MRadioButton.TabStop = true;
            this.amd64MRadioButton.Text = "Athlon M 64($2,880)";
            this.amd64MRadioButton.UseVisualStyleBackColor = true;
            // 
            // amdXMRadiotButton
            // 
            this.amdXMRadiotButton.AutoSize = true;
            this.amdXMRadiotButton.Location = new System.Drawing.Point(19, 85);
            this.amdXMRadiotButton.Name = "amdXMRadiotButton";
            this.amdXMRadiotButton.Size = new System.Drawing.Size(117, 17);
            this.amdXMRadiotButton.TabIndex = 9;
            this.amdXMRadiotButton.TabStop = true;
            this.amdXMRadiotButton.Text = "AMD XP-M($2,380)";
            this.amdXMRadiotButton.UseVisualStyleBackColor = true;
            // 
            // IntelRadioButton
            // 
            this.IntelRadioButton.AutoSize = true;
            this.IntelRadioButton.Location = new System.Drawing.Point(19, 109);
            this.IntelRadioButton.Name = "IntelRadioButton";
            this.IntelRadioButton.Size = new System.Drawing.Size(125, 17);
            this.IntelRadioButton.TabIndex = 10;
            this.IntelRadioButton.TabStop = true;
            this.IntelRadioButton.Text = "Intel Pentium($2,290)";
            this.IntelRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IntelRadioButton);
            this.groupBox1.Controls.Add(this.amdXMRadiotButton);
            this.groupBox1.Controls.Add(this.amd64MRadioButton);
            this.groupBox1.Controls.Add(this.amdDualRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(18, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 153);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select CPU";
            // 
            // hd100GCheckBox
            // 
            this.hd100GCheckBox.AutoSize = true;
            this.hd100GCheckBox.Location = new System.Drawing.Point(22, 20);
            this.hd100GCheckBox.Name = "hd100GCheckBox";
            this.hd100GCheckBox.Size = new System.Drawing.Size(95, 17);
            this.hd100GCheckBox.TabIndex = 12;
            this.hd100GCheckBox.Text = "100G HD($50)";
            this.hd100GCheckBox.UseVisualStyleBackColor = true;
            // 
            // lcd17CheckBox
            // 
            this.lcd17CheckBox.AutoSize = true;
            this.lcd17CheckBox.Location = new System.Drawing.Point(22, 43);
            this.lcd17CheckBox.Name = "lcd17CheckBox";
            this.lcd17CheckBox.Size = new System.Drawing.Size(90, 17);
            this.lcd17CheckBox.TabIndex = 13;
            this.lcd17CheckBox.Text = "17\'\' LCD($99)";
            this.lcd17CheckBox.UseVisualStyleBackColor = true;
            // 
            // eceStudCheckBox
            // 
            this.eceStudCheckBox.AutoSize = true;
            this.eceStudCheckBox.Location = new System.Drawing.Point(311, 243);
            this.eceStudCheckBox.Name = "eceStudCheckBox";
            this.eceStudCheckBox.Size = new System.Drawing.Size(121, 17);
            this.eceStudCheckBox.TabIndex = 14;
            this.eceStudCheckBox.Text = "ECE Students (20%)";
            this.eceStudCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lcd17CheckBox);
            this.groupBox2.Controls.Add(this.hd100GCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(289, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 81);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upgrades";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(48, 370);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(87, 56);
            this.QuitButton.TabIndex = 16;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(312, 368);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 58);
            this.OkButton.TabIndex = 17;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(45, 298);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(368, 57);
            this.messageLabel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 438);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.eceStudCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studentNumTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Best notebooks e-ordering";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox studentNumTextBox;
        private System.Windows.Forms.RadioButton amdDualRadioButton;
        private System.Windows.Forms.RadioButton amd64MRadioButton;
        private System.Windows.Forms.RadioButton amdXMRadiotButton;
        private System.Windows.Forms.RadioButton IntelRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox hd100GCheckBox;
        private System.Windows.Forms.CheckBox lcd17CheckBox;
        private System.Windows.Forms.CheckBox eceStudCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label messageLabel;
    }
}

