using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Software_Engineering
{
    [DesignerGenerated()]
    public partial class Delivery : Form
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
            this.DefaultAddButton = new System.Windows.Forms.RadioButton();
            this.CustomerNameText = new System.Windows.Forms.TextBox();
            this.PhoneNumberText = new System.Windows.Forms.TextBox();
            this.DiffAddButton = new System.Windows.Forms.RadioButton();
            this.CustomerAddressText = new System.Windows.Forms.Label();
            this.StreetNameText = new System.Windows.Forms.TextBox();
            this.AptNumText = new System.Windows.Forms.TextBox();
            this.CityText = new System.Windows.Forms.TextBox();
            this.StateText = new System.Windows.Forms.TextBox();
            this.ZipText = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(223, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(127, 36);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Delivery";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(42, 44);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 25);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // DefaultAddButton
            // 
            this.DefaultAddButton.AutoSize = true;
            this.DefaultAddButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultAddButton.ForeColor = System.Drawing.Color.White;
            this.DefaultAddButton.Location = new System.Drawing.Point(42, 137);
            this.DefaultAddButton.Name = "DefaultAddButton";
            this.DefaultAddButton.Size = new System.Drawing.Size(150, 23);
            this.DefaultAddButton.TabIndex = 7;
            this.DefaultAddButton.TabStop = true;
            this.DefaultAddButton.Text = "Use default Address";
            this.DefaultAddButton.UseVisualStyleBackColor = true;
            this.DefaultAddButton.CheckedChanged += new System.EventHandler(this.DefaultAddButton_CheckedChanged);
            // 
            // CustomerNameText
            // 
            this.CustomerNameText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameText.Location = new System.Drawing.Point(42, 88);
            this.CustomerNameText.Name = "CustomerNameText";
            this.CustomerNameText.Size = new System.Drawing.Size(100, 22);
            this.CustomerNameText.TabIndex = 8;
            this.CustomerNameText.Text = "Customer Name";
            this.CustomerNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberText.Location = new System.Drawing.Point(213, 88);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(100, 22);
            this.PhoneNumberText.TabIndex = 9;
            this.PhoneNumberText.Text = "Phone Number";
            this.PhoneNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumberText.TextChanged += new System.EventHandler(this.PhoneNumberText_TextChanged_1);
            // 
            // DiffAddButton
            // 
            this.DiffAddButton.AutoSize = true;
            this.DiffAddButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiffAddButton.ForeColor = System.Drawing.Color.White;
            this.DiffAddButton.Location = new System.Drawing.Point(287, 137);
            this.DiffAddButton.Name = "DiffAddButton";
            this.DiffAddButton.Size = new System.Drawing.Size(160, 23);
            this.DiffAddButton.TabIndex = 10;
            this.DiffAddButton.TabStop = true;
            this.DiffAddButton.Text = "Use different Address";
            this.DiffAddButton.UseVisualStyleBackColor = true;
            this.DiffAddButton.CheckedChanged += new System.EventHandler(this.DiffAddButton_CheckedChanged);
            // 
            // CustomerAddressText
            // 
            this.CustomerAddressText.AutoSize = true;
            this.CustomerAddressText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddressText.ForeColor = System.Drawing.Color.White;
            this.CustomerAddressText.Location = new System.Drawing.Point(78, 160);
            this.CustomerAddressText.Name = "CustomerAddressText";
            this.CustomerAddressText.Size = new System.Drawing.Size(129, 16);
            this.CustomerAddressText.TabIndex = 11;
            this.CustomerAddressText.Text = "* Address confirmation";
            // 
            // StreetNameText
            // 
            this.StreetNameText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetNameText.Location = new System.Drawing.Point(273, 163);
            this.StreetNameText.Name = "StreetNameText";
            this.StreetNameText.Size = new System.Drawing.Size(213, 22);
            this.StreetNameText.TabIndex = 12;
            this.StreetNameText.Text = "Street Name";
            this.StreetNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AptNumText
            // 
            this.AptNumText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AptNumText.Location = new System.Drawing.Point(492, 163);
            this.AptNumText.Name = "AptNumText";
            this.AptNumText.Size = new System.Drawing.Size(65, 22);
            this.AptNumText.TabIndex = 13;
            this.AptNumText.Text = "Apt #";
            // 
            // CityText
            // 
            this.CityText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityText.Location = new System.Drawing.Point(273, 189);
            this.CityText.Name = "CityText";
            this.CityText.Size = new System.Drawing.Size(106, 22);
            this.CityText.TabIndex = 14;
            this.CityText.Text = "City";
            this.CityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StateText
            // 
            this.StateText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateText.Location = new System.Drawing.Point(397, 189);
            this.StateText.Name = "StateText";
            this.StateText.Size = new System.Drawing.Size(65, 22);
            this.StateText.TabIndex = 15;
            this.StateText.Text = "State";
            this.StateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ZipText
            // 
            this.ZipText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipText.Location = new System.Drawing.Point(478, 189);
            this.ZipText.Name = "ZipText";
            this.ZipText.Size = new System.Drawing.Size(79, 22);
            this.ZipText.TabIndex = 16;
            this.ZipText.Text = "Zipcode";
            this.ZipText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(238, 265);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 17;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(569, 298);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ZipText);
            this.Controls.Add(this.StateText);
            this.Controls.Add(this.CityText);
            this.Controls.Add(this.AptNumText);
            this.Controls.Add(this.StreetNameText);
            this.Controls.Add(this.CustomerAddressText);
            this.Controls.Add(this.DiffAddButton);
            this.Controls.Add(this.PhoneNumberText);
            this.Controls.Add(this.CustomerNameText);
            this.Controls.Add(this.DefaultAddButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BackButton);
            this.Name = "Delivery";
            this.Text = "Delivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Label Label1;
        internal Button BackButton;
        internal RadioButton DefaultAddButton;
        internal TextBox CustomerNameText;
        internal TextBox PhoneNumberText;
        internal RadioButton DiffAddButton;
        internal Label CustomerAddressText;
        internal TextBox StreetNameText;
        internal TextBox AptNumText;
        internal TextBox CityText;
        internal TextBox StateText;
        internal TextBox ZipText;
        internal Button NextButton;
    }
}