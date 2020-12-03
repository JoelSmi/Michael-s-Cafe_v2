using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Software_Engineering
{
    [DesignerGenerated()]
    public partial class Payment : Form
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
            Button1 = new Button();
            Label1 = new Label();
            RadioButton1 = new RadioButton();
            RadioButton2 = new RadioButton();
            RadioButton3 = new RadioButton();
            RadioButton4 = new RadioButton();
            Label2 = new Label();
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            TextBox3 = new TextBox();
            Button2 = new Button();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button1.FlatStyle = FlatStyle.Popup;
            Button1.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button1.Location = new Point(60, 39);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 0;
            Button1.Text = "< Back";
            Button1.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft YaHei", 20.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlLightLight;
            Label1.Location = new Point(210, 23);
            Label1.Name = "Label1";
            Label1.Size = new Size(137, 36);
            Label1.TabIndex = 1;
            Label1.Text = "Payment";
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            RadioButton1.ForeColor = Color.White;
            RadioButton1.Location = new Point(77, 108);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(128, 20);
            RadioButton1.TabIndex = 2;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "Use Default Card";
            RadioButton1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            RadioButton2.ForeColor = Color.White;
            RadioButton2.Location = new Point(77, 179);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(132, 20);
            RadioButton2.TabIndex = 3;
            RadioButton2.TabStop = true;
            RadioButton2.Text = "Use Diferent Card";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            RadioButton3.AutoSize = true;
            RadioButton3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            RadioButton3.ForeColor = Color.White;
            RadioButton3.Location = new Point(346, 108);
            RadioButton3.Name = "RadioButton3";
            RadioButton3.Size = new Size(109, 20);
            RadioButton3.TabIndex = 4;
            RadioButton3.TabStop = true;
            RadioButton3.Text = "Pay with Cash";
            RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton4
            // 
            RadioButton4.AutoSize = true;
            RadioButton4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            RadioButton4.ForeColor = Color.White;
            RadioButton4.Location = new Point(346, 179);
            RadioButton4.Name = "RadioButton4";
            RadioButton4.Size = new Size(116, 20);
            RadioButton4.TabIndex = 5;
            RadioButton4.TabStop = true;
            RadioButton4.Text = "Pay with Check";
            RadioButton4.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(110, 128);
            Label2.Name = "Label2";
            Label2.Size = new Size(79, 13);
            Label2.TabIndex = 6;
            Label2.Text = "************1234";
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(89, 202);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(150, 20);
            TextBox1.TabIndex = 7;
            TextBox1.Text = "Card Number";
            // 
            // TextBox2
            // 
            TextBox2.Location = new Point(89, 228);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(77, 20);
            TextBox2.TabIndex = 8;
            TextBox2.Text = "Exp Date";
            // 
            // TextBox3
            // 
            TextBox3.Location = new Point(181, 228);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(58, 20);
            TextBox3.TabIndex = 9;
            TextBox3.Text = "CVV";
            // 
            // Button2
            // 
            Button2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button2.FlatStyle = FlatStyle.Popup;
            Button2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button2.Location = new Point(264, 261);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 10;
            Button2.Text = "Next";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(552, 310);
            Controls.Add(Button2);
            Controls.Add(TextBox3);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Controls.Add(Label2);
            Controls.Add(RadioButton4);
            Controls.Add(RadioButton3);
            Controls.Add(RadioButton2);
            Controls.Add(RadioButton1);
            Controls.Add(Label1);
            Controls.Add(Button1);
            Name = "Payment";
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        internal Button Button1;
        internal Label Label1;
        internal RadioButton RadioButton1;
        internal RadioButton RadioButton2;
        internal RadioButton RadioButton3;
        internal RadioButton RadioButton4;
        internal Label Label2;
        internal TextBox TextBox1;
        internal TextBox TextBox2;
        internal TextBox TextBox3;
        internal Button Button2;
    }
}