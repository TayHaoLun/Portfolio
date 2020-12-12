namespace TrailLabTest2
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.amdDualRadioButton = new System.Windows.Forms.RadioButton();
            this.amd64MRadioButton = new System.Windows.Forms.RadioButton();
            this.amdXMRadiotButton = new System.Windows.Forms.RadioButton();
            this.IntelRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eceStudCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(127, 35);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(287, 29);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // amdDualRadioButton
            // 
            this.amdDualRadioButton.AutoSize = true;
            this.amdDualRadioButton.Location = new System.Drawing.Point(6, 19);
            this.amdDualRadioButton.Name = "amdDualRadioButton";
            this.amdDualRadioButton.Size = new System.Drawing.Size(152, 17);
            this.amdDualRadioButton.TabIndex = 2;
            this.amdDualRadioButton.TabStop = true;
            this.amdDualRadioButton.Text = "AMD 64 Dualcore ($2,180)";
            this.amdDualRadioButton.UseVisualStyleBackColor = true;
            // 
            // amd64MRadioButton
            // 
            this.amd64MRadioButton.AutoSize = true;
            this.amd64MRadioButton.Location = new System.Drawing.Point(5, 58);
            this.amd64MRadioButton.Name = "amd64MRadioButton";
            this.amd64MRadioButton.Size = new System.Drawing.Size(124, 17);
            this.amd64MRadioButton.TabIndex = 3;
            this.amd64MRadioButton.TabStop = true;
            this.amd64MRadioButton.Text = "Athlon M 64 ($1,880)";
            this.amd64MRadioButton.UseVisualStyleBackColor = true;
            // 
            // amdXMRadiotButton
            // 
            this.amdXMRadiotButton.AutoSize = true;
            this.amdXMRadiotButton.Location = new System.Drawing.Point(5, 95);
            this.amdXMRadiotButton.Name = "amdXMRadiotButton";
            this.amdXMRadiotButton.Size = new System.Drawing.Size(120, 17);
            this.amdXMRadiotButton.TabIndex = 4;
            this.amdXMRadiotButton.TabStop = true;
            this.amdXMRadiotButton.Text = "AMD XP-M ($1,380)";
            this.amdXMRadiotButton.UseVisualStyleBackColor = true;
            // 
            // IntelRadioButton
            // 
            this.IntelRadioButton.AutoSize = true;
            this.IntelRadioButton.Location = new System.Drawing.Point(5, 129);
            this.IntelRadioButton.Name = "IntelRadioButton";
            this.IntelRadioButton.Size = new System.Drawing.Size(135, 17);
            this.IntelRadioButton.TabIndex = 5;
            this.IntelRadioButton.TabStop = true;
            this.IntelRadioButton.Text = "Intel Pentum M($1,290)";
            this.IntelRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IntelRadioButton);
            this.groupBox1.Controls.Add(this.amdXMRadiotButton);
            this.groupBox1.Controls.Add(this.amd64MRadioButton);
            this.groupBox1.Controls.Add(this.amdDualRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(31, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 160);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select CPU";
            // 
            // eceStudCheckBox
            // 
            this.eceStudCheckBox.Location = new System.Drawing.Point(398, 128);
            this.eceStudCheckBox.Name = "eceStudCheckBox";
            this.eceStudCheckBox.Size = new System.Drawing.Size(109, 39);
            this.eceStudCheckBox.TabIndex = 7;
            this.eceStudCheckBox.Text = "ECE students (18%)";
            this.eceStudCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Qty";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(56, 299);
            this.qtyTextBox.Multiline = true;
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(43, 24);
            this.qtyTextBox.TabIndex = 9;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(127, 366);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(97, 52);
            this.QuitButton.TabIndex = 10;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(356, 366);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(97, 52);
            this.OkButton.TabIndex = 11;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Location = new System.Drawing.Point(120, 332);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(387, 31);
            this.messageLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 443);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eceStudCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Best notebooks e-ordering";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RadioButton amdDualRadioButton;
        private System.Windows.Forms.RadioButton amd64MRadioButton;
        private System.Windows.Forms.RadioButton amdXMRadiotButton;
        private System.Windows.Forms.RadioButton IntelRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox eceStudCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label messageLabel;
    }
}

