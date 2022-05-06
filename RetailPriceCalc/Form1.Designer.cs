namespace RetailPriceCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWholesale = new System.Windows.Forms.TextBox();
            this.txtMarkup = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CalculateRetail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wholesale Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Markup Percantage (%)";
            // 
            // txtWholesale
            // 
            this.txtWholesale.Location = new System.Drawing.Point(192, 53);
            this.txtWholesale.Name = "txtWholesale";
            this.txtWholesale.Size = new System.Drawing.Size(100, 20);
            this.txtWholesale.TabIndex = 2;
            // 
            // txtMarkup
            // 
            this.txtMarkup.Location = new System.Drawing.Point(192, 91);
            this.txtMarkup.Name = "txtMarkup";
            this.txtMarkup.Size = new System.Drawing.Size(100, 20);
            this.txtMarkup.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalculateRetail
            // 
            this.CalculateRetail.Location = new System.Drawing.Point(134, 140);
            this.CalculateRetail.Name = "CalculateRetail";
            this.CalculateRetail.Size = new System.Drawing.Size(100, 20);
            this.CalculateRetail.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 217);
            this.Controls.Add(this.CalculateRetail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMarkup);
            this.Controls.Add(this.txtWholesale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWholesale;
        private System.Windows.Forms.TextBox txtMarkup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CalculateRetail;
    }
}

