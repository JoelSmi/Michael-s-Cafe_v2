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
            this.PhoneNumberText.TextChanged += new System.EventHandler(this.PhoneNumberText_TextChanged);
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
            this.CustomerNameText.TextChanged += new System.EventHandler(this.CustomerNameText_TextChanged);
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
            this.DeliverNameText.TextChanged += new System.EventHandler(this.DeliverNameText_TextChanged);
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
            this.DeliverAddrText.TextChanged += new System.EventHandler(this.DeliverAddrText_TextChanged);
            // 
            // CustomerAddressText
            // 
            this.CustomerAddressText.AutoSize = true;
            this.CustomerAddressText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddressText.ForeColor = System.Drawing.Color.White;
            this.CustomerAddressText.Location = new System.Drawing.Point(31, 204);
            this.CustomerAddressText.Name = "CustomerAddressText";
            this.CustomerAddressText.Size = new System.Drawing.Size(126, 16);
            this.CustomerAddressText.TabIndex = 42;
            this.CustomerAddressText.Text = "*Show address chosen";
            this.CustomerAddressText.Click += new System.EventHandler(this.CustomerAddressText_Click);
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
            this.OrderedItemsText.Click += new System.EventHandler(this.OrderedItemsText_Click);
            // 
            // TotalAmountText
            // 
            this.TotalAmountText.AutoSize = true;
            this.TotalAmountText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountText.ForeColor = System.Drawing.Color.White;
            this.TotalAmountText.Location = new System.Drawing.Point(215, 204);
            this.TotalAmountText.Name = "TotalAmountText";
            this.TotalAmountText.Size = new System.Drawing.Size(59, 19);
            this.TotalAmountText.TabIndex = 45;
            this.TotalAmountText.Text = "Total: $";
            this.TotalAmountText.Click += new System.EventHandler(this.TotalAmountText_Click);
            // 
            // Delivery_Final
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(549, 315);
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
    }
}