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
            this.BackButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.DefaultCardButton = new System.Windows.Forms.RadioButton();
            this.DiffCardButton = new System.Windows.Forms.RadioButton();
            this.CashButton = new System.Windows.Forms.RadioButton();
            this.CheckButton = new System.Windows.Forms.RadioButton();
            this.DefaultCardText = new System.Windows.Forms.Label();
            this.CardNumText = new System.Windows.Forms.TextBox();
            this.CardExpText = new System.Windows.Forms.TextBox();
            this.CardPinText = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(60, 39);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(210, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(137, 36);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Payment";
            // 
            // DefaultCardButton
            // 
            this.DefaultCardButton.AutoSize = true;
            this.DefaultCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultCardButton.ForeColor = System.Drawing.Color.White;
            this.DefaultCardButton.Location = new System.Drawing.Point(77, 108);
            this.DefaultCardButton.Name = "DefaultCardButton";
            this.DefaultCardButton.Size = new System.Drawing.Size(128, 20);
            this.DefaultCardButton.TabIndex = 2;
            this.DefaultCardButton.TabStop = true;
            this.DefaultCardButton.Text = "Use Default Card";
            this.DefaultCardButton.UseVisualStyleBackColor = true;
            this.DefaultCardButton.CheckedChanged += new System.EventHandler(this.DefaultCardButton_CheckedChanged);
            // 
            // DiffCardButton
            // 
            this.DiffCardButton.AutoSize = true;
            this.DiffCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiffCardButton.ForeColor = System.Drawing.Color.White;
            this.DiffCardButton.Location = new System.Drawing.Point(77, 179);
            this.DiffCardButton.Name = "DiffCardButton";
            this.DiffCardButton.Size = new System.Drawing.Size(135, 20);
            this.DiffCardButton.TabIndex = 3;
            this.DiffCardButton.TabStop = true;
            this.DiffCardButton.Text = "Use Different Card";
            this.DiffCardButton.UseVisualStyleBackColor = true;
            this.DiffCardButton.CheckedChanged += new System.EventHandler(this.DiffCardButton_CheckedChanged);
            // 
            // CashButton
            // 
            this.CashButton.AutoSize = true;
            this.CashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashButton.ForeColor = System.Drawing.Color.White;
            this.CashButton.Location = new System.Drawing.Point(346, 108);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(109, 20);
            this.CashButton.TabIndex = 4;
            this.CashButton.TabStop = true;
            this.CashButton.Text = "Pay with Cash";
            this.CashButton.UseVisualStyleBackColor = true;
            this.CashButton.CheckedChanged += new System.EventHandler(this.CashButton_CheckedChanged);
            // 
            // CheckButton
            // 
            this.CheckButton.AutoSize = true;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.ForeColor = System.Drawing.Color.White;
            this.CheckButton.Location = new System.Drawing.Point(346, 179);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(116, 20);
            this.CheckButton.TabIndex = 5;
            this.CheckButton.TabStop = true;
            this.CheckButton.Text = "Pay with Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.CheckedChanged += new System.EventHandler(this.CheckButton_CheckedChanged);
            // 
            // DefaultCardText
            // 
            this.DefaultCardText.AutoSize = true;
            this.DefaultCardText.ForeColor = System.Drawing.Color.White;
            this.DefaultCardText.Location = new System.Drawing.Point(110, 128);
            this.DefaultCardText.Name = "DefaultCardText";
            this.DefaultCardText.Size = new System.Drawing.Size(79, 13);
            this.DefaultCardText.TabIndex = 6;
            this.DefaultCardText.Text = "************1234";
            // 
            // CardNumText
            // 
            this.CardNumText.Location = new System.Drawing.Point(89, 202);
            this.CardNumText.Name = "CardNumText";
            this.CardNumText.Size = new System.Drawing.Size(150, 20);
            this.CardNumText.TabIndex = 7;
            this.CardNumText.Text = "Card Number";
            this.CardNumText.TextChanged += new System.EventHandler(this.CardNumText_TextChanged);
            // 
            // CardExpText
            // 
            this.CardExpText.Location = new System.Drawing.Point(89, 228);
            this.CardExpText.Name = "CardExpText";
            this.CardExpText.Size = new System.Drawing.Size(77, 20);
            this.CardExpText.TabIndex = 8;
            this.CardExpText.Text = "Exp Date";
            this.CardExpText.TextChanged += new System.EventHandler(this.CardExpText_TextChanged);
            // 
            // CardPinText
            // 
            this.CardPinText.Location = new System.Drawing.Point(181, 228);
            this.CardPinText.Name = "CardPinText";
            this.CardPinText.Size = new System.Drawing.Size(58, 20);
            this.CardPinText.TabIndex = 9;
            this.CardPinText.Text = "CVV";
            this.CardPinText.TextChanged += new System.EventHandler(this.CardPinText_TextChanged);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(264, 261);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(552, 310);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CardPinText);
            this.Controls.Add(this.CardExpText);
            this.Controls.Add(this.CardNumText);
            this.Controls.Add(this.DefaultCardText);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.CashButton);
            this.Controls.Add(this.DiffCardButton);
            this.Controls.Add(this.DefaultCardButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BackButton);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Button BackButton;
        internal Label Label1;
        internal RadioButton DefaultCardButton;
        internal RadioButton DiffCardButton;
        internal RadioButton CashButton;
        internal RadioButton CheckButton;
        internal Label DefaultCardText;
        internal TextBox CardNumText;
        internal TextBox CardExpText;
        internal TextBox CardPinText;
        internal Button NextButton;
    }
}