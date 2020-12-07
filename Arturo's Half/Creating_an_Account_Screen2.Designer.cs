namespace WindowsFormsApp1
{
    partial class Creating_an_Account_Screen2
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
            this.accInfoLabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.reTypePasswordlabel = new System.Windows.Forms.Label();
            this.reTypePasswordtextBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accInfoLabel
            // 
            this.accInfoLabel.AutoSize = true;
            this.accInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accInfoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accInfoLabel.Location = new System.Drawing.Point(261, 9);
            this.accInfoLabel.Name = "accInfoLabel";
            this.accInfoLabel.Size = new System.Drawing.Size(301, 36);
            this.accInfoLabel.TabIndex = 1;
            this.accInfoLabel.Text = "Account Information";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.ForeColor = System.Drawing.Color.White;
            this.emaillabel.Location = new System.Drawing.Point(263, 92);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(51, 21);
            this.emaillabel.TabIndex = 5;
            this.emaillabel.Text = "Email";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(267, 116);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(300, 20);
            this.emailtextBox.TabIndex = 6;
            this.emailtextBox.TextChanged += new System.EventHandler(this.emailtextBox_TextChanged);            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.Brown;
            this.passwordlabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.ForeColor = System.Drawing.Color.White;
            this.passwordlabel.Location = new System.Drawing.Point(263, 166);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(82, 21);
            this.passwordlabel.TabIndex = 7;
            this.passwordlabel.Text = "Password";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(267, 190);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(300, 20);
            this.passwordtextBox.TabIndex = 8;
            this.passwordtextBox.TextChanged += new System.EventHandler(this.passwordtextBox_TextChanged);
            // 
            // reTypePasswordlabel
            // 
            this.reTypePasswordlabel.AutoSize = true;
            this.reTypePasswordlabel.BackColor = System.Drawing.Color.Brown;
            this.reTypePasswordlabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reTypePasswordlabel.ForeColor = System.Drawing.Color.White;
            this.reTypePasswordlabel.Location = new System.Drawing.Point(263, 238);
            this.reTypePasswordlabel.Name = "reTypePasswordlabel";
            this.reTypePasswordlabel.Size = new System.Drawing.Size(149, 21);
            this.reTypePasswordlabel.TabIndex = 9;
            this.reTypePasswordlabel.Text = "Re-Type Password";
            // 
            // reTypePasswordtextBox
            // 
            this.reTypePasswordtextBox.Location = new System.Drawing.Point(267, 262);
            this.reTypePasswordtextBox.Name = "reTypePasswordtextBox";
            this.reTypePasswordtextBox.Size = new System.Drawing.Size(300, 20);
            this.reTypePasswordtextBox.TabIndex = 10;
            this.reTypePasswordtextBox.TextChanged += new System.EventHandler(this.reTypePasswordtextBox_TextChanged);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(26, 424);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(104, 33);
            this.BackBtn.TabIndex = 41;
            this.BackBtn.Text = "< Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Part 2 of Creating an Account (Part 2 out of 3)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(741, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 43;
            this.button2.Text = "Next Part";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Creating_an_Account_Screen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(873, 483);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.reTypePasswordtextBox);
            this.Controls.Add(this.reTypePasswordlabel);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.accInfoLabel);
            this.Name = "Creating_an_Account_Screen2";
            this.Text = "Createing_an_Account_Screen2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accInfoLabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label reTypePasswordlabel;
        private System.Windows.Forms.TextBox reTypePasswordtextBox;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}