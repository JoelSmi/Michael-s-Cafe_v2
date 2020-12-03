using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Software_Engineering
{
    [DesignerGenerated()]
    public partial class OrderSummary : Form
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
            _Button1 = new Button();
            _Button1.Click += new EventHandler(Button1_Click);
            _Label2 = new Label();
            _Label2.Click += new EventHandler(Label2_Click);
            _Label3 = new Label();
            _Label3.Click += new EventHandler(Label3_Click);
            Label4 = new Label();
            Label5 = new Label();
            _Label6 = new Label();
            _Label6.Click += new EventHandler(Label6_Click);
            _Label7 = new Label();
            _Label7.Click += new EventHandler(Label7_Click);
            Label8 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            TextBox1 = new TextBox();
            TextBox2 = new TextBox();
            TextBox3 = new TextBox();
            Button2 = new Button();
            Button3 = new Button();
            Button4 = new Button();
            _Label11 = new Label();
            _Label11.Click += new EventHandler(Label11_Click);
            Label12 = new Label();
            Label13 = new Label();
            Label14 = new Label();
            Button5 = new Button();
            Button6 = new Button();
            Panel1 = new Panel();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft YaHei", 20.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = SystemColors.ControlLightLight;
            Label1.Location = new Point(206, 26);
            Label1.Name = "Label1";
            Label1.Size = new Size(146, 36);
            Label1.TabIndex = 0;
            Label1.Text = "Summary";
            // 
            // Button1
            // 
            _Button1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            _Button1.FlatStyle = FlatStyle.Popup;
            _Button1.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _Button1.ForeColor = SystemColors.ControlText;
            _Button1.Location = new Point(57, 40);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(75, 25);
            _Button1.TabIndex = 1;
            _Button1.Text = "< Back";
            _Button1.UseVisualStyleBackColor = false;
            // 
            // Label2
            // 
            _Label2.AutoSize = true;
            _Label2.BackColor = Color.White;
            _Label2.Font = new Font("Microsoft YaHei", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label2.Location = new Point(94, 78);
            _Label2.Name = "_Label2";
            _Label2.Size = new Size(63, 25);
            _Label2.TabIndex = 2;
            _Label2.Text = "Items";
            // 
            // Label3
            // 
            _Label3.AutoSize = true;
            _Label3.BackColor = Color.White;
            _Label3.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label3.Location = new Point(95, 118);
            _Label3.Name = "_Label3";
            _Label3.Size = new Size(103, 19);
            _Label3.TabIndex = 3;
            _Label3.Text = "Garden Omelet";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.White;
            Label4.Font = new Font("Microsoft YaHei", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.Location = new Point(267, 78);
            Label4.Name = "Label4";
            Label4.Size = new Size(57, 25);
            Label4.TabIndex = 4;
            Label4.Text = "Price";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(367, 78);
            Label5.Name = "Label5";
            Label5.Size = new Size(78, 24);
            Label5.TabIndex = 5;
            Label5.Text = "Quantity";
            // 
            // Label6
            // 
            _Label6.AutoSize = true;
            _Label6.BackColor = Color.White;
            _Label6.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label6.Location = new Point(95, 150);
            _Label6.Name = "_Label6";
            _Label6.Size = new Size(125, 19);
            _Label6.TabIndex = 6;
            _Label6.Text = "Breakfast Supreme";
            // 
            // Label7
            // 
            _Label7.AutoSize = true;
            _Label7.BackColor = Color.White;
            _Label7.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label7.Location = new Point(95, 180);
            _Label7.Name = "_Label7";
            _Label7.Size = new Size(83, 19);
            _Label7.TabIndex = 7;
            _Label7.Text = "Hash Brown";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.BackColor = Color.White;
            Label8.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label8.Location = new Point(268, 118);
            Label8.Name = "Label8";
            Label8.Size = new Size(45, 19);
            Label8.TabIndex = 8;
            Label8.Text = "$4.79";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.BackColor = Color.White;
            Label9.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label9.Location = new Point(268, 150);
            Label9.Name = "Label9";
            Label9.Size = new Size(45, 19);
            Label9.TabIndex = 9;
            Label9.Text = "$6.99";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.BackColor = Color.White;
            Label10.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label10.Location = new Point(268, 180);
            Label10.Name = "Label10";
            Label10.Size = new Size(45, 19);
            Label10.TabIndex = 10;
            Label10.Text = "$2.89";
            // 
            // TextBox1
            // 
            TextBox1.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox1.Location = new Point(371, 114);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(100, 22);
            TextBox1.TabIndex = 11;
            TextBox1.Text = "1";
            TextBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox2
            // 
            TextBox2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox2.Location = new Point(371, 146);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(100, 22);
            TextBox2.TabIndex = 12;
            TextBox2.Text = "1";
            TextBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBox3
            // 
            TextBox3.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            TextBox3.Location = new Point(371, 176);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(100, 22);
            TextBox3.TabIndex = 13;
            TextBox3.Text = "2";
            TextBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // Button2
            // 
            Button2.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button2.FlatStyle = FlatStyle.Popup;
            Button2.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, Conversions.ToByte(0));
            Button2.Location = new Point(477, 113);
            Button2.Name = "Button2";
            Button2.Size = new Size(75, 23);
            Button2.TabIndex = 14;
            Button2.Text = "remove";
            Button2.UseVisualStyleBackColor = false;
            // 
            // Button3
            // 
            Button3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button3.FlatStyle = FlatStyle.Popup;
            Button3.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, Conversions.ToByte(0));
            Button3.Location = new Point(477, 145);
            Button3.Name = "Button3";
            Button3.Size = new Size(75, 23);
            Button3.TabIndex = 15;
            Button3.Text = "remove";
            Button3.UseVisualStyleBackColor = false;
            // 
            // Button4
            // 
            Button4.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button4.FlatStyle = FlatStyle.Popup;
            Button4.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, Conversions.ToByte(0));
            Button4.Location = new Point(477, 176);
            Button4.Name = "Button4";
            Button4.Size = new Size(75, 23);
            Button4.TabIndex = 16;
            Button4.Text = "remove";
            Button4.UseVisualStyleBackColor = false;
            // 
            // Label11
            // 
            _Label11.AutoSize = true;
            _Label11.BackColor = Color.White;
            _Label11.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label11.Location = new Point(95, 207);
            _Label11.Name = "_Label11";
            _Label11.Size = new Size(81, 19);
            _Label11.TabIndex = 17;
            _Label11.Text = "Service Fee:";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.BackColor = Color.White;
            Label12.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label12.Location = new Point(268, 207);
            Label12.Name = "Label12";
            Label12.Size = new Size(45, 19);
            Label12.TabIndex = 18;
            Label12.Text = "$0.50";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.BackColor = Color.White;
            Label13.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label13.Location = new Point(95, 241);
            Label13.Name = "Label13";
            Label13.Size = new Size(43, 19);
            Label13.TabIndex = 19;
            Label13.Text = "Total";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.BackColor = Color.White;
            Label14.Font = new Font("Microsoft YaHei", 9.75f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label14.Location = new Point(268, 241);
            Label14.Name = "Label14";
            Label14.Size = new Size(53, 19);
            Label14.TabIndex = 20;
            Label14.Text = "$18.06";
            // 
            // Button5
            // 
            Button5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button5.FlatStyle = FlatStyle.Popup;
            Button5.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button5.Location = new Point(174, 272);
            Button5.Name = "Button5";
            Button5.Size = new Size(80, 23);
            Button5.TabIndex = 21;
            Button5.Text = "Place Order";
            Button5.UseVisualStyleBackColor = false;
            // 
            // Button6
            // 
            Button6.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)));
            Button6.FlatStyle = FlatStyle.Popup;
            Button6.Font = new Font("Microsoft YaHei", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Button6.Location = new Point(326, 272);
            Button6.Name = "Button6";
            Button6.Size = new Size(75, 23);
            Button6.TabIndex = 22;
            Button6.Text = "Cancel";
            Button6.UseVisualStyleBackColor = false;
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.White;
            Panel1.BorderStyle = BorderStyle.FixedSingle;
            Panel1.Location = new Point(89, 71);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(243, 195);
            Panel1.TabIndex = 23;
            // 
            // OrderSummary
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(554, 307);
            Controls.Add(Button6);
            Controls.Add(Button5);
            Controls.Add(Label14);
            Controls.Add(Label13);
            Controls.Add(Label12);
            Controls.Add(_Label11);
            Controls.Add(Button4);
            Controls.Add(Button3);
            Controls.Add(Button2);
            Controls.Add(TextBox3);
            Controls.Add(TextBox2);
            Controls.Add(TextBox1);
            Controls.Add(Label10);
            Controls.Add(Label9);
            Controls.Add(Label8);
            Controls.Add(_Label7);
            Controls.Add(_Label6);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(_Label3);
            Controls.Add(_Label2);
            Controls.Add(_Button1);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            Name = "OrderSummary";
            Text = "OrderSummary";
            Load += new EventHandler(Form1_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label1;
        private Button _Button1;

        internal Button Button1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button1 != null)
                {
                    _Button1.Click -= Button1_Click;
                }

                _Button1 = value;
                if (_Button1 != null)
                {
                    _Button1.Click += Button1_Click;
                }
            }
        }

        private Label _Label2;

        internal Label Label2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label2 != null)
                {
                    _Label2.Click -= Label2_Click;
                }

                _Label2 = value;
                if (_Label2 != null)
                {
                    _Label2.Click += Label2_Click;
                }
            }
        }

        private Label _Label3;

        internal Label Label3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label3 != null)
                {
                    _Label3.Click -= Label3_Click;
                }

                _Label3 = value;
                if (_Label3 != null)
                {
                    _Label3.Click += Label3_Click;
                }
            }
        }

        internal Label Label4;
        internal Label Label5;
        private Label _Label6;

        internal Label Label6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label6 != null)
                {
                    _Label6.Click -= Label6_Click;
                }

                _Label6 = value;
                if (_Label6 != null)
                {
                    _Label6.Click += Label6_Click;
                }
            }
        }

        private Label _Label7;

        internal Label Label7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label7 != null)
                {
                    _Label7.Click -= Label7_Click;
                }

                _Label7 = value;
                if (_Label7 != null)
                {
                    _Label7.Click += Label7_Click;
                }
            }
        }

        internal Label Label8;
        internal Label Label9;
        internal Label Label10;
        internal TextBox TextBox1;
        internal TextBox TextBox2;
        internal TextBox TextBox3;
        internal Button Button2;
        internal Button Button3;
        internal Button Button4;
        private Label _Label11;

        internal Label Label11
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label11;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label11 != null)
                {
                    _Label11.Click -= Label11_Click;
                }

                _Label11 = value;
                if (_Label11 != null)
                {
                    _Label11.Click += Label11_Click;
                }
            }
        }

        internal Label Label12;
        internal Label Label13;
        internal Label Label14;
        internal Button Button5;
        internal Button Button6;
        internal Panel Panel1;
    }
}