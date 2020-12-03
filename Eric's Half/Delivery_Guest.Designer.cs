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
            Label1 = new Label();
            Button1 = new Button();
            TextBox2 = new TextBox();
            TextBox1 = new TextBox();
            Label2 = new Label();
            TextBox7 = new TextBox();
            TextBox6 = new TextBox();
            TextBox5 = new TextBox();
            TextBox4 = new TextBox();
            TextBox3 = new TextBox();
            Button2 = new Button();
            TextBox8 = new TextBox();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft YaHei", 20.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlLightLight;
            Label1.Location = new Point(222, 37);
            Label1.Name = "Label1";
            Label1.Size = new Size(127, 36);
            Label1.TabIndex = 8;
            Label1.Text = "Delivery";
            // 
            // Button1
            // 
            Button1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button1.FlatStyle = FlatStyle.Popup;
            Button1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button1.ForeColor = SystemColors.ControlText;
            Button1.Location = new Point(41, 51);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 25);
            Button1.TabIndex = 7;
            Button1.Text = "< Back";
            Button1.UseVisualStyleBackColor = false;
            // 
            // TextBox2
            // 
            TextBox2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox2.Location = new Point(225, 97);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(100, 22);
            TextBox2.TabIndex = 11;
            TextBox2.Text = "Phone Number";
            TextBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox1
            // 
            TextBox1.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox1.Location = new Point(41, 97);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(100, 22);
            TextBox1.TabIndex = 10;
            TextBox1.Text = "First Name";
            TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(38, 153);
            Label2.Name = "Label2";
            Label2.Size = new Size(94, 19);
            Label2.TabIndex = 12;
            Label2.Text = "Enter Address";
            // 
            // TextBox7
            // 
            TextBox7.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox7.Location = new Point(246, 198);
            TextBox7.Name = "TextBox7";
            TextBox7.Size = new Size(79, 22);
            TextBox7.TabIndex = 21;
            TextBox7.Text = "Zipcode";
            TextBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox6
            // 
            TextBox6.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox6.Location = new Point(165, 198);
            TextBox6.Name = "TextBox6";
            TextBox6.Size = new Size(65, 22);
            TextBox6.TabIndex = 20;
            TextBox6.Text = "State";
            TextBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox5
            // 
            TextBox5.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox5.Location = new Point(41, 198);
            TextBox5.Name = "TextBox5";
            TextBox5.Size = new Size(106, 22);
            TextBox5.TabIndex = 19;
            TextBox5.Text = "City";
            TextBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox4
            // 
            TextBox4.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox4.Location = new Point(260, 172);
            TextBox4.Name = "TextBox4";
            TextBox4.Size = new Size(65, 22);
            TextBox4.TabIndex = 18;
            TextBox4.Text = "Apt #";
            // 
            // TextBox3
            // 
            TextBox3.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox3.Location = new Point(41, 172);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(213, 22);
            TextBox3.TabIndex = 17;
            TextBox3.Text = "Street Name";
            TextBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Button2
            // 
            Button2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button2.FlatStyle = FlatStyle.Popup;
            Button2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button2.Location = new Point(277, 285);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 22;
            Button2.Text = "Next";
            Button2.UseVisualStyleBackColor = false;
            // 
            // TextBox8
            // 
            TextBox8.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox8.Location = new Point(41, 123);
            TextBox8.Name = "TextBox8";
            TextBox8.Size = new Size(100, 22);
            TextBox8.TabIndex = 23;
            TextBox8.Text = "Last Name";
            TextBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // Delivery_Guest
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(545, 335);
            Controls.Add(TextBox8);
            Controls.Add(Button2);
            Controls.Add(TextBox7);
            Controls.Add(TextBox6);
            Controls.Add(TextBox5);
            Controls.Add(TextBox4);
            Controls.Add(TextBox3);
            Controls.Add(Label2);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Controls.Add(Label1);
            Controls.Add(Button1);
            Name = "Delivery_Guest";
            Text = "Delivery_Guest";
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label1;
        internal Button Button1;
        internal TextBox TextBox2;
        internal TextBox TextBox1;
        internal Label Label2;
        internal TextBox TextBox7;
        internal TextBox TextBox6;
        internal TextBox TextBox5;
        internal TextBox TextBox4;
        internal TextBox TextBox3;
        internal Button Button2;
        internal TextBox TextBox8;
    }
}