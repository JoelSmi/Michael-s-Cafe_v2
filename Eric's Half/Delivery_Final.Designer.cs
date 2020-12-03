using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Software_Engineering
{
    [DesignerGenerated()]
    public partial class Delivery_Final : Form
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
            TextBox3 = new TextBox();
            TextBox4 = new TextBox();
            TextBox5 = new TextBox();
            Label2 = new Label();
            Button2 = new Button();
            Label3 = new Label();
            Label13 = new Label();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft YaHei", 20.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlLightLight;
            Label1.Location = new Point(215, 38);
            Label1.Name = "Label1";
            Label1.Size = new Size(127, 36);
            Label1.TabIndex = 10;
            Label1.Text = "Delivery";
            // 
            // Button1
            // 
            Button1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button1.FlatStyle = FlatStyle.Popup;
            Button1.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button1.ForeColor = SystemColors.ControlText;
            Button1.Location = new Point(34, 52);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 25);
            Button1.TabIndex = 9;
            Button1.Text = "< Back";
            Button1.UseVisualStyleBackColor = false;
            // 
            // TextBox2
            // 
            TextBox2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox2.Location = new Point(218, 96);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(100, 22);
            TextBox2.TabIndex = 13;
            TextBox2.Text = "Phone Number";
            TextBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox1
            // 
            TextBox1.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox1.Location = new Point(34, 96);
            TextBox1.Name = "TextBox1";
            TextBox1.ReadOnly = true;
            TextBox1.Size = new Size(100, 22);
            TextBox1.TabIndex = 12;
            TextBox1.Text = "Customer Name";
            TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox3
            // 
            TextBox3.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox3.Location = new Point(447, 96);
            TextBox3.Name = "TextBox3";
            TextBox3.ReadOnly = true;
            TextBox3.Size = new Size(100, 22);
            TextBox3.TabIndex = 39;
            TextBox3.Text = "Order Number";
            TextBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox4
            // 
            TextBox4.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox4.Location = new Point(34, 137);
            TextBox4.Name = "TextBox4";
            TextBox4.ReadOnly = true;
            TextBox4.Size = new Size(100, 22);
            TextBox4.TabIndex = 40;
            TextBox4.Text = "Deliverer Name";
            TextBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox5
            // 
            TextBox5.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox5.Location = new Point(34, 181);
            TextBox5.Name = "TextBox5";
            TextBox5.Size = new Size(100, 22);
            TextBox5.TabIndex = 41;
            TextBox5.Text = "Delivery Address";
            TextBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(31, 204);
            Label2.Name = "Label2";
            Label2.Size = new Size(126, 16);
            Label2.TabIndex = 42;
            Label2.Text = "*Show address chosen";
            // 
            // Button2
            // 
            Button2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button2.FlatStyle = FlatStyle.Popup;
            Button2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button2.Location = new Point(270, 256);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 43;
            Button2.Text = "Done";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(219, 137);
            Label3.Name = "Label3";
            Label3.Size = new Size(82, 16);
            Label3.TabIndex = 44;
            Label3.Text = "Ordered Items";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.ForeColor = Color.White;
            Label13.Location = new Point(215, 204);
            Label13.Name = "Label13";
            Label13.Size = new Size(59, 19);
            Label13.TabIndex = 45;
            Label13.Text = "Total: $";
            // 
            // Delivery_Final
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(549, 315);
            Controls.Add(Label13);
            Controls.Add(Label3);
            Controls.Add(Button2);
            Controls.Add(Label2);
            Controls.Add(TextBox5);
            Controls.Add(TextBox4);
            Controls.Add(TextBox3);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Controls.Add(Label1);
            Controls.Add(Button1);
            Name = "Delivery_Final";
            Text = "Delivery_Final";
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label1;
        internal Button Button1;
        internal TextBox TextBox2;
        internal TextBox TextBox1;
        internal TextBox TextBox3;
        internal TextBox TextBox4;
        internal TextBox TextBox5;
        internal Label Label2;
        internal Button Button2;
        internal Label Label3;
        internal Label Label13;
    }
}