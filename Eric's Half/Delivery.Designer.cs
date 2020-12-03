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
            Label1 = new Label();
            Button1 = new Button();
            RadioButton1 = new RadioButton();
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            RadioButton2 = new RadioButton();
            Label2 = new Label();
            TextBox3 = new TextBox();
            TextBox4 = new TextBox();
            TextBox5 = new TextBox();
            TextBox6 = new TextBox();
            TextBox7 = new TextBox();
            Button2 = new Button();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft YaHei", 20.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlLightLight;
            Label1.Location = new Point(223, 30);
            Label1.Name = "Label1";
            Label1.Size = new Size(127, 36);
            Label1.TabIndex = 6;
            Label1.Text = "Delivery";
            // 
            // Button1
            // 
            Button1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button1.FlatStyle = FlatStyle.Popup;
            Button1.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button1.ForeColor = SystemColors.ControlText;
            Button1.Location = new Point(42, 44);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 25);
            Button1.TabIndex = 5;
            Button1.Text = "< Back";
            Button1.UseVisualStyleBackColor = false;
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            RadioButton1.ForeColor = Color.White;
            RadioButton1.Location = new Point(42, 137);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(150, 23);
            RadioButton1.TabIndex = 7;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "Use default Address";
            RadioButton1.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            TextBox1.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox1.Location = new Point(42, 88);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(100, 22);
            TextBox1.TabIndex = 8;
            TextBox1.Text = "Customer Name";
            TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox2
            // 
            TextBox2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox2.Location = new Point(213, 88);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(100, 22);
            TextBox2.TabIndex = 9;
            TextBox2.Text = "Phone Number";
            TextBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            RadioButton2.ForeColor = Color.White;
            RadioButton2.Location = new Point(287, 137);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(160, 23);
            RadioButton2.TabIndex = 10;
            RadioButton2.TabStop = true;
            RadioButton2.Text = "Use different Address";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(78, 160);
            Label2.Name = "Label2";
            Label2.Size = new Size(129, 16);
            Label2.TabIndex = 11;
            Label2.Text = "* Address confirmation";
            // 
            // TextBox3
            // 
            TextBox3.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox3.Location = new Point(273, 163);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(213, 22);
            TextBox3.TabIndex = 12;
            TextBox3.Text = "Street Name";
            TextBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox4
            // 
            TextBox4.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox4.Location = new Point(492, 163);
            TextBox4.Name = "TextBox4";
            TextBox4.Size = new Size(65, 22);
            TextBox4.TabIndex = 13;
            TextBox4.Text = "Apt #";
            // 
            // TextBox5
            // 
            TextBox5.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox5.Location = new Point(273, 189);
            TextBox5.Name = "TextBox5";
            TextBox5.Size = new Size(106, 22);
            TextBox5.TabIndex = 14;
            TextBox5.Text = "City";
            TextBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox6
            // 
            TextBox6.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox6.Location = new Point(397, 189);
            TextBox6.Name = "TextBox6";
            TextBox6.Size = new Size(65, 22);
            TextBox6.TabIndex = 15;
            TextBox6.Text = "State";
            TextBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox7
            // 
            TextBox7.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox7.Location = new Point(478, 189);
            TextBox7.Name = "TextBox7";
            TextBox7.Size = new Size(79, 22);
            TextBox7.TabIndex = 16;
            TextBox7.Text = "Zipcode";
            TextBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // Button2
            // 
            Button2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button2.FlatStyle = FlatStyle.Popup;
            Button2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button2.Location = new Point(238, 265);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 17;
            Button2.Text = "Next";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Delivery
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(569, 298);
            Controls.Add(Button2);
            Controls.Add(TextBox7);
            Controls.Add(TextBox6);
            Controls.Add(TextBox5);
            Controls.Add(TextBox4);
            Controls.Add(TextBox3);
            Controls.Add(Label2);
            Controls.Add(RadioButton2);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Controls.Add(RadioButton1);
            Controls.Add(Label1);
            Controls.Add(Button1);
            Name = "Delivery";
            Text = "Delivery";
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label1;
        internal Button Button1;
        internal RadioButton RadioButton1;
        internal TextBox TextBox1;
        internal TextBox TextBox2;
        internal RadioButton RadioButton2;
        internal Label Label2;
        internal TextBox TextBox3;
        internal TextBox TextBox4;
        internal TextBox TextBox5;
        internal TextBox TextBox6;
        internal TextBox TextBox7;
        internal Button Button2;
    }
}