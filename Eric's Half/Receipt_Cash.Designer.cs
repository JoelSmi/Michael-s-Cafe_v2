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
            this.Item3Quantity = new System.Windows.Forms.TextBox();
            this.Item2Quantity = new System.Windows.Forms.TextBox();
            this.Item1Quantity = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.DeliveryButton = new System.Windows.Forms.Button();
            this.CarryoutButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.Item8Price = new System.Windows.Forms.Panel();
            this.Item10Price = new System.Windows.Forms.Label();
            this.Item9Price = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Item7Price = new System.Windows.Forms.Label();
            this.Item5Price = new System.Windows.Forms.Label();
            this.Item6Price = new System.Windows.Forms.Label();
            this.Item4Price = new System.Windows.Forms.Label();
            this.Item10 = new System.Windows.Forms.Label();
            this.Item9 = new System.Windows.Forms.Label();
            this.Item8 = new System.Windows.Forms.Label();
            this.Item7 = new System.Windows.Forms.Label();
            this.Item6 = new System.Windows.Forms.Label();
            this.Item5 = new System.Windows.Forms.Label();
            this.Item4 = new System.Windows.Forms.Label();
            this.Item4Quantity = new System.Windows.Forms.TextBox();
            this.Item5Quantity = new System.Windows.Forms.TextBox();
            this.Item6Quantity = new System.Windows.Forms.TextBox();
            this.Item7Quantity = new System.Windows.Forms.TextBox();
            this.Item8Quantity = new System.Windows.Forms.TextBox();
            this.Item9Quantity = new System.Windows.Forms.TextBox();
            this.Item10Quantity = new System.Windows.Forms.TextBox();
            this.Item8Price.SuspendLayout();
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
            // 
            // TotalText
            // 
            this.TotalText.AutoSize = true;
            this.TotalText.BackColor = System.Drawing.Color.White;
            this.TotalText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalText.Location = new System.Drawing.Point(5, 387);
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
            this.TaxText.Location = new System.Drawing.Point(15, 368);
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
            this.Item3.Size = new System.Drawing.Size(86, 19);
            this.Item3.TabIndex = 23;
            this.Item3.Text = "Place Holder";
            // 
            // Item2
            // 
            this.Item2.AutoSize = true;
            this.Item2.BackColor = System.Drawing.Color.White;
            this.Item2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item2.Location = new System.Drawing.Point(36, 174);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(86, 19);
            this.Item2.TabIndex = 22;
            this.Item2.Text = "Place Holder";
            // 
            // Item1
            // 
            this.Item1.AutoSize = true;
            this.Item1.BackColor = System.Drawing.Color.White;
            this.Item1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item1.Location = new System.Drawing.Point(36, 142);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(86, 19);
            this.Item1.TabIndex = 21;
            this.Item1.Text = "Place Holder";
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
            this.TotalAmount.Location = new System.Drawing.Point(161, 387);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(45, 19);
            this.TotalAmount.TabIndex = 31;
            this.TotalAmount.Text = "$0.00";
            // 
            // TaxAmount
            // 
            this.TaxAmount.AutoSize = true;
            this.TaxAmount.BackColor = System.Drawing.Color.White;
            this.TaxAmount.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxAmount.Location = new System.Drawing.Point(161, 368);
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
            this.Item3Price.Text = "$0.00";
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
            this.Item2Price.Text = "$0.00";
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
            this.Item1Price.Text = "$0.00";
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
            // Item3Quantity
            // 
            this.Item3Quantity.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item3Quantity.Location = new System.Drawing.Point(294, 201);
            this.Item3Quantity.Name = "Item3Quantity";
            this.Item3Quantity.Size = new System.Drawing.Size(87, 22);
            this.Item3Quantity.TabIndex = 35;
            this.Item3Quantity.Text = "0";
            this.Item3Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Item2Quantity
            // 
            this.Item2Quantity.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item2Quantity.Location = new System.Drawing.Point(294, 171);
            this.Item2Quantity.Name = "Item2Quantity";
            this.Item2Quantity.Size = new System.Drawing.Size(87, 22);
            this.Item2Quantity.TabIndex = 34;
            this.Item2Quantity.Text = "0";
            this.Item2Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Item1Quantity
            // 
            this.Item1Quantity.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item1Quantity.Location = new System.Drawing.Point(294, 139);
            this.Item1Quantity.Name = "Item1Quantity";
            this.Item1Quantity.Size = new System.Drawing.Size(87, 22);
            this.Item1Quantity.TabIndex = 33;
            this.Item1Quantity.Text = "0";
            this.Item1Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.DeliveryButton.Location = new System.Drawing.Point(30, 564);
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
            this.CarryoutButton.Location = new System.Drawing.Point(294, 564);
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
            this.PrintButton.Location = new System.Drawing.Point(162, 564);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 38;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            // 
            // Item8Price
            // 
            this.Item8Price.BackColor = System.Drawing.Color.White;
            this.Item8Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Item8Price.Controls.Add(this.Item10Price);
            this.Item8Price.Controls.Add(this.Item9Price);
            this.Item8Price.Controls.Add(this.label15);
            this.Item8Price.Controls.Add(this.Item7Price);
            this.Item8Price.Controls.Add(this.Item5Price);
            this.Item8Price.Controls.Add(this.Item6Price);
            this.Item8Price.Controls.Add(this.Item4Price);
            this.Item8Price.Controls.Add(this.Item10);
            this.Item8Price.Controls.Add(this.Item9);
            this.Item8Price.Controls.Add(this.Item8);
            this.Item8Price.Controls.Add(this.Item7);
            this.Item8Price.Controls.Add(this.Item6);
            this.Item8Price.Controls.Add(this.Item5);
            this.Item8Price.Controls.Add(this.Item4);
            this.Item8Price.Controls.Add(this.TotalText);
            this.Item8Price.Controls.Add(this.TaxText);
            this.Item8Price.Controls.Add(this.TotalAmount);
            this.Item8Price.Controls.Add(this.TaxAmount);
            this.Item8Price.Location = new System.Drawing.Point(30, 96);
            this.Item8Price.Name = "Item8Price";
            this.Item8Price.Size = new System.Drawing.Size(224, 422);
            this.Item8Price.TabIndex = 40;
            // 
            // Item10Price
            // 
            this.Item10Price.AutoSize = true;
            this.Item10Price.BackColor = System.Drawing.Color.White;
            this.Item10Price.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item10Price.Location = new System.Drawing.Point(161, 326);
            this.Item10Price.Name = "Item10Price";
            this.Item10Price.Size = new System.Drawing.Size(45, 19);
            this.Item10Price.TabIndex = 53;
            this.Item10Price.Text = "$0.00";
            // 
            // Item9Price
            // 
            this.Item9Price.AutoSize = true;
            this.Item9Price.BackColor = System.Drawing.Color.White;
            this.Item9Price.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item9Price.Location = new System.Drawing.Point(161, 292);
            this.Item9Price.Name = "Item9Price";
            this.Item9Price.Size = new System.Drawing.Size(45, 19);
            this.Item9Price.TabIndex = 52;
            this.Item9Price.Text = "$0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(161, 261);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 19);
            this.label15.TabIndex = 51;
            this.label15.Text = "$0.00";
            // 
            // Item7Price
            // 
            this.Item7Price.AutoSize = true;
            this.Item7Price.BackColor = System.Drawing.Color.White;
            this.Item7Price.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item7Price.Location = new System.Drawing.Point(161, 230);
            this.Item7Price.Name = "Item7Price";
            this.Item7Price.Size = new System.Drawing.Size(45, 19);
            this.Item7Price.TabIndex = 50;
            this.Item7Price.Text = "$0.00";
            // 
            // Item5Price
            // 
            this.Item5Price.AutoSize = true;
            this.Item5Price.BackColor = System.Drawing.Color.White;
            this.Item5Price.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item5Price.Location = new System.Drawing.Point(161, 166);
            this.Item5Price.Name = "Item5Price";
            this.Item5Price.Size = new System.Drawing.Size(45, 19);
            this.Item5Price.TabIndex = 49;
            this.Item5Price.Text = "$0.00";
            // 
            // Item6Price
            // 
            this.Item6Price.AutoSize = true;
            this.Item6Price.BackColor = System.Drawing.Color.White;
            this.Item6Price.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item6Price.Location = new System.Drawing.Point(161, 197);
            this.Item6Price.Name = "Item6Price";
            this.Item6Price.Size = new System.Drawing.Size(45, 19);
            this.Item6Price.TabIndex = 48;
            this.Item6Price.Text = "$0.00";
            // 
            // Item4Price
            // 
            this.Item4Price.AutoSize = true;
            this.Item4Price.BackColor = System.Drawing.Color.White;
            this.Item4Price.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item4Price.Location = new System.Drawing.Point(161, 135);
            this.Item4Price.Name = "Item4Price";
            this.Item4Price.Size = new System.Drawing.Size(45, 19);
            this.Item4Price.TabIndex = 41;
            this.Item4Price.Text = "$0.00";
            // 
            // Item10
            // 
            this.Item10.AutoSize = true;
            this.Item10.BackColor = System.Drawing.Color.White;
            this.Item10.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item10.Location = new System.Drawing.Point(5, 326);
            this.Item10.Name = "Item10";
            this.Item10.Size = new System.Drawing.Size(86, 19);
            this.Item10.TabIndex = 47;
            this.Item10.Text = "Place Holder";
            // 
            // Item9
            // 
            this.Item9.AutoSize = true;
            this.Item9.BackColor = System.Drawing.Color.White;
            this.Item9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item9.Location = new System.Drawing.Point(3, 292);
            this.Item9.Name = "Item9";
            this.Item9.Size = new System.Drawing.Size(86, 19);
            this.Item9.TabIndex = 46;
            this.Item9.Text = "Place Holder";
            // 
            // Item8
            // 
            this.Item8.AutoSize = true;
            this.Item8.BackColor = System.Drawing.Color.White;
            this.Item8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item8.Location = new System.Drawing.Point(5, 261);
            this.Item8.Name = "Item8";
            this.Item8.Size = new System.Drawing.Size(86, 19);
            this.Item8.TabIndex = 45;
            this.Item8.Text = "Place Holder";
            // 
            // Item7
            // 
            this.Item7.AutoSize = true;
            this.Item7.BackColor = System.Drawing.Color.White;
            this.Item7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item7.Location = new System.Drawing.Point(5, 230);
            this.Item7.Name = "Item7";
            this.Item7.Size = new System.Drawing.Size(86, 19);
            this.Item7.TabIndex = 44;
            this.Item7.Text = "Place Holder";
            // 
            // Item6
            // 
            this.Item6.AutoSize = true;
            this.Item6.BackColor = System.Drawing.Color.White;
            this.Item6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item6.Location = new System.Drawing.Point(5, 197);
            this.Item6.Name = "Item6";
            this.Item6.Size = new System.Drawing.Size(86, 19);
            this.Item6.TabIndex = 43;
            this.Item6.Text = "Place Holder";
            // 
            // Item5
            // 
            this.Item5.AutoSize = true;
            this.Item5.BackColor = System.Drawing.Color.White;
            this.Item5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item5.Location = new System.Drawing.Point(5, 169);
            this.Item5.Name = "Item5";
            this.Item5.Size = new System.Drawing.Size(86, 19);
            this.Item5.TabIndex = 42;
            this.Item5.Text = "Place Holder";
            // 
            // Item4
            // 
            this.Item4.AutoSize = true;
            this.Item4.BackColor = System.Drawing.Color.White;
            this.Item4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item4.Location = new System.Drawing.Point(3, 135);
            this.Item4.Name = "Item4";
            this.Item4.Size = new System.Drawing.Size(86, 19);
            this.Item4.TabIndex = 41;
            this.Item4.Text = "Place Holder";
            // 
            // Item4Quantity
            // 
            this.Item4Quantity.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item4Quantity.Location = new System.Drawing.Point(294, 229);
            this.Item4Quantity.Name = "Item4Quantity";
            this.Item4Quantity.Size = new System.Drawing.Size(87, 22);
            this.Item4Quantity.TabIndex = 41;
            this.Item4Quantity.Text = "0";
            this.Item4Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Item5Quantity
            // 
            this.Item5Quantity.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item5Quantity.Location = new System.Drawing.Point(294, 260);
            this.Item5Quantity.Name = "Item5Quantity";
            this.Item5Quantity.Size = new System.Drawing.Size(87, 22);
            this.Item5Quantity.TabIndex = 42;
            this.Item5Quantity.Text = "0";
            this.Item5Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Item6Quantity
            // 
            this.Item6Quantity.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item6Quantity.Location = new System.Drawing.Point(294, 291);
            this.Item6Quantity.Name = "Item6Quantity";
            this.Item6Quantity.Size = new System.Drawing.Size(87, 22);
            this.Item6Quantity.TabIndex = 43;
            this.Item6Quantity.Text = "0";
            this.Item6Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Item7Quantity
            // 
            this.Item7Quantity.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item7Quantity.Location = new System.Drawing.Point(294, 324);
            this.Item7Quantity.Name = "Item7Quantity";
            this.Item7Quantity.Size = new System.Drawing.Size(87, 22);
            this.Item7Quantity.TabIndex = 44;
            this.Item7Quantity.Text = "0";
            this.Item7Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Item8Quantity
            // 
            this.Item8Quantity.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item8Quantity.Location = new System.Drawing.Point(294, 355);
            this.Item8Quantity.Name = "Item8Quantity";
            this.Item8Quantity.Size = new System.Drawing.Size(87, 22);
            this.Item8Quantity.TabIndex = 45;
            this.Item8Quantity.Text = "0";
            this.Item8Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Item9Quantity
            // 
            this.Item9Quantity.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item9Quantity.Location = new System.Drawing.Point(294, 386);
            this.Item9Quantity.Name = "Item9Quantity";
            this.Item9Quantity.Size = new System.Drawing.Size(87, 22);
            this.Item9Quantity.TabIndex = 46;
            this.Item9Quantity.Text = "0";
            this.Item9Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Item10Quantity
            // 
            this.Item10Quantity.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item10Quantity.Location = new System.Drawing.Point(294, 420);
            this.Item10Quantity.Name = "Item10Quantity";
            this.Item10Quantity.Size = new System.Drawing.Size(87, 22);
            this.Item10Quantity.TabIndex = 47;
            this.Item10Quantity.Text = "0";
            this.Item10Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Reciept_Cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(603, 616);
            this.Controls.Add(this.Item10Quantity);
            this.Controls.Add(this.Item9Quantity);
            this.Controls.Add(this.Item8Quantity);
            this.Controls.Add(this.Item7Quantity);
            this.Controls.Add(this.Item6Quantity);
            this.Controls.Add(this.Item5Quantity);
            this.Controls.Add(this.Item4Quantity);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CarryoutButton);
            this.Controls.Add(this.DeliveryButton);
            this.Controls.Add(this.Item3Quantity);
            this.Controls.Add(this.Item2Quantity);
            this.Controls.Add(this.Item1Quantity);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Item3Price);
            this.Controls.Add(this.Item2Price);
            this.Controls.Add(this.Item1Price);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Item3);
            this.Controls.Add(this.Item2);
            this.Controls.Add(this.Item1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.OrderNumberText);
            this.Controls.Add(this.CustomerNameText);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Item8Price);
            this.Name = "Reciept_Cash";
            this.Text = "Reciept_Cash";
            this.Item8Price.ResumeLayout(false);
            this.Item8Price.PerformLayout();
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
        internal TextBox Item3Quantity;
        internal TextBox Item2Quantity;
        internal TextBox Item1Quantity;
        internal Label Label14;
        internal Button DeliveryButton;
        internal Button CarryoutButton;
        internal Button PrintButton;
        internal Panel Item8Price;
        internal Label Item10Price;
        internal Label Item9Price;
        internal Label label15;
        internal Label Item7Price;
        internal Label Item5Price;
        internal Label Item6Price;
        internal Label Item4Price;
        internal Label Item10;
        internal Label Item9;
        internal Label Item8;
        internal Label Item7;
        internal Label Item6;
        internal Label Item5;
        internal Label Item4;
        internal TextBox Item4Quantity;
        internal TextBox Item5Quantity;
        internal TextBox Item6Quantity;
        internal TextBox Item7Quantity;
        internal TextBox Item8Quantity;
        internal TextBox Item9Quantity;
        internal TextBox Item10Quantity;
    }
}