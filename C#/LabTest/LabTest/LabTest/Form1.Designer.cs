namespace LabTest
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
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.pwtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chocoButton = new System.Windows.Forms.RadioButton();
            this.durianButton = new System.Windows.Forms.RadioButton();
            this.cheesebutton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.weighttextBox = new System.Windows.Forms.TextBox();
            this.devcheckBox = new System.Windows.Forms.CheckBox();
            this.confrimlabel = new System.Windows.Forms.Label();
            this.messagelabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(83, 18);
            this.nametextBox.Multiline = true;
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(264, 27);
            this.nametextBox.TabIndex = 2;
            // 
            // pwtextBox
            // 
            this.pwtextBox.Location = new System.Drawing.Point(83, 51);
            this.pwtextBox.Multiline = true;
            this.pwtextBox.Name = "pwtextBox";
            this.pwtextBox.PasswordChar = '*';
            this.pwtextBox.Size = new System.Drawing.Size(184, 24);
            this.pwtextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pwtextBox);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log in";
            // 
            // chocoButton
            // 
            this.chocoButton.AutoSize = true;
            this.chocoButton.Location = new System.Drawing.Point(6, 19);
            this.chocoButton.Name = "chocoButton";
            this.chocoButton.Size = new System.Drawing.Size(117, 17);
            this.chocoButton.TabIndex = 5;
            this.chocoButton.TabStop = true;
            this.chocoButton.Text = "Chocolate ($26/kg)";
            this.chocoButton.UseVisualStyleBackColor = true;
            // 
            // durianButton
            // 
            this.durianButton.AutoSize = true;
            this.durianButton.Location = new System.Drawing.Point(6, 42);
            this.durianButton.Name = "durianButton";
            this.durianButton.Size = new System.Drawing.Size(100, 17);
            this.durianButton.TabIndex = 6;
            this.durianButton.TabStop = true;
            this.durianButton.Text = "Durian ($30/kg)";
            this.durianButton.UseVisualStyleBackColor = true;
            // 
            // cheesebutton
            // 
            this.cheesebutton.AutoSize = true;
            this.cheesebutton.Location = new System.Drawing.Point(6, 65);
            this.cheesebutton.Name = "cheesebutton";
            this.cheesebutton.Size = new System.Drawing.Size(102, 17);
            this.cheesebutton.TabIndex = 7;
            this.cheesebutton.TabStop = true;
            this.cheesebutton.Text = "Cheese($33/kg)";
            this.cheesebutton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cheesebutton);
            this.groupBox2.Controls.Add(this.durianButton);
            this.groupBox2.Controls.Add(this.chocoButton);
            this.groupBox2.Location = new System.Drawing.Point(30, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 132);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a cake";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Weight (Kg)";
            // 
            // weighttextBox
            // 
            this.weighttextBox.Location = new System.Drawing.Point(392, 153);
            this.weighttextBox.Multiline = true;
            this.weighttextBox.Name = "weighttextBox";
            this.weighttextBox.Size = new System.Drawing.Size(88, 29);
            this.weighttextBox.TabIndex = 10;
            // 
            // devcheckBox
            // 
            this.devcheckBox.AutoSize = true;
            this.devcheckBox.Location = new System.Drawing.Point(344, 200);
            this.devcheckBox.Name = "devcheckBox";
            this.devcheckBox.Size = new System.Drawing.Size(136, 17);
            this.devcheckBox.TabIndex = 11;
            this.devcheckBox.Text = "With Delivery (extra $7)";
            this.devcheckBox.UseVisualStyleBackColor = true;
            // 
            // confrimlabel
            // 
            this.confrimlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrimlabel.Location = new System.Drawing.Point(42, 307);
            this.confrimlabel.Name = "confrimlabel";
            this.confrimlabel.Size = new System.Drawing.Size(111, 23);
            this.confrimlabel.TabIndex = 12;
            this.confrimlabel.Text = "ConfirmLabel";
            // 
            // messagelabel
            // 
            this.messagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagelabel.Location = new System.Drawing.Point(42, 330);
            this.messagelabel.Name = "messagelabel";
            this.messagelabel.Size = new System.Drawing.Size(339, 91);
            this.messagelabel.TabIndex = 13;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(66, 497);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(72, 46);
            this.quitButton.TabIndex = 14;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(309, 497);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(77, 46);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 583);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.messagelabel);
            this.Controls.Add(this.confrimlabel);
            this.Controls.Add(this.devcheckBox);
            this.Controls.Add(this.weighttextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Mama Cake Ordering System";
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
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox pwtextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton chocoButton;
        private System.Windows.Forms.RadioButton durianButton;
        private System.Windows.Forms.RadioButton cheesebutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox weighttextBox;
        private System.Windows.Forms.CheckBox devcheckBox;
        private System.Windows.Forms.Label confrimlabel;
        private System.Windows.Forms.Label messagelabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button okButton;
    }
}

