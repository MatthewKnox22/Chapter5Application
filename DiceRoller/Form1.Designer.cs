namespace DiceRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.Roll = new System.Windows.Forms.Label();
            this.diceOne = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.diceTwo = new System.Windows.Forms.PictureBox();
            this.diceThree = new System.Windows.Forms.PictureBox();
            this.diceFour = new System.Windows.Forms.PictureBox();
            this.diceFive = new System.Windows.Forms.PictureBox();
            this.diceSix = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.diceOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceSix)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1154, 580);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.White;
            this.btnRoll.ForeColor = System.Drawing.Color.Black;
            this.btnRoll.Location = new System.Drawing.Point(473, 55);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // Roll
            // 
            this.Roll.AutoSize = true;
            this.Roll.BackColor = System.Drawing.Color.White;
            this.Roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll.ForeColor = System.Drawing.Color.Black;
            this.Roll.Location = new System.Drawing.Point(518, 9);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(144, 25);
            this.Roll.TabIndex = 3;
            this.Roll.Text = "Roll the dice";
            // 
            // diceOne
            // 
            this.diceOne.BackColor = System.Drawing.SystemColors.Control;
            this.diceOne.Image = ((System.Drawing.Image)(resources.GetObject("diceOne.Image")));
            this.diceOne.InitialImage = null;
            this.diceOne.Location = new System.Drawing.Point(145, 107);
            this.diceOne.Name = "diceOne";
            this.diceOne.Size = new System.Drawing.Size(260, 226);
            this.diceOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.diceOne.TabIndex = 4;
            this.diceOne.TabStop = false;
            this.diceOne.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(616, 55);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // diceTwo
            // 
            this.diceTwo.BackColor = System.Drawing.SystemColors.Control;
            this.diceTwo.Image = ((System.Drawing.Image)(resources.GetObject("diceTwo.Image")));
            this.diceTwo.InitialImage = null;
            this.diceTwo.Location = new System.Drawing.Point(431, 107);
            this.diceTwo.Name = "diceTwo";
            this.diceTwo.Size = new System.Drawing.Size(260, 226);
            this.diceTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceTwo.TabIndex = 5;
            this.diceTwo.TabStop = false;
            this.diceTwo.Visible = false;
            // 
            // diceThree
            // 
            this.diceThree.BackColor = System.Drawing.SystemColors.Control;
            this.diceThree.Image = ((System.Drawing.Image)(resources.GetObject("diceThree.Image")));
            this.diceThree.InitialImage = null;
            this.diceThree.Location = new System.Drawing.Point(732, 107);
            this.diceThree.Name = "diceThree";
            this.diceThree.Size = new System.Drawing.Size(260, 226);
            this.diceThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceThree.TabIndex = 6;
            this.diceThree.TabStop = false;
            this.diceThree.Visible = false;
            // 
            // diceFour
            // 
            this.diceFour.BackColor = System.Drawing.SystemColors.Control;
            this.diceFour.Image = ((System.Drawing.Image)(resources.GetObject("diceFour.Image")));
            this.diceFour.InitialImage = null;
            this.diceFour.Location = new System.Drawing.Point(145, 363);
            this.diceFour.Name = "diceFour";
            this.diceFour.Size = new System.Drawing.Size(260, 226);
            this.diceFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceFour.TabIndex = 7;
            this.diceFour.TabStop = false;
            this.diceFour.Visible = false;
            // 
            // diceFive
            // 
            this.diceFive.BackColor = System.Drawing.SystemColors.Control;
            this.diceFive.Image = ((System.Drawing.Image)(resources.GetObject("diceFive.Image")));
            this.diceFive.InitialImage = null;
            this.diceFive.Location = new System.Drawing.Point(431, 363);
            this.diceFive.Name = "diceFive";
            this.diceFive.Size = new System.Drawing.Size(260, 226);
            this.diceFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceFive.TabIndex = 8;
            this.diceFive.TabStop = false;
            this.diceFive.Visible = false;
            // 
            // diceSix
            // 
            this.diceSix.BackColor = System.Drawing.SystemColors.Control;
            this.diceSix.Image = ((System.Drawing.Image)(resources.GetObject("diceSix.Image")));
            this.diceSix.InitialImage = null;
            this.diceSix.Location = new System.Drawing.Point(732, 363);
            this.diceSix.Name = "diceSix";
            this.diceSix.Size = new System.Drawing.Size(260, 226);
            this.diceSix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diceSix.TabIndex = 9;
            this.diceSix.TabStop = false;
            this.diceSix.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 646);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.diceSix);
            this.Controls.Add(this.diceFive);
            this.Controls.Add(this.diceFour);
            this.Controls.Add(this.diceThree);
            this.Controls.Add(this.diceTwo);
            this.Controls.Add(this.diceOne);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.Text = "Dice Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.diceOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceSix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label Roll;
        private System.Windows.Forms.PictureBox diceOne;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox diceTwo;
        private System.Windows.Forms.PictureBox diceThree;
        private System.Windows.Forms.PictureBox diceFour;
        private System.Windows.Forms.PictureBox diceFive;
        private System.Windows.Forms.PictureBox diceSix;
    }
}

