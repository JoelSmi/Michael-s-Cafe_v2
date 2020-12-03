using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Software_Engineering
{
    [DesignerGenerated()]
    public partial class Payment_Guest : Form
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
            RadioButton3 = new RadioButton();
            RadioButton4 = new RadioButton();
            RadioButton2 = new RadioButton();
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
            Button1.Location = new Point(62, 40);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 1;
            Button1.Text = "< Back";
            Button1.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft YaHei", 20.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlLightLight;
            Label1.Location = new Point(206, 26);
            Label1.Name = "Label1";
            Label1.Size = new Size(137, 36);
            Label1.TabIndex = 2;
            Label1.Text = "Payment";
            // 
            // RadioButton3
            // 
            RadioButton3.AutoSize = true;
            RadioButton3.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            RadioButton3.ForeColor = Color.White;
            RadioButton3.Location = new Point(350, 113);
            RadioButton3.Name = "RadioButton3";
            RadioButton3.Size = new Size(113, 23);
            RadioButton3.TabIndex = 5;
            RadioButton3.TabStop = true;
            RadioButton3.Text = "Pay with Cash";
            RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton4
            // 
            RadioButton4.AutoSize = true;
            RadioButton4.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            RadioButton4.ForeColor = Color.White;
            RadioButton4.Location = new Point(350, 188);
            RadioButton4.Name = "RadioButton4";
            RadioButton4.Size = new Size(121, 23);
            RadioButton4.TabIndex = 6;
            RadioButton4.TabStop = true;
            RadioButton4.Text = "Pay with Check";
            RadioButton4.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            RadioButton2.ForeColor = Color.White;
            RadioButton2.Location = new Point(62, 113);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(112, 23);
            RadioButton2.TabIndex = 7;
            RadioButton2.TabStop = true;
            RadioButton2.Text = "Pay with Card";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // TextBox1
            // 
            TextBox1.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox1.Location = new Point(80, 139);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(150, 22);
            TextBox1.TabIndex = 8;
            TextBox1.Text = "Card Number";
            // 
            // TextBox2
            // 
            TextBox2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox2.Location = new Point(80, 165);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(77, 22);
            TextBox2.TabIndex = 9;
            TextBox2.Text = "Exp Date";
            // 
            // TextBox3
            // 
            TextBox3.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox3.Location = new Point(172, 165);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(58, 22);
            TextBox3.TabIndex = 10;
            TextBox3.Text = "CVV";
            // 
            // Button2
            // 
            Button2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button2.FlatStyle = FlatStyle.Popup;
            Button2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button2.Location = new Point(248, 259);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 11;
            Button2.Text = "Next";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Payment_Guest
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(546, 313);
            Controls.Add(Button2);
            Controls.Add(TextBox3);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Controls.Add(RadioButton2);
            Controls.Add(RadioButton4);
            Controls.Add(RadioButton3);
            Controls.Add(Label1);
            Controls.Add(Button1);
            Name = "Payment_Guest";
            Text = "Payment_Guest";
            ResumeLayout(false);
            PerformLayout();
        }

        internal Button Button1;
        internal Label Label1;
        internal RadioButton RadioButton3;
        internal RadioButton RadioButton4;
        internal RadioButton RadioButton2;
        internal TextBox TextBox1;
        internal TextBox TextBox2;
        internal TextBox TextBox3;
        internal Button Button2;
    }
}