using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Software_Engineering
{
    [DesignerGenerated()]
    public partial class Reciept_Card : Form
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
            this.BackButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.CustomerNameText = new System.Windows.Forms.TextBox();
            this.OrderNumberText = new System.Windows.Forms.TextBox();
            this.TotalText = new System.Windows.Forms.Label();
            this.TaxText = new System.Windows.Forms.Label();
            this.Item3 = new System.Windows.Forms.Label();
            this.Item2 = new System.Windows.Forms.Label();
            this.Item1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.TaxAmount = new System.Windows.Forms.Label();
            this.Item3Price = new System.Windows.Forms.Label();
            this.Item2Price = new System.Windows.Forms.Label();
            this.Item1Price = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.QuantityText3 = new System.Windows.Forms.TextBox();
            this.QuantityText2 = new System.Windows.Forms.TextBox();
            this.QuantityText1 = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.DeliveryButton = new System.Windows.Forms.Button();
            this.CarryoutButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SignatureText = new System.Windows.Forms.TextBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackButton.Location = new System.Drawing.Point(30, 28);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 25);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(227, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(117, 36);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Receipt";
            // 
            // CustomerNameText
            // 
            this.CustomerNameText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameText.Location = new System.Drawing.Point(30, 69);
            this.CustomerNameText.Name = "CustomerNameText";
            this.CustomerNameText.Size = new System.Drawing.Size(100, 22);
            this.CustomerNameText.TabIndex = 4;
            this.CustomerNameText.Text = "Customer Name";
            this.CustomerNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderNumberText
            // 
            this.OrderNumberText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNumberText.Location = new System.Drawing.Point(433, 70);
            this.OrderNumberText.Name = "OrderNumberText";
            this.OrderNumberText.Size = new System.Drawing.Size(104, 22);
            this.OrderNumberText.TabIndex = 5;
            this.OrderNumberText.Text = "Order Number: ";
            this.OrderNumberText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrderNumberText.TextChanged += new System.EventHandler(this.OrderNumberText_TextChanged);
            // 
            // TotalText
            // 
            this.TotalText.AutoSize = true;
            this.TotalText.BackColor = System.Drawing.Color.White;
            this.TotalText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalText.Location = new System.Drawing.Point(36, 265);
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(43, 19);
            this.TotalText.TabIndex = 25;
            this.TotalText.Text = "Total";
            // 
            // TaxText
            // 
            this.TaxText.AutoSize = true;
            this.TaxText.BackColor = System.Drawing.Color.White;
            this.TaxText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxText.Location = new System.Drawing.Point(36, 231);
            this.TaxText.Name = "TaxText";
            this.TaxText.Size = new System.Drawing.Size(33, 19);
            this.TaxText.TabIndex = 24;
            this.TaxText.Text = "Tax:";
            // 
            // Item3
            // 
            this.Item3.AutoSize = true;
            this.Item3.BackColor = System.Drawing.Color.White;
            this.Item3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item3.Location = new System.Drawing.Point(36, 204);
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(83, 19);
            this.Item3.TabIndex = 23;
            this.Item3.Text = "Hash Brown";
            // 
            // Item2
            // 
            this.Item2.AutoSize = true;
            this.Item2.BackColor = System.Drawing.Color.White;
            this.Item2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item2.Location = new System.Drawing.Point(36, 174);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(125, 19);
            this.Item2.TabIndex = 22;
            this.Item2.Text = "Breakfast Supreme";
            // 
            // Item1
            // 
            this.Item1.AutoSize = true;
            this.Item1.BackColor = System.Drawing.Color.White;
            this.Item1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item1.Location = new System.Drawing.Point(36, 142);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(103, 19);
            this.Item1.TabIndex = 21;
            this.Item1.Text = "Garden Omelet";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(35, 102);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 25);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Items";
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSize = true;
            this.TotalAmount.BackColor = System.Drawing.Color.White;
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.Location = new System.Drawing.Point(192, 265);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(53, 19);
            this.TotalAmount.TabIndex = 31;
            this.TotalAmount.Text = "$18.06";
            // 
            // TaxAmount
            // 
            this.TaxAmount.AutoSize = true;
            this.TaxAmount.BackColor = System.Drawing.Color.White;
            this.TaxAmount.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxAmount.Location = new System.Drawing.Point(192, 231);
            this.TaxAmount.Name = "TaxAmount";
            this.TaxAmount.Size = new System.Drawing.Size(45, 19);
            this.TaxAmount.TabIndex = 30;
            this.TaxAmount.Text = "$0.50";
            // 
            // Item3Price
            // 
            this.Item3Price.AutoSize = true;
            this.Item3Price.BackColor = System.Drawing.Color.White;
            this.Item3Price.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item3Price.Location = new System.Drawing.Point(192, 204);
            this.Item3Price.Name = "Item3Price";
            this.Item3Price.Size = new System.Drawing.Size(45, 19);
            this.Item3Price.TabIndex = 29;
            this.Item3Price.Text = "$2.89";
            // 
            // Item2Price
            // 
            this.Item2Price.AutoSize = true;
            this.Item2Price.BackColor = System.Drawing.Color.White;
            this.Item2Price.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item2Price.Location = new System.Drawing.Point(192, 174);
            this.Item2Price.Name = "Item2Price";
            this.Item2Price.Size = new System.Drawing.Size(45, 19);
            this.Item2Price.TabIndex = 28;
            this.Item2Price.Text = "$6.99";
            // 
            // Item1Price
            // 
            this.Item1Price.AutoSize = true;
            this.Item1Price.BackColor = System.Drawing.Color.White;
            this.Item1Price.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item1Price.Location = new System.Drawing.Point(192, 142);
            this.Item1Price.Name = "Item1Price";
            this.Item1Price.Size = new System.Drawing.Size(45, 19);
            this.Item1Price.TabIndex = 27;
            this.Item1Price.Text = "$4.79";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.BackColor = System.Drawing.Color.White;
            this.Label12.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(191, 102);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(57, 25);
            this.Label12.TabIndex = 26;
            this.Label12.Text = "Price";
            // 
            // QuantityText3
            // 
            this.QuantityText3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityText3.Location = new System.Drawing.Point(294, 204);
            this.QuantityText3.Name = "QuantityText3";
            this.QuantityText3.Size = new System.Drawing.Size(87, 22);
            this.QuantityText3.TabIndex = 35;
            this.QuantityText3.Text = "2";
            this.QuantityText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuantityText2
            // 
            this.QuantityText2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityText2.Location = new System.Drawing.Point(294, 174);
            this.QuantityText2.Name = "QuantityText2";
            this.QuantityText2.Size = new System.Drawing.Size(87, 22);
            this.QuantityText2.TabIndex = 34;
            this.QuantityText2.Text = "1";
            this.QuantityText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuantityText1
            // 
            this.QuantityText1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityText1.Location = new System.Drawing.Point(294, 142);
            this.QuantityText1.Name = "QuantityText1";
            this.QuantityText1.Size = new System.Drawing.Size(87, 22);
            this.QuantityText1.TabIndex = 33;
            this.QuantityText1.Text = "1";
            this.QuantityText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(289, 102);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(91, 25);
            this.Label14.TabIndex = 32;
            this.Label14.Text = "Quantity";
            // 
            // DeliveryButton
            // 
            this.DeliveryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeliveryButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryButton.Location = new System.Drawing.Point(107, 303);
            this.DeliveryButton.Name = "DeliveryButton";
            this.DeliveryButton.Size = new System.Drawing.Size(75, 23);
            this.DeliveryButton.TabIndex = 36;
            this.DeliveryButton.Text = "Delivery";
            this.DeliveryButton.UseVisualStyleBackColor = false;
            // 
            // CarryoutButton
            // 
            this.CarryoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CarryoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CarryoutButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarryoutButton.Location = new System.Drawing.Point(343, 303);
            this.CarryoutButton.Name = "CarryoutButton";
            this.CarryoutButton.Size = new System.Drawing.Size(75, 23);
            this.CarryoutButton.TabIndex = 37;
            this.CarryoutButton.Text = "Carryout";
            this.CarryoutButton.UseVisualStyleBackColor = false;
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(233, 320);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 38;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            // 
            // SignatureText
            // 
            this.SignatureText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignatureText.Location = new System.Drawing.Point(433, 323);
            this.SignatureText.Name = "SignatureText";
            this.SignatureText.Size = new System.Drawing.Size(166, 22);
            this.SignatureText.TabIndex = 39;
            this.SignatureText.Text = "Signature";
            this.SignatureText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Location = new System.Drawing.Point(30, 96);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(224, 201);
            this.Panel1.TabIndex = 40;
            // 
            // Reciept_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(603, 355);
            this.Controls.Add(this.SignatureText);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CarryoutButton);
            this.Controls.Add(this.DeliveryButton);
            this.Controls.Add(this.QuantityText3);
            this.Controls.Add(this.QuantityText2);
            this.Controls.Add(this.QuantityText1);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.TaxAmount);
            this.Controls.Add(this.Item3Price);
            this.Controls.Add(this.Item2Price);
            this.Controls.Add(this.Item1Price);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.TotalText);
            this.Controls.Add(this.TaxText);
            this.Controls.Add(this.Item3);
            this.Controls.Add(this.Item2);
            this.Controls.Add(this.Item1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.OrderNumberText);
            this.Controls.Add(this.CustomerNameText);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Panel1);
            this.Name = "Reciept_Card";
            this.Text = "Reciept_Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Button BackButton;
        internal Label Label1;
        internal TextBox CustomerNameText;
        internal TextBox OrderNumberText;
        internal Label TotalText;
        internal Label TaxText;
        internal Label Item3;
        internal Label Item2;
        internal Label Item1;
        internal Label Label2;
        internal Label TotalAmount;
        internal Label TaxAmount;
        internal Label Item3Price;
        internal Label Item2Price;
        internal Label Item1Price;
        internal Label Label12;
        internal TextBox QuantityText3;
        internal TextBox QuantityText2;
        internal TextBox QuantityText1;
        internal Label Label14;
        internal Button DeliveryButton;
        internal Button CarryoutButton;
        internal Button PrintButton;
        internal TextBox SignatureText;
        internal Panel Panel1;
    }
}