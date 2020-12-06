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
            this.Label1 = new System.Windows.Forms.Label();
            this._Button1 = new System.Windows.Forms.Button();
            this._Label2 = new System.Windows.Forms.Label();
            this.Item1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Item2 = new System.Windows.Forms.Label();
            this.Item3 = new System.Windows.Forms.Label();
            this.ItemCost1 = new System.Windows.Forms.Label();
            this.ItemCost2 = new System.Windows.Forms.Label();
            this.ItemCost3 = new System.Windows.Forms.Label();
            this.ItemQ1 = new System.Windows.Forms.TextBox();
            this.ItemQ2 = new System.Windows.Forms.TextBox();
            this.ItemQ3 = new System.Windows.Forms.TextBox();
            this.ItemRemove1 = new System.Windows.Forms.Button();
            this.ItemRemove2 = new System.Windows.Forms.Button();
            this.ItemRemove3 = new System.Windows.Forms.Button();
            this._Label11 = new System.Windows.Forms.Label();
            this.ServiceFee = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ItemCost10 = new System.Windows.Forms.Label();
            this.ItemCost9 = new System.Windows.Forms.Label();
            this.ItemCost8 = new System.Windows.Forms.Label();
            this.ItemCost7 = new System.Windows.Forms.Label();
            this.ItemCost6 = new System.Windows.Forms.Label();
            this.ItemCost5 = new System.Windows.Forms.Label();
            this.ItemCost4 = new System.Windows.Forms.Label();
            this.Item10 = new System.Windows.Forms.Label();
            this.Item9 = new System.Windows.Forms.Label();
            this.Item8 = new System.Windows.Forms.Label();
            this.Item7 = new System.Windows.Forms.Label();
            this.Item6 = new System.Windows.Forms.Label();
            this.Item5 = new System.Windows.Forms.Label();
            this.Item4 = new System.Windows.Forms.Label();
            this.ItemRemove4 = new System.Windows.Forms.Button();
            this.ItemRemove5 = new System.Windows.Forms.Button();
            this.ItemRemove6 = new System.Windows.Forms.Button();
            this.ItemRemove7 = new System.Windows.Forms.Button();
            this.ItemRemove8 = new System.Windows.Forms.Button();
            this.ItemRemove9 = new System.Windows.Forms.Button();
            this.ItemRemove10 = new System.Windows.Forms.Button();
            this.ItemQ4 = new System.Windows.Forms.TextBox();
            this.ItemQ5 = new System.Windows.Forms.TextBox();
            this.ItemQ6 = new System.Windows.Forms.TextBox();
            this.ItemQ7 = new System.Windows.Forms.TextBox();
            this.ItemQ8 = new System.Windows.Forms.TextBox();
            this.ItemQ9 = new System.Windows.Forms.TextBox();
            this.ItemQ10 = new System.Windows.Forms.TextBox();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(206, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(146, 36);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Summary";
            // 
            // _Button1
            // 
            this._Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._Button1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this._Button1.Location = new System.Drawing.Point(57, 40);
            this._Button1.Name = "_Button1";
            this._Button1.Size = new System.Drawing.Size(75, 25);
            this._Button1.TabIndex = 1;
            this._Button1.Text = "< Back";
            this._Button1.UseVisualStyleBackColor = false;
            // 
            // _Label2
            // 
            this._Label2.AutoSize = true;
            this._Label2.BackColor = System.Drawing.Color.White;
            this._Label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label2.Location = new System.Drawing.Point(94, 78);
            this._Label2.Name = "_Label2";
            this._Label2.Size = new System.Drawing.Size(63, 25);
            this._Label2.TabIndex = 2;
            this._Label2.Text = "Items";
            // 
            // Item1
            // 
            this.Item1.AutoSize = true;
            this.Item1.BackColor = System.Drawing.Color.White;
            this.Item1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item1.Location = new System.Drawing.Point(5, 42);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(86, 19);
            this.Item1.TabIndex = 3;
            this.Item1.Text = "Place Holder";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(170, 6);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(57, 25);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Price";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(367, 78);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(78, 24);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Quantity";
            // 
            // Item2
            // 
            this.Item2.AutoSize = true;
            this.Item2.BackColor = System.Drawing.Color.White;
            this.Item2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item2.Location = new System.Drawing.Point(3, 69);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(86, 19);
            this.Item2.TabIndex = 6;
            this.Item2.Text = "Place Holder";
            this.Item2.Visible = false;
            // 
            // Item3
            // 
            this.Item3.AutoSize = true;
            this.Item3.BackColor = System.Drawing.Color.White;
            this.Item3.Enabled = false;
            this.Item3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item3.Location = new System.Drawing.Point(5, 98);
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(86, 19);
            this.Item3.TabIndex = 7;
            this.Item3.Text = "Place Holder";
            this.Item3.Visible = false;
            // 
            // ItemCost1
            // 
            this.ItemCost1.AutoSize = true;
            this.ItemCost1.BackColor = System.Drawing.Color.White;
            this.ItemCost1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCost1.Location = new System.Drawing.Point(178, 42);
            this.ItemCost1.Name = "ItemCost1";
            this.ItemCost1.Size = new System.Drawing.Size(45, 19);
            this.ItemCost1.TabIndex = 8;
            this.ItemCost1.Text = "$0.00";
            // 
            // ItemCost2
            // 
            this.ItemCost2.AutoSize = true;
            this.ItemCost2.BackColor = System.Drawing.Color.White;
            this.ItemCost2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCost2.Location = new System.Drawing.Point(178, 69);
            this.ItemCost2.Name = "ItemCost2";
            this.ItemCost2.Size = new System.Drawing.Size(45, 19);
            this.ItemCost2.TabIndex = 9;
            this.ItemCost2.Text = "$0.00";
            this.ItemCost2.Visible = false;
            // 
            // ItemCost3
            // 
            this.ItemCost3.AutoSize = true;
            this.ItemCost3.BackColor = System.Drawing.Color.White;
            this.ItemCost3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCost3.Location = new System.Drawing.Point(178, 98);
            this.ItemCost3.Name = "ItemCost3";
            this.ItemCost3.Size = new System.Drawing.Size(45, 19);
            this.ItemCost3.TabIndex = 10;
            this.ItemCost3.Text = "$0.00";
            this.ItemCost3.Visible = false;
            // 
            // ItemQ1
            // 
            this.ItemQ1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ1.Location = new System.Drawing.Point(371, 114);
            this.ItemQ1.Name = "ItemQ1";
            this.ItemQ1.Size = new System.Drawing.Size(100, 22);
            this.ItemQ1.TabIndex = 11;
            this.ItemQ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ItemQ2
            // 
            this.ItemQ2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ2.Location = new System.Drawing.Point(371, 142);
            this.ItemQ2.Name = "ItemQ2";
            this.ItemQ2.Size = new System.Drawing.Size(100, 22);
            this.ItemQ2.TabIndex = 12;
            this.ItemQ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemQ2.Visible = false;
            // 
            // ItemQ3
            // 
            this.ItemQ3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ3.Location = new System.Drawing.Point(371, 170);
            this.ItemQ3.Name = "ItemQ3";
            this.ItemQ3.Size = new System.Drawing.Size(100, 22);
            this.ItemQ3.TabIndex = 13;
            this.ItemQ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemQ3.Visible = false;
            // 
            // ItemRemove1
            // 
            this.ItemRemove1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemRemove1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItemRemove1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemRemove1.Location = new System.Drawing.Point(477, 112);
            this.ItemRemove1.Name = "ItemRemove1";
            this.ItemRemove1.Size = new System.Drawing.Size(75, 23);
            this.ItemRemove1.TabIndex = 14;
            this.ItemRemove1.Text = "remove";
            this.ItemRemove1.UseVisualStyleBackColor = false;
            this.ItemRemove1.Click += new System.EventHandler(this.ItemRemove1_Click);
            // 
            // ItemRemove2
            // 
            this.ItemRemove2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemRemove2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItemRemove2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemRemove2.Location = new System.Drawing.Point(477, 141);
            this.ItemRemove2.Name = "ItemRemove2";
            this.ItemRemove2.Size = new System.Drawing.Size(75, 23);
            this.ItemRemove2.TabIndex = 15;
            this.ItemRemove2.Text = "remove";
            this.ItemRemove2.UseVisualStyleBackColor = false;
            this.ItemRemove2.Visible = false;
            this.ItemRemove2.Click += new System.EventHandler(this.ItemRemove2_Click);
            // 
            // ItemRemove3
            // 
            this.ItemRemove3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemRemove3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItemRemove3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemRemove3.Location = new System.Drawing.Point(477, 170);
            this.ItemRemove3.Name = "ItemRemove3";
            this.ItemRemove3.Size = new System.Drawing.Size(75, 23);
            this.ItemRemove3.TabIndex = 16;
            this.ItemRemove3.Text = "remove";
            this.ItemRemove3.UseVisualStyleBackColor = false;
            this.ItemRemove3.Visible = false;
            this.ItemRemove3.Click += new System.EventHandler(this.ItemRemove3_Click);
            // 
            // _Label11
            // 
            this._Label11.AutoSize = true;
            this._Label11.BackColor = System.Drawing.Color.White;
            this._Label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label11.Location = new System.Drawing.Point(10, 324);
            this._Label11.Name = "_Label11";
            this._Label11.Size = new System.Drawing.Size(81, 19);
            this._Label11.TabIndex = 17;
            this._Label11.Text = "Service Fee:";
            // 
            // ServiceFee
            // 
            this.ServiceFee.AutoSize = true;
            this.ServiceFee.BackColor = System.Drawing.Color.White;
            this.ServiceFee.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceFee.Location = new System.Drawing.Point(178, 324);
            this.ServiceFee.Name = "ServiceFee";
            this.ServiceFee.Size = new System.Drawing.Size(45, 19);
            this.ServiceFee.TabIndex = 18;
            this.ServiceFee.Text = "$0.50";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.White;
            this.Label13.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(46, 351);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(43, 19);
            this.Label13.TabIndex = 19;
            this.Label13.Text = "Total";
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.BackColor = System.Drawing.Color.White;
            this.TotalCost.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCost.Location = new System.Drawing.Point(178, 351);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(45, 19);
            this.TotalCost.TabIndex = 20;
            this.TotalCost.Text = "$0.00";
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.Location = new System.Drawing.Point(153, 478);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(80, 23);
            this.Button5.TabIndex = 21;
            this.Button5.Text = "Place Order";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.Location = new System.Drawing.Point(370, 478);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(75, 23);
            this.Button6.TabIndex = 22;
            this.Button6.Text = "Cancel";
            this.Button6.UseVisualStyleBackColor = false;
            // 
            // Panel1
            // 
            this.Panel1.AutoSize = true;
            this.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.ItemCost10);
            this.Panel1.Controls.Add(this.ItemCost9);
            this.Panel1.Controls.Add(this.ItemCost8);
            this.Panel1.Controls.Add(this.ItemCost7);
            this.Panel1.Controls.Add(this.ItemCost6);
            this.Panel1.Controls.Add(this.ItemCost5);
            this.Panel1.Controls.Add(this.ItemCost4);
            this.Panel1.Controls.Add(this.Item10);
            this.Panel1.Controls.Add(this.Item9);
            this.Panel1.Controls.Add(this.Item8);
            this.Panel1.Controls.Add(this.Item7);
            this.Panel1.Controls.Add(this.Item6);
            this.Panel1.Controls.Add(this.Item5);
            this.Panel1.Controls.Add(this.Item4);
            this.Panel1.Controls.Add(this._Label11);
            this.Panel1.Controls.Add(this.Label13);
            this.Panel1.Controls.Add(this.TotalCost);
            this.Panel1.Controls.Add(this.ServiceFee);
            this.Panel1.Controls.Add(this.Item2);
            this.Panel1.Controls.Add(this.Item1);
            this.Panel1.Controls.Add(this.ItemCost1);
            this.Panel1.Controls.Add(this.Item3);
            this.Panel1.Controls.Add(this.ItemCost2);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.ItemCost3);
            this.Panel1.Location = new System.Drawing.Point(89, 71);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(232, 372);
            this.Panel1.TabIndex = 23;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // ItemCost10
            // 
            this.ItemCost10.AutoSize = true;
            this.ItemCost10.BackColor = System.Drawing.Color.White;
            this.ItemCost10.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCost10.Location = new System.Drawing.Point(178, 294);
            this.ItemCost10.Name = "ItemCost10";
            this.ItemCost10.Size = new System.Drawing.Size(45, 19);
            this.ItemCost10.TabIndex = 34;
            this.ItemCost10.Text = "$0.00";
            this.ItemCost10.Visible = false;
            // 
            // ItemCost9
            // 
            this.ItemCost9.AutoSize = true;
            this.ItemCost9.BackColor = System.Drawing.Color.White;
            this.ItemCost9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCost9.Location = new System.Drawing.Point(178, 266);
            this.ItemCost9.Name = "ItemCost9";
            this.ItemCost9.Size = new System.Drawing.Size(45, 19);
            this.ItemCost9.TabIndex = 33;
            this.ItemCost9.Text = "$0.00";
            this.ItemCost9.Visible = false;
            // 
            // ItemCost8
            // 
            this.ItemCost8.AutoSize = true;
            this.ItemCost8.BackColor = System.Drawing.Color.White;
            this.ItemCost8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCost8.Location = new System.Drawing.Point(178, 238);
            this.ItemCost8.Name = "ItemCost8";
            this.ItemCost8.Size = new System.Drawing.Size(45, 19);
            this.ItemCost8.TabIndex = 32;
            this.ItemCost8.Text = "$0.00";
            this.ItemCost8.Visible = false;
            // 
            // ItemCost7
            // 
            this.ItemCost7.AutoSize = true;
            this.ItemCost7.BackColor = System.Drawing.Color.White;
            this.ItemCost7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCost7.Location = new System.Drawing.Point(178, 210);
            this.ItemCost7.Name = "ItemCost7";
            this.ItemCost7.Size = new System.Drawing.Size(45, 19);
            this.ItemCost7.TabIndex = 31;
            this.ItemCost7.Text = "$0.00";
            this.ItemCost7.Visible = false;
            // 
            // ItemCost6
            // 
            this.ItemCost6.AutoSize = true;
            this.ItemCost6.BackColor = System.Drawing.Color.White;
            this.ItemCost6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCost6.Location = new System.Drawing.Point(178, 182);
            this.ItemCost6.Name = "ItemCost6";
            this.ItemCost6.Size = new System.Drawing.Size(45, 19);
            this.ItemCost6.TabIndex = 30;
            this.ItemCost6.Text = "$0.00";
            this.ItemCost6.Visible = false;
            // 
            // ItemCost5
            // 
            this.ItemCost5.AutoSize = true;
            this.ItemCost5.BackColor = System.Drawing.Color.White;
            this.ItemCost5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCost5.Location = new System.Drawing.Point(178, 154);
            this.ItemCost5.Name = "ItemCost5";
            this.ItemCost5.Size = new System.Drawing.Size(45, 19);
            this.ItemCost5.TabIndex = 29;
            this.ItemCost5.Text = "$0.00";
            this.ItemCost5.Visible = false;
            // 
            // ItemCost4
            // 
            this.ItemCost4.AutoSize = true;
            this.ItemCost4.BackColor = System.Drawing.Color.White;
            this.ItemCost4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCost4.Location = new System.Drawing.Point(178, 126);
            this.ItemCost4.Name = "ItemCost4";
            this.ItemCost4.Size = new System.Drawing.Size(45, 19);
            this.ItemCost4.TabIndex = 28;
            this.ItemCost4.Text = "$0.00";
            this.ItemCost4.Visible = false;
            // 
            // Item10
            // 
            this.Item10.AutoSize = true;
            this.Item10.BackColor = System.Drawing.Color.White;
            this.Item10.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item10.Location = new System.Drawing.Point(5, 294);
            this.Item10.Name = "Item10";
            this.Item10.Size = new System.Drawing.Size(86, 19);
            this.Item10.TabIndex = 27;
            this.Item10.Text = "Place Holder";
            this.Item10.Visible = false;
            // 
            // Item9
            // 
            this.Item9.AutoSize = true;
            this.Item9.BackColor = System.Drawing.Color.White;
            this.Item9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item9.Location = new System.Drawing.Point(5, 266);
            this.Item9.Name = "Item9";
            this.Item9.Size = new System.Drawing.Size(86, 19);
            this.Item9.TabIndex = 26;
            this.Item9.Text = "Place Holder";
            this.Item9.Visible = false;
            // 
            // Item8
            // 
            this.Item8.AutoSize = true;
            this.Item8.BackColor = System.Drawing.Color.White;
            this.Item8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item8.Location = new System.Drawing.Point(5, 238);
            this.Item8.Name = "Item8";
            this.Item8.Size = new System.Drawing.Size(86, 19);
            this.Item8.TabIndex = 25;
            this.Item8.Text = "Place Holder";
            this.Item8.Visible = false;
            // 
            // Item7
            // 
            this.Item7.AutoSize = true;
            this.Item7.BackColor = System.Drawing.Color.White;
            this.Item7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item7.Location = new System.Drawing.Point(5, 210);
            this.Item7.Name = "Item7";
            this.Item7.Size = new System.Drawing.Size(86, 19);
            this.Item7.TabIndex = 24;
            this.Item7.Text = "Place Holder";
            this.Item7.Visible = false;
            // 
            // Item6
            // 
            this.Item6.AutoSize = true;
            this.Item6.BackColor = System.Drawing.Color.White;
            this.Item6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item6.Location = new System.Drawing.Point(3, 182);
            this.Item6.Name = "Item6";
            this.Item6.Size = new System.Drawing.Size(86, 19);
            this.Item6.TabIndex = 23;
            this.Item6.Text = "Place Holder";
            this.Item6.Visible = false;
            // 
            // Item5
            // 
            this.Item5.AutoSize = true;
            this.Item5.BackColor = System.Drawing.Color.White;
            this.Item5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item5.Location = new System.Drawing.Point(5, 154);
            this.Item5.Name = "Item5";
            this.Item5.Size = new System.Drawing.Size(86, 19);
            this.Item5.TabIndex = 22;
            this.Item5.Text = "Place Holder";
            this.Item5.Visible = false;
            // 
            // Item4
            // 
            this.Item4.AutoSize = true;
            this.Item4.BackColor = System.Drawing.Color.White;
            this.Item4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item4.Location = new System.Drawing.Point(5, 126);
            this.Item4.Name = "Item4";
            this.Item4.Size = new System.Drawing.Size(86, 19);
            this.Item4.TabIndex = 21;
            this.Item4.Text = "Place Holder";
            this.Item4.Visible = false;
            // 
            // ItemRemove4
            // 
            this.ItemRemove4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemRemove4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItemRemove4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemRemove4.Location = new System.Drawing.Point(477, 198);
            this.ItemRemove4.Name = "ItemRemove4";
            this.ItemRemove4.Size = new System.Drawing.Size(75, 23);
            this.ItemRemove4.TabIndex = 31;
            this.ItemRemove4.Text = "remove";
            this.ItemRemove4.UseVisualStyleBackColor = false;
            this.ItemRemove4.Visible = false;
            this.ItemRemove4.Click += new System.EventHandler(this.ItemRemove4_Click);
            // 
            // ItemRemove5
            // 
            this.ItemRemove5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemRemove5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItemRemove5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemRemove5.Location = new System.Drawing.Point(477, 226);
            this.ItemRemove5.Name = "ItemRemove5";
            this.ItemRemove5.Size = new System.Drawing.Size(75, 23);
            this.ItemRemove5.TabIndex = 32;
            this.ItemRemove5.Text = "remove";
            this.ItemRemove5.UseVisualStyleBackColor = false;
            this.ItemRemove5.Visible = false;
            this.ItemRemove5.Click += new System.EventHandler(this.ItemRemove5_Click);
            // 
            // ItemRemove6
            // 
            this.ItemRemove6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemRemove6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItemRemove6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemRemove6.Location = new System.Drawing.Point(477, 254);
            this.ItemRemove6.Name = "ItemRemove6";
            this.ItemRemove6.Size = new System.Drawing.Size(75, 23);
            this.ItemRemove6.TabIndex = 33;
            this.ItemRemove6.Text = "remove";
            this.ItemRemove6.UseVisualStyleBackColor = false;
            this.ItemRemove6.Visible = false;
            this.ItemRemove6.Click += new System.EventHandler(this.ItemRemove6_Click);
            // 
            // ItemRemove7
            // 
            this.ItemRemove7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemRemove7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItemRemove7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemRemove7.Location = new System.Drawing.Point(477, 282);
            this.ItemRemove7.Name = "ItemRemove7";
            this.ItemRemove7.Size = new System.Drawing.Size(75, 23);
            this.ItemRemove7.TabIndex = 34;
            this.ItemRemove7.Text = "remove";
            this.ItemRemove7.UseVisualStyleBackColor = false;
            this.ItemRemove7.Visible = false;
            this.ItemRemove7.Click += new System.EventHandler(this.ItemRemove7_Click);
            // 
            // ItemRemove8
            // 
            this.ItemRemove8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemRemove8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItemRemove8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemRemove8.Location = new System.Drawing.Point(477, 310);
            this.ItemRemove8.Name = "ItemRemove8";
            this.ItemRemove8.Size = new System.Drawing.Size(75, 23);
            this.ItemRemove8.TabIndex = 35;
            this.ItemRemove8.Text = "remove";
            this.ItemRemove8.UseVisualStyleBackColor = false;
            this.ItemRemove8.Visible = false;
            this.ItemRemove8.Click += new System.EventHandler(this.ItemRemove8_Click);
            // 
            // ItemRemove9
            // 
            this.ItemRemove9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemRemove9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItemRemove9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemRemove9.Location = new System.Drawing.Point(477, 338);
            this.ItemRemove9.Name = "ItemRemove9";
            this.ItemRemove9.Size = new System.Drawing.Size(75, 23);
            this.ItemRemove9.TabIndex = 36;
            this.ItemRemove9.Text = "remove";
            this.ItemRemove9.UseVisualStyleBackColor = false;
            this.ItemRemove9.Visible = false;
            this.ItemRemove9.Click += new System.EventHandler(this.ItemRemove9_Click);
            // 
            // ItemRemove10
            // 
            this.ItemRemove10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemRemove10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ItemRemove10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemRemove10.Location = new System.Drawing.Point(477, 366);
            this.ItemRemove10.Name = "ItemRemove10";
            this.ItemRemove10.Size = new System.Drawing.Size(75, 23);
            this.ItemRemove10.TabIndex = 37;
            this.ItemRemove10.Text = "remove";
            this.ItemRemove10.UseVisualStyleBackColor = false;
            this.ItemRemove10.Visible = false;
            this.ItemRemove10.Click += new System.EventHandler(this.ItemRemove10_Click);
            // 
            // ItemQ4
            // 
            this.ItemQ4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ4.Location = new System.Drawing.Point(371, 198);
            this.ItemQ4.Name = "ItemQ4";
            this.ItemQ4.Size = new System.Drawing.Size(100, 22);
            this.ItemQ4.TabIndex = 38;
            this.ItemQ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemQ4.Visible = false;
            // 
            // ItemQ5
            // 
            this.ItemQ5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ5.Location = new System.Drawing.Point(371, 226);
            this.ItemQ5.Name = "ItemQ5";
            this.ItemQ5.Size = new System.Drawing.Size(100, 22);
            this.ItemQ5.TabIndex = 39;
            this.ItemQ5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemQ5.Visible = false;
            // 
            // ItemQ6
            // 
            this.ItemQ6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ6.Location = new System.Drawing.Point(371, 254);
            this.ItemQ6.Name = "ItemQ6";
            this.ItemQ6.Size = new System.Drawing.Size(100, 22);
            this.ItemQ6.TabIndex = 40;
            this.ItemQ6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemQ6.Visible = false;
            // 
            // ItemQ7
            // 
            this.ItemQ7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ7.Location = new System.Drawing.Point(371, 282);
            this.ItemQ7.Name = "ItemQ7";
            this.ItemQ7.Size = new System.Drawing.Size(100, 22);
            this.ItemQ7.TabIndex = 41;
            this.ItemQ7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemQ7.Visible = false;
            // 
            // ItemQ8
            // 
            this.ItemQ8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ8.Location = new System.Drawing.Point(371, 310);
            this.ItemQ8.Name = "ItemQ8";
            this.ItemQ8.Size = new System.Drawing.Size(100, 22);
            this.ItemQ8.TabIndex = 42;
            this.ItemQ8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemQ8.Visible = false;
            // 
            // ItemQ9
            // 
            this.ItemQ9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ9.Location = new System.Drawing.Point(371, 338);
            this.ItemQ9.Name = "ItemQ9";
            this.ItemQ9.Size = new System.Drawing.Size(100, 22);
            this.ItemQ9.TabIndex = 43;
            this.ItemQ9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemQ9.Visible = false;
            // 
            // ItemQ10
            // 
            this.ItemQ10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ10.Location = new System.Drawing.Point(371, 366);
            this.ItemQ10.Name = "ItemQ10";
            this.ItemQ10.Size = new System.Drawing.Size(100, 22);
            this.ItemQ10.TabIndex = 44;
            this.ItemQ10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemQ10.Visible = false;
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(617, 527);
            this.Controls.Add(this.ItemQ10);
            this.Controls.Add(this.ItemQ9);
            this.Controls.Add(this.ItemQ8);
            this.Controls.Add(this.ItemQ7);
            this.Controls.Add(this.ItemQ6);
            this.Controls.Add(this.ItemQ5);
            this.Controls.Add(this.ItemQ4);
            this.Controls.Add(this.ItemRemove10);
            this.Controls.Add(this.ItemRemove9);
            this.Controls.Add(this.ItemRemove8);
            this.Controls.Add(this.ItemRemove7);
            this.Controls.Add(this.ItemRemove6);
            this.Controls.Add(this.ItemRemove5);
            this.Controls.Add(this.ItemRemove4);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.ItemRemove3);
            this.Controls.Add(this.ItemRemove2);
            this.Controls.Add(this.ItemRemove1);
            this.Controls.Add(this.ItemQ3);
            this.Controls.Add(this.ItemQ2);
            this.Controls.Add(this.ItemQ1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this._Label2);
            this.Controls.Add(this._Button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Name = "OrderSummary";
            this.Text = "OrderSummary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Label Label1;
        private Button _Button1;

        private Label _Label2;
        private Label Item1;
        internal Label Label4;
        internal Label Label5;
        private Label Item2;
        private Label Item3;

        internal Label ItemCost1;
        internal Label ItemCost2;
        internal Label ItemCost3;
        internal TextBox ItemQ1;
        internal TextBox ItemQ2;
        internal TextBox ItemQ3;
        internal Button ItemRemove1;
        internal Button ItemRemove2;
        internal Button ItemRemove3;
        private Label _Label11;

        internal Label ServiceFee;
        internal Label Label13;
        internal Label TotalCost;
        internal Button Button5;
        internal Button Button6;
        internal Panel Panel1;
        internal Button ItemRemove4;
        internal Button ItemRemove5;
        internal Button ItemRemove6;
        internal Button ItemRemove7;
        internal Button ItemRemove8;
        internal Button ItemRemove9;
        internal Button ItemRemove10;
        internal TextBox ItemQ4;
        internal TextBox ItemQ5;
        internal TextBox ItemQ6;
        internal TextBox ItemQ7;
        internal TextBox ItemQ8;
        internal TextBox ItemQ9;
        internal TextBox ItemQ10;
        private Label Item10;
        private Label Item9;
        private Label Item8;
        private Label Item7;
        private Label Item6;
        private Label Item5;
        private Label Item4;
        internal Label ItemCost10;
        internal Label ItemCost9;
        internal Label ItemCost8;
        internal Label ItemCost7;
        internal Label ItemCost6;
        internal Label ItemCost5;
        internal Label ItemCost4;
    }
}