namespace ActiveWindowsManager
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
            this.setButton = new System.Windows.Forms.Button();
            this.setText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.validerButton = new System.Windows.Forms.Button();
            this.checkBoxAlt = new System.Windows.Forms.CheckBox();
            this.checkBoxCtrl = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(12, 12);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 0;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // setText
            // 
            this.setText.Enabled = false;
            this.setText.Location = new System.Drawing.Point(106, 15);
            this.setText.Name = "setText";
            this.setText.Size = new System.Drawing.Size(98, 20);
            this.setText.TabIndex = 1;
            this.setText.Text = "Set keybind";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 187);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(165, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 213);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(165, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(12, 239);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(165, 20);
            this.textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 265);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(165, 20);
            this.textBox8.TabIndex = 9;
            // 
            // validerButton
            // 
            this.validerButton.Location = new System.Drawing.Point(146, 293);
            this.validerButton.Name = "validerButton";
            this.validerButton.Size = new System.Drawing.Size(104, 24);
            this.validerButton.TabIndex = 11;
            this.validerButton.Text = "Valider";
            this.validerButton.UseVisualStyleBackColor = true;
            this.validerButton.Click += new System.EventHandler(this.validerButton_Click);
            // 
            // checkBoxAlt
            // 
            this.checkBoxAlt.AutoSize = true;
            this.checkBoxAlt.Location = new System.Drawing.Point(12, 51);
            this.checkBoxAlt.Name = "checkBoxAlt";
            this.checkBoxAlt.Size = new System.Drawing.Size(46, 17);
            this.checkBoxAlt.TabIndex = 12;
            this.checkBoxAlt.Text = "ALT";
            this.checkBoxAlt.UseVisualStyleBackColor = true;
            // 
            // checkBoxCtrl
            // 
            this.checkBoxCtrl.AutoSize = true;
            this.checkBoxCtrl.Location = new System.Drawing.Point(106, 51);
            this.checkBoxCtrl.Name = "checkBoxCtrl";
            this.checkBoxCtrl.Size = new System.Drawing.Size(54, 17);
            this.checkBoxCtrl.TabIndex = 13;
            this.checkBoxCtrl.Text = "CTRL";
            this.checkBoxCtrl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 329);
            this.Controls.Add(this.checkBoxCtrl);
            this.Controls.Add(this.checkBoxAlt);
            this.Controls.Add(this.validerButton);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.setText);
            this.Controls.Add(this.setButton);
            this.Name = "Form1";
            this.Text = "Switcharou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox setText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button validerButton;
        private System.Windows.Forms.CheckBox checkBoxAlt;
        private System.Windows.Forms.CheckBox checkBoxCtrl;
    }
}

