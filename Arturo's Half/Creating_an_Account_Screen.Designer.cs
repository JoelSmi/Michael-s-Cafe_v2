namespace WindowsFormsApp1
{
    partial class Creating_an_Account_Screen
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
            this.accountlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonalInfoLabel = new System.Windows.Forms.Label();
            this.gendertextBox = new System.Windows.Forms.TextBox();
            this.genderlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateofbirthlabel1 = new System.Windows.Forms.Label();
            this.LastNametextBox2 = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.firstNametextBox1 = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountlbl
            // 
            this.accountlbl.AutoSize = true;
            this.accountlbl.Location = new System.Drawing.Point(73, 75);
            this.accountlbl.Name = "accountlbl";
            this.accountlbl.Size = new System.Drawing.Size(102, 13);
            this.accountlbl.TabIndex = 1;
            this.accountlbl.Text = "Account Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BackBtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PersonalInfoLabel);
            this.panel1.Controls.Add(this.gendertextBox);
            this.panel1.Controls.Add(this.genderlabel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dateofbirthlabel1);
            this.panel1.Controls.Add(this.LastNametextBox2);
            this.panel1.Controls.Add(this.LastNameLabel);
            this.panel1.Controls.Add(this.firstNametextBox1);
            this.panel1.Controls.Add(this.firstNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 543);
            this.panel1.TabIndex = 2;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(11, 488);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(104, 33);
            this.BackBtn.TabIndex = 45;
            this.BackBtn.Text = "< Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(761, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 33);
            this.button2.TabIndex = 44;
            this.button2.Text = "Next Part";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Part 1 of Creating an Account (Part 1 out of 3)";
            // 
            // PersonalInfoLabel
            // 
            this.PersonalInfoLabel.AutoSize = true;
            this.PersonalInfoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalInfoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PersonalInfoLabel.Location = new System.Drawing.Point(273, 8);
            this.PersonalInfoLabel.Name = "PersonalInfoLabel";
            this.PersonalInfoLabel.Size = new System.Drawing.Size(306, 36);
            this.PersonalInfoLabel.TabIndex = 2;
            this.PersonalInfoLabel.Text = "Personal Information";
            // 
            // gendertextBox
            // 
            this.gendertextBox.Location = new System.Drawing.Point(279, 313);
            this.gendertextBox.Name = "gendertextBox";
            this.gendertextBox.Size = new System.Drawing.Size(300, 20);
            this.gendertextBox.TabIndex = 10;
            this.gendertextBox.TextChanged += new System.EventHandler(this.gendertextBox_TextChanged);
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlabel.ForeColor = System.Drawing.Color.White;
            this.genderlabel.Location = new System.Drawing.Point(275, 289);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(66, 21);
            this.genderlabel.TabIndex = 9;
            this.genderlabel.Text = "Gender";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateofbirthlabel1
            // 
            this.dateofbirthlabel1.AutoSize = true;
            this.dateofbirthlabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateofbirthlabel1.ForeColor = System.Drawing.Color.White;
            this.dateofbirthlabel1.Location = new System.Drawing.Point(275, 222);
            this.dateofbirthlabel1.Name = "dateofbirthlabel1";
            this.dateofbirthlabel1.Size = new System.Drawing.Size(108, 21);
            this.dateofbirthlabel1.TabIndex = 7;
            this.dateofbirthlabel1.Text = "Date of Birth";
            // 
            // LastNametextBox2
            // 
            this.LastNametextBox2.Location = new System.Drawing.Point(279, 184);
            this.LastNametextBox2.Name = "LastNametextBox2";
            this.LastNametextBox2.Size = new System.Drawing.Size(300, 20);
            this.LastNametextBox2.TabIndex = 6;
            this.LastNametextBox2.TextChanged += new System.EventHandler(this.LastNametextBox2_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.White;
            this.LastNameLabel.Location = new System.Drawing.Point(275, 160);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(91, 21);
            this.LastNameLabel.TabIndex = 5;
            this.LastNameLabel.Text = "Last Name";
            // 
            // firstNametextBox1
            // 
            this.firstNametextBox1.Location = new System.Drawing.Point(279, 122);
            this.firstNametextBox1.Name = "firstNametextBox1";
            this.firstNametextBox1.Size = new System.Drawing.Size(300, 20);
            this.firstNametextBox1.TabIndex = 4;
            this.firstNametextBox1.TextChanged += new System.EventHandler(this.firstNametextBox1_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.White;
            this.firstNameLabel.Location = new System.Drawing.Point(277, 98);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(93, 21);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name";
            // 
            // Creating_an_Account_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(879, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accountlbl);
            this.Name = "Creating_an_Account_Screen";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Creating_an_Account_Screen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label accountlbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PersonalInfoLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox gendertextBox;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label dateofbirthlabel1;
        private System.Windows.Forms.TextBox LastNametextBox2;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox firstNametextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BackBtn;
    }
}