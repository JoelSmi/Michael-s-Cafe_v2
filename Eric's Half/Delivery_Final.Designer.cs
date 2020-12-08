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
            this.Label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.PhoneNumberText = new System.Windows.Forms.TextBox();
            this.CustomerNameText = new System.Windows.Forms.TextBox();
            this.DeliverNameText = new System.Windows.Forms.TextBox();
            this.DeliverAddrText = new System.Windows.Forms.TextBox();
            this.CustomerAddressText = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.OrderedItemsText = new System.Windows.Forms.Label();
            this.TotalAmountText = new System.Windows.Forms.Label();
            this.Item1 = new System.Windows.Forms.Label();
            this.Item2 = new System.Windows.Forms.Label();
            this.Item3 = new System.Windows.Forms.Label();
            this.Item4 = new System.Windows.Forms.Label();
            this.Item5 = new System.Windows.Forms.Label();
            this.Item6 = new System.Windows.Forms.Label();
            this.Item7 = new System.Windows.Forms.Label();
            this.Item8 = new System.Windows.Forms.Label();
            this.Item9 = new System.Windows.Forms.Label();
            this.Item10 = new System.Windows.Forms.Label();
            this.ItemQ1 = new System.Windows.Forms.Label();
            this.ItemQ2 = new System.Windows.Forms.Label();
            this.ItemQ3 = new System.Windows.Forms.Label();
            this.ItemQ4 = new System.Windows.Forms.Label();
            this.ItemQ5 = new System.Windows.Forms.Label();
            this.ItemQ6 = new System.Windows.Forms.Label();
            this.ItemQ7 = new System.Windows.Forms.Label();
            this.ItemQ8 = new System.Windows.Forms.Label();
            this.ItemQ9 = new System.Windows.Forms.Label();
            this.ItemQ10 = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(213, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(127, 36);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Delivery";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(34, 28);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 25);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberText.Location = new System.Drawing.Point(34, 101);
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(100, 22);
            this.PhoneNumberText.TabIndex = 13;
            this.PhoneNumberText.Text = "Phone Number";
            this.PhoneNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomerNameText
            // 
            this.CustomerNameText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameText.Location = new System.Drawing.Point(34, 73);
            this.CustomerNameText.Name = "CustomerNameText";
            this.CustomerNameText.ReadOnly = true;
            this.CustomerNameText.Size = new System.Drawing.Size(100, 22);
            this.CustomerNameText.TabIndex = 12;
            this.CustomerNameText.Text = "Customer Name";
            this.CustomerNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeliverNameText
            // 
            this.DeliverNameText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliverNameText.Location = new System.Drawing.Point(34, 151);
            this.DeliverNameText.Name = "DeliverNameText";
            this.DeliverNameText.ReadOnly = true;
            this.DeliverNameText.Size = new System.Drawing.Size(100, 22);
            this.DeliverNameText.TabIndex = 40;
            this.DeliverNameText.Text = "Deliverer Name";
            this.DeliverNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeliverAddrText
            // 
            this.DeliverAddrText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliverAddrText.Location = new System.Drawing.Point(34, 179);
            this.DeliverAddrText.Name = "DeliverAddrText";
            this.DeliverAddrText.Size = new System.Drawing.Size(100, 22);
            this.DeliverAddrText.TabIndex = 41;
            this.DeliverAddrText.Text = "Delivery Address";
            this.DeliverAddrText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CustomerAddressText
            // 
            this.CustomerAddressText.AutoSize = true;
            this.CustomerAddressText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddressText.ForeColor = System.Drawing.Color.White;
            this.CustomerAddressText.Location = new System.Drawing.Point(12, 204);
            this.CustomerAddressText.Name = "CustomerAddressText";
            this.CustomerAddressText.Size = new System.Drawing.Size(126, 16);
            this.CustomerAddressText.TabIndex = 42;
            this.CustomerAddressText.Text = "*Show address chosen";
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DoneButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(431, 269);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 43;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // OrderedItemsText
            // 
            this.OrderedItemsText.AutoSize = true;
            this.OrderedItemsText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderedItemsText.ForeColor = System.Drawing.Color.White;
            this.OrderedItemsText.Location = new System.Drawing.Point(216, 73);
            this.OrderedItemsText.Name = "OrderedItemsText";
            this.OrderedItemsText.Size = new System.Drawing.Size(85, 16);
            this.OrderedItemsText.TabIndex = 44;
            this.OrderedItemsText.Text = "Ordered Items:";
            // 
            // TotalAmountText
            // 
            this.TotalAmountText.AutoSize = true;
            this.TotalAmountText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountText.ForeColor = System.Drawing.Color.White;
            this.TotalAmountText.Location = new System.Drawing.Point(215, 269);
            this.TotalAmountText.Name = "TotalAmountText";
            this.TotalAmountText.Size = new System.Drawing.Size(47, 19);
            this.TotalAmountText.TabIndex = 45;
            this.TotalAmountText.Text = "Total:";
            // 
            // Item1
            // 
            this.Item1.AutoSize = true;
            this.Item1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item1.ForeColor = System.Drawing.Color.White;
            this.Item1.Location = new System.Drawing.Point(216, 101);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(37, 16);
            this.Item1.TabIndex = 46;
            this.Item1.Text = "Item1";
            // 
            // Item2
            // 
            this.Item2.AutoSize = true;
            this.Item2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item2.ForeColor = System.Drawing.Color.White;
            this.Item2.Location = new System.Drawing.Point(216, 117);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(37, 16);
            this.Item2.TabIndex = 47;
            this.Item2.Text = "Item1";
            this.Item2.Visible = false;
            // 
            // Item3
            // 
            this.Item3.AutoSize = true;
            this.Item3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item3.ForeColor = System.Drawing.Color.White;
            this.Item3.Location = new System.Drawing.Point(216, 133);
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(37, 16);
            this.Item3.TabIndex = 48;
            this.Item3.Text = "Item1";
            this.Item3.Visible = false;
            // 
            // Item4
            // 
            this.Item4.AutoSize = true;
            this.Item4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item4.ForeColor = System.Drawing.Color.White;
            this.Item4.Location = new System.Drawing.Point(216, 149);
            this.Item4.Name = "Item4";
            this.Item4.Size = new System.Drawing.Size(37, 16);
            this.Item4.TabIndex = 49;
            this.Item4.Text = "Item1";
            this.Item4.Visible = false;
            // 
            // Item5
            // 
            this.Item5.AutoSize = true;
            this.Item5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item5.ForeColor = System.Drawing.Color.White;
            this.Item5.Location = new System.Drawing.Point(216, 167);
            this.Item5.Name = "Item5";
            this.Item5.Size = new System.Drawing.Size(37, 16);
            this.Item5.TabIndex = 50;
            this.Item5.Text = "Item1";
            this.Item5.Visible = false;
            // 
            // Item6
            // 
            this.Item6.AutoSize = true;
            this.Item6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item6.ForeColor = System.Drawing.Color.White;
            this.Item6.Location = new System.Drawing.Point(216, 183);
            this.Item6.Name = "Item6";
            this.Item6.Size = new System.Drawing.Size(37, 16);
            this.Item6.TabIndex = 51;
            this.Item6.Text = "Item1";
            this.Item6.Visible = false;
            // 
            // Item7
            // 
            this.Item7.AutoSize = true;
            this.Item7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item7.ForeColor = System.Drawing.Color.White;
            this.Item7.Location = new System.Drawing.Point(216, 199);
            this.Item7.Name = "Item7";
            this.Item7.Size = new System.Drawing.Size(37, 16);
            this.Item7.TabIndex = 52;
            this.Item7.Text = "Item1";
            this.Item7.Visible = false;
            // 
            // Item8
            // 
            this.Item8.AutoSize = true;
            this.Item8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item8.ForeColor = System.Drawing.Color.White;
            this.Item8.Location = new System.Drawing.Point(216, 215);
            this.Item8.Name = "Item8";
            this.Item8.Size = new System.Drawing.Size(37, 16);
            this.Item8.TabIndex = 53;
            this.Item8.Text = "Item1";
            this.Item8.Visible = false;
            // 
            // Item9
            // 
            this.Item9.AutoSize = true;
            this.Item9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item9.ForeColor = System.Drawing.Color.White;
            this.Item9.Location = new System.Drawing.Point(216, 231);
            this.Item9.Name = "Item9";
            this.Item9.Size = new System.Drawing.Size(37, 16);
            this.Item9.TabIndex = 54;
            this.Item9.Text = "Item1";
            this.Item9.Visible = false;
            // 
            // Item10
            // 
            this.Item10.AutoSize = true;
            this.Item10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item10.ForeColor = System.Drawing.Color.White;
            this.Item10.Location = new System.Drawing.Point(216, 249);
            this.Item10.Name = "Item10";
            this.Item10.Size = new System.Drawing.Size(37, 16);
            this.Item10.TabIndex = 55;
            this.Item10.Text = "Item1";
            this.Item10.Visible = false;
            // 
            // ItemQ1
            // 
            this.ItemQ1.AutoSize = true;
            this.ItemQ1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ1.ForeColor = System.Drawing.Color.White;
            this.ItemQ1.Location = new System.Drawing.Point(394, 101);
            this.ItemQ1.Name = "ItemQ1";
            this.ItemQ1.Size = new System.Drawing.Size(14, 16);
            this.ItemQ1.TabIndex = 56;
            this.ItemQ1.Text = "0";
            // 
            // ItemQ2
            // 
            this.ItemQ2.AutoSize = true;
            this.ItemQ2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ2.ForeColor = System.Drawing.Color.White;
            this.ItemQ2.Location = new System.Drawing.Point(394, 117);
            this.ItemQ2.Name = "ItemQ2";
            this.ItemQ2.Size = new System.Drawing.Size(14, 16);
            this.ItemQ2.TabIndex = 57;
            this.ItemQ2.Text = "0";
            this.ItemQ2.Visible = false;
            // 
            // ItemQ3
            // 
            this.ItemQ3.AutoSize = true;
            this.ItemQ3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ3.ForeColor = System.Drawing.Color.White;
            this.ItemQ3.Location = new System.Drawing.Point(394, 133);
            this.ItemQ3.Name = "ItemQ3";
            this.ItemQ3.Size = new System.Drawing.Size(14, 16);
            this.ItemQ3.TabIndex = 58;
            this.ItemQ3.Text = "0";
            this.ItemQ3.Visible = false;
            // 
            // ItemQ4
            // 
            this.ItemQ4.AutoSize = true;
            this.ItemQ4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ4.ForeColor = System.Drawing.Color.White;
            this.ItemQ4.Location = new System.Drawing.Point(394, 149);
            this.ItemQ4.Name = "ItemQ4";
            this.ItemQ4.Size = new System.Drawing.Size(14, 16);
            this.ItemQ4.TabIndex = 59;
            this.ItemQ4.Text = "0";
            this.ItemQ4.Visible = false;
            // 
            // ItemQ5
            // 
            this.ItemQ5.AutoSize = true;
            this.ItemQ5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ5.ForeColor = System.Drawing.Color.White;
            this.ItemQ5.Location = new System.Drawing.Point(394, 167);
            this.ItemQ5.Name = "ItemQ5";
            this.ItemQ5.Size = new System.Drawing.Size(14, 16);
            this.ItemQ5.TabIndex = 60;
            this.ItemQ5.Text = "0";
            this.ItemQ5.Visible = false;
            // 
            // ItemQ6
            // 
            this.ItemQ6.AutoSize = true;
            this.ItemQ6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ6.ForeColor = System.Drawing.Color.White;
            this.ItemQ6.Location = new System.Drawing.Point(394, 183);
            this.ItemQ6.Name = "ItemQ6";
            this.ItemQ6.Size = new System.Drawing.Size(14, 16);
            this.ItemQ6.TabIndex = 61;
            this.ItemQ6.Text = "0";
            this.ItemQ6.Visible = false;
            // 
            // ItemQ7
            // 
            this.ItemQ7.AutoSize = true;
            this.ItemQ7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ7.ForeColor = System.Drawing.Color.White;
            this.ItemQ7.Location = new System.Drawing.Point(394, 199);
            this.ItemQ7.Name = "ItemQ7";
            this.ItemQ7.Size = new System.Drawing.Size(14, 16);
            this.ItemQ7.TabIndex = 62;
            this.ItemQ7.Text = "0";
            this.ItemQ7.Visible = false;
            // 
            // ItemQ8
            // 
            this.ItemQ8.AutoSize = true;
            this.ItemQ8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ8.ForeColor = System.Drawing.Color.White;
            this.ItemQ8.Location = new System.Drawing.Point(394, 215);
            this.ItemQ8.Name = "ItemQ8";
            this.ItemQ8.Size = new System.Drawing.Size(14, 16);
            this.ItemQ8.TabIndex = 63;
            this.ItemQ8.Text = "0";
            this.ItemQ8.Visible = false;
            // 
            // ItemQ9
            // 
            this.ItemQ9.AutoSize = true;
            this.ItemQ9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ9.ForeColor = System.Drawing.Color.White;
            this.ItemQ9.Location = new System.Drawing.Point(394, 231);
            this.ItemQ9.Name = "ItemQ9";
            this.ItemQ9.Size = new System.Drawing.Size(14, 16);
            this.ItemQ9.TabIndex = 64;
            this.ItemQ9.Text = "0";
            this.ItemQ9.Visible = false;
            // 
            // ItemQ10
            // 
            this.ItemQ10.AutoSize = true;
            this.ItemQ10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQ10.ForeColor = System.Drawing.Color.White;
            this.ItemQ10.Location = new System.Drawing.Point(394, 247);
            this.ItemQ10.Name = "ItemQ10";
            this.ItemQ10.Size = new System.Drawing.Size(14, 16);
            this.ItemQ10.TabIndex = 65;
            this.ItemQ10.Text = "0";
            this.ItemQ10.Visible = false;
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCost.ForeColor = System.Drawing.Color.White;
            this.TotalCost.Location = new System.Drawing.Point(269, 269);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(37, 19);
            this.TotalCost.TabIndex = 66;
            this.TotalCost.Text = "0.00";
            // 
            // Delivery_Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(549, 315);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.ItemQ10);
            this.Controls.Add(this.ItemQ9);
            this.Controls.Add(this.ItemQ8);
            this.Controls.Add(this.ItemQ7);
            this.Controls.Add(this.ItemQ6);
            this.Controls.Add(this.ItemQ5);
            this.Controls.Add(this.ItemQ4);
            this.Controls.Add(this.ItemQ3);
            this.Controls.Add(this.ItemQ2);
            this.Controls.Add(this.ItemQ1);
            this.Controls.Add(this.Item10);
            this.Controls.Add(this.Item9);
            this.Controls.Add(this.Item8);
            this.Controls.Add(this.Item7);
            this.Controls.Add(this.Item6);
            this.Controls.Add(this.Item5);
            this.Controls.Add(this.Item4);
            this.Controls.Add(this.Item3);
            this.Controls.Add(this.Item2);
            this.Controls.Add(this.Item1);
            this.Controls.Add(this.TotalAmountText);
            this.Controls.Add(this.OrderedItemsText);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.CustomerAddressText);
            this.Controls.Add(this.DeliverAddrText);
            this.Controls.Add(this.DeliverNameText);
            this.Controls.Add(this.PhoneNumberText);
            this.Controls.Add(this.CustomerNameText);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BackButton);
            this.Name = "Delivery_Final";
            this.Text = "Delivery_Final";
            this.Load += new System.EventHandler(this.Delivery_Final_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Label Label1;
        internal Button BackButton;
        internal TextBox PhoneNumberText;
        internal TextBox CustomerNameText;
        internal TextBox DeliverNameText;
        internal TextBox DeliverAddrText;
        internal Label CustomerAddressText;
        internal Button DoneButton;
        internal Label OrderedItemsText;
        internal Label TotalAmountText;
        internal Label Item1;
        internal Label Item2;
        internal Label Item3;
        internal Label Item4;
        internal Label Item5;
        internal Label Item6;
        internal Label Item7;
        internal Label Item8;
        internal Label Item9;
        internal Label Item10;
        internal Label ItemQ1;
        internal Label ItemQ2;
        internal Label ItemQ3;
        internal Label ItemQ4;
        internal Label ItemQ5;
        internal Label ItemQ6;
        internal Label ItemQ7;
        internal Label ItemQ8;
        internal Label ItemQ9;
        internal Label ItemQ10;
        internal Label TotalCost;
    }
}