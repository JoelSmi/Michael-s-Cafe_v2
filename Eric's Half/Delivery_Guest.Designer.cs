using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Software_Engineering
{
    [DesignerGenerated()]
    public partial class Delivery_Guest : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.PhoneNumberText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ZipText = new System.Windows.Forms.TextBox();
            this.StateText = new System.Windows.Forms.TextBox();
            this.CityText = new System.Windows.Forms.TextBox();
            this.AptNumText = new System.Windows.Forms.TextBox();
            this.StreetNameText = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(222, 37);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(127, 36);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Delivery";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(41, 51);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 25);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberText.Location = new System.Drawing.Point(225, 97);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(100, 22);
            this.PhoneNumberText.TabIndex = 11;
            this.PhoneNumberText.Text = "Phone Number";
            this.PhoneNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameText.Location = new System.Drawing.Point(41, 97);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(100, 22);
            this.FirstNameText.TabIndex = 10;
            this.FirstNameText.Text = "First Name";
            this.FirstNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(38, 153);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(94, 19);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Enter Address";
            // 
            // ZipText
            // 
            this.ZipText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipText.Location = new System.Drawing.Point(246, 198);
            this.ZipText.Name = "ZipText";
            this.ZipText.Size = new System.Drawing.Size(79, 22);
            this.ZipText.TabIndex = 21;
            this.ZipText.Text = "Zipcode";
            this.ZipText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ZipText.TextChanged += new System.EventHandler(this.ZipText_TextChanged);
            // 
            // StateText
            // 
            this.StateText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateText.Location = new System.Drawing.Point(165, 198);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(65, 22);
            this.StateText.TabIndex = 20;
            this.StateText.Text = "State";
            this.StateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StateText.TextChanged += new System.EventHandler(this.StateText_TextChanged);
            // 
            // CityText
            // 
            this.CityText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityText.Location = new System.Drawing.Point(41, 198);
            this.CityText.Name = "CityText";
            this.CityText.Size = new System.Drawing.Size(106, 22);
            this.CityText.TabIndex = 19;
            this.CityText.Text = "City";
            this.CityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CityText.TextChanged += new System.EventHandler(this.CityText_TextChanged);
            // 
            // AptNumText
            // 
            this.AptNumText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AptNumText.Location = new System.Drawing.Point(260, 172);
            this.AptNumText.Name = "AptNumText";
            this.AptNumText.Size = new System.Drawing.Size(65, 22);
            this.AptNumText.TabIndex = 18;
            this.AptNumText.Text = "Apt #";
            // 
            // StreetNameText
            // 
            this.StreetNameText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetNameText.Location = new System.Drawing.Point(41, 172);
            this.StreetNameText.Name = "StreetNameText";
            this.StreetNameText.Size = new System.Drawing.Size(213, 22);
            this.StreetNameText.TabIndex = 17;
            this.StreetNameText.Text = "Street Name";
            this.StreetNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StreetNameText.TextChanged += new System.EventHandler(this.StreetNameText_TextChanged);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(277, 285);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 22;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // LastNameText
            // 
            this.LastNameText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameText.Location = new System.Drawing.Point(41, 123);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(100, 22);
            this.LastNameText.TabIndex = 23;
            this.LastNameText.Text = "Last Name";
            this.LastNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Delivery_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(545, 335);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ZipText);
            this.Controls.Add(this.StateText);
            this.Controls.Add(this.CityText);
            this.Controls.Add(this.AptNumText);
            this.Controls.Add(this.StreetNameText);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PhoneNumberText);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BackButton);
            this.Name = "Delivery_Guest";
            this.Text = "Delivery_Guest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Label Label1;
        internal Button BackButton;
        internal TextBox PhoneNumberText;
        internal TextBox FirstNameText;
        internal Label Label2;
        internal TextBox ZipText;
        internal TextBox StateText;
        internal TextBox CityText;
        internal TextBox AptNumText;
        internal TextBox StreetNameText;
        internal Button NextButton;
        internal TextBox LastNameText;
    }
}