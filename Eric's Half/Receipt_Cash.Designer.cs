using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Software_Engineering
{
    [DesignerGenerated()]
    public partial class Reciept_Cash : Form
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
            TextBox1 = new TextBox();
            Label13 = new Label();
            Label11 = new Label();
            Label7 = new Label();
            Label6 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label12 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            TextBox3 = new TextBox();
            TextBox4 = new TextBox();
            TextBox5 = new TextBox();
            Label14 = new Label();
            TextBox2 = new TextBox();
            Button4 = new Button();
            Button3 = new Button();
            Button2 = new Button();
            Panel1 = new Panel();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button1.FlatStyle = FlatStyle.Popup;
            Button1.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button1.ForeColor = SystemColors.ControlText;
            Button1.Location = new Point(20, 15);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 25);
            Button1.TabIndex = 3;
            Button1.Text = "< Back";
            Button1.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft YaHei", 20.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlLightLight;
            Label1.Location = new Point(223, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(117, 36);
            Label1.TabIndex = 4;
            Label1.Text = "Receipt";
            // 
            // TextBox1
            // 
            TextBox1.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox1.Location = new Point(20, 63);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(100, 22);
            TextBox1.TabIndex = 5;
            TextBox1.Text = "Customer Name";
            TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.BackColor = Color.White;
            Label13.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.Location = new Point(27, 251);
            Label13.Name = "Label13";
            Label13.Size = new Size(43, 19);
            Label13.TabIndex = 31;
            Label13.Text = "Total";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.BackColor = Color.White;
            Label11.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label11.Location = new Point(27, 217);
            Label11.Name = "Label11";
            Label11.Size = new Size(81, 19);
            Label11.TabIndex = 30;
            Label11.Text = "Service Fee:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.BackColor = Color.White;
            Label7.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label7.Location = new Point(27, 190);
            Label7.Name = "Label7";
            Label7.Size = new Size(83, 19);
            Label7.TabIndex = 29;
            Label7.Text = "Hash Brown";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.White;
            Label6.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label6.Location = new Point(27, 160);
            Label6.Name = "Label6";
            Label6.Size = new Size(125, 19);
            Label6.TabIndex = 28;
            Label6.Text = "Breakfast Supreme";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.White;
            Label3.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(27, 128);
            Label3.Name = "Label3";
            Label3.Size = new Size(103, 19);
            Label3.TabIndex = 27;
            Label3.Text = "Garden Omelet";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.White;
            Label2.Font = new Font("Microsoft YaHei", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(6, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(63, 25);
            Label2.TabIndex = 26;
            Label2.Text = "Items";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = Color.White;
            Label12.Font = new Font("Microsoft YaHei", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.Location = new Point(172, 0);
            Label12.Name = "Label12";
            Label12.Size = new Size(57, 25);
            Label12.TabIndex = 32;
            Label12.Text = "Price";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.White;
            Label4.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(193, 251);
            Label4.Name = "Label4";
            Label4.Size = new Size(53, 19);
            Label4.TabIndex = 37;
            Label4.Text = "$18.06";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.White;
            Label5.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(193, 217);
            Label5.Name = "Label5";
            Label5.Size = new Size(45, 19);
            Label5.TabIndex = 36;
            Label5.Text = "$0.50";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = Color.White;
            Label8.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(193, 190);
            Label8.Name = "Label8";
            Label8.Size = new Size(45, 19);
            Label8.TabIndex = 35;
            Label8.Text = "$2.89";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = Color.White;
            Label9.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.Location = new Point(193, 160);
            Label9.Name = "Label9";
            Label9.Size = new Size(45, 19);
            Label9.TabIndex = 34;
            Label9.Text = "$6.99";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.BackColor = Color.White;
            Label10.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.Location = new Point(193, 128);
            Label10.Name = "Label10";
            Label10.Size = new Size(45, 19);
            Label10.TabIndex = 33;
            Label10.Text = "$4.79";
            // 
            // TextBox3
            // 
            TextBox3.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox3.Location = new Point(295, 186);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(100, 22);
            TextBox3.TabIndex = 42;
            TextBox3.Text = "2";
            TextBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox4
            // 
            TextBox4.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox4.Location = new Point(295, 156);
            TextBox4.Name = "TextBox4";
            TextBox4.Size = new Size(100, 22);
            TextBox4.TabIndex = 41;
            TextBox4.Text = "1";
            TextBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox5
            // 
            TextBox5.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox5.Location = new Point(295, 124);
            TextBox5.Name = "TextBox5";
            TextBox5.Size = new Size(100, 22);
            TextBox5.TabIndex = 40;
            TextBox5.Text = "1";
            TextBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Font = new Font("Microsoft YaHei", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.ForeColor = Color.White;
            Label14.Location = new Point(291, 88);
            Label14.Name = "Label14";
            Label14.Size = new Size(91, 25);
            Label14.TabIndex = 39;
            Label14.Text = "Quantity";
            // 
            // TextBox2
            // 
            TextBox2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox2.Location = new Point(421, 63);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(100, 22);
            TextBox2.TabIndex = 38;
            TextBox2.Text = "Order Number";
            TextBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Button4
            // 
            Button4.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button4.FlatStyle = FlatStyle.Popup;
            Button4.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button4.Location = new Point(229, 310);
            Button4.Name = "Button4";
            Button4.Size = new Size(75, 23);
            Button4.TabIndex = 45;
            Button4.Text = "Print";
            Button4.UseVisualStyleBackColor = false;
            // 
            // Button3
            // 
            Button3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button3.FlatStyle = FlatStyle.Popup;
            Button3.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button3.Location = new Point(342, 285);
            Button3.Name = "Button3";
            Button3.Size = new Size(75, 23);
            Button3.TabIndex = 44;
            Button3.Text = "Carryout";
            Button3.UseVisualStyleBackColor = false;
            // 
            // Button2
            // 
            Button2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button2.FlatStyle = FlatStyle.Popup;
            Button2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button2.Location = new Point(109, 285);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 43;
            Button2.Text = "Delivery";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(Label12);
            Panel1.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Panel1.Location = new Point(20, 91);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(235, 188);
            Panel1.TabIndex = 46;
            // 
            // Reciept_Cash
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(603, 341);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(TextBox3);
            Controls.Add(TextBox4);
            Controls.Add(TextBox5);
            Controls.Add(Label14);
            Controls.Add(TextBox2);
            Controls.Add(Label4);
            Controls.Add(Label5);
            Controls.Add(Label8);
            Controls.Add(Label9);
            Controls.Add(Label10);
            Controls.Add(Label13);
            Controls.Add(Label11);
            Controls.Add(Label7);
            Controls.Add(Label6);
            Controls.Add(Label3);
            Controls.Add(TextBox1);
            Controls.Add(Label1);
            Controls.Add(Button1);
            Controls.Add(Panel1);
            Name = "Reciept_Cash";
            Text = "Reciept_Cash";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Button Button1;
        internal Label Label1;
        internal TextBox TextBox1;
        internal Label Label13;
        internal Label Label11;
        internal Label Label7;
        internal Label Label6;
        internal Label Label3;
        internal Label Label2;
        internal Label Label12;
        internal Label Label4;
        internal Label Label5;
        internal Label Label8;
        internal Label Label9;
        internal Label Label10;
        internal TextBox TextBox3;
        internal TextBox TextBox4;
        internal TextBox TextBox5;
        internal Label Label14;
        internal TextBox TextBox2;
        internal Button Button4;
        internal Button Button3;
        internal Button Button2;
        internal Panel Panel1;
    }
}