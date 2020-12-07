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
            this.BackButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.CashButton = new System.Windows.Forms.RadioButton();
            this.CheckButton = new System.Windows.Forms.RadioButton();
            this.CardButton = new System.Windows.Forms.RadioButton();
            this.CardNumText = new System.Windows.Forms.TextBox();
            this.CardExpText = new System.Windows.Forms.TextBox();
            this.CardPinText = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(62, 40);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "< Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(206, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(137, 36);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Payment";
            // 
            // CashButton
            // 
            this.CashButton.AutoSize = true;
            this.CashButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashButton.ForeColor = System.Drawing.Color.White;
            this.CashButton.Location = new System.Drawing.Point(350, 113);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(113, 23);
            this.CashButton.TabIndex = 5;
            this.CashButton.TabStop = true;
            this.CashButton.Text = "Pay with Cash";
            this.CashButton.UseVisualStyleBackColor = true;
            this.CashButton.CheckedChanged += new System.EventHandler(this.CashButton_CheckedChanged);
            // 
            // CheckButton
            // 
            this.CheckButton.AutoSize = true;
            this.CheckButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckButton.ForeColor = System.Drawing.Color.White;
            this.CheckButton.Location = new System.Drawing.Point(350, 188);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(121, 23);
            this.CheckButton.TabIndex = 6;
            this.CheckButton.TabStop = true;
            this.CheckButton.Text = "Pay with Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.CheckedChanged += new System.EventHandler(this.CheckButton_CheckedChanged);
            // 
            // CardButton
            // 
            this.CardButton.AutoSize = true;
            this.CardButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardButton.ForeColor = System.Drawing.Color.White;
            this.CardButton.Location = new System.Drawing.Point(62, 113);
            this.CardButton.Name = "CardButton";
            this.CardButton.Size = new System.Drawing.Size(112, 23);
            this.CardButton.TabIndex = 7;
            this.CardButton.TabStop = true;
            this.CardButton.Text = "Pay with Card";
            this.CardButton.UseVisualStyleBackColor = true;
            this.CardButton.CheckedChanged += new System.EventHandler(this.CardButton_CheckedChanged);
            // 
            // CardNumText
            // 
            this.CardNumText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumText.Location = new System.Drawing.Point(80, 163);
            this.CardNumText.Name = "CardNumText";
            this.CardNumText.Size = new System.Drawing.Size(150, 22);
            this.CardNumText.TabIndex = 8;
            this.CardNumText.TextChanged += new System.EventHandler(this.CardNumText_TextChanged);
            // 
            // CardExpText
            // 
            this.CardExpText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardExpText.Location = new System.Drawing.Point(80, 202);
            this.CardExpText.Name = "CardExpText";
            this.CardExpText.Size = new System.Drawing.Size(77, 22);
            this.CardExpText.TabIndex = 9;
            this.CardExpText.TextChanged += new System.EventHandler(this.CardExpText_TextChanged);
            // 
            // CardPinText
            // 
            this.CardPinText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardPinText.Location = new System.Drawing.Point(172, 202);
            this.CardPinText.Name = "CardPinText";
            this.CardPinText.Size = new System.Drawing.Size(58, 22);
            this.CardPinText.TabIndex = 10;
            this.CardPinText.TextChanged += new System.EventHandler(this.CardPinText_TextChanged);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(248, 259);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(77, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Exp Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(77, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Card Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(169, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "CVV";
            // 
            // Payment_Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(546, 313);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CardPinText);
            this.Controls.Add(this.CardExpText);
            this.Controls.Add(this.CardNumText);
            this.Controls.Add(this.CardButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.CashButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BackButton);
            this.Name = "Payment_Guest";
            this.Text = "Payment_Guest";
            this.Load += new System.EventHandler(this.Payment_Guest_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal Button BackButton;
        internal Label Label1;
        internal RadioButton CashButton;
        internal RadioButton CheckButton;
        internal RadioButton CardButton;
        internal TextBox CardNumText;
        internal TextBox CardExpText;
        internal TextBox CardPinText;
        internal Button NextButton;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}