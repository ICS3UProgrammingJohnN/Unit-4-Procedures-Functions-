namespace PassByRefJohnN
{
    partial class frmPassByRef
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
            this.lblDecimalNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numDecimalPlaces = new System.Windows.Forms.NumericUpDown();
            this.txtDecimalNumber = new System.Windows.Forms.TextBox();
            this.btnRound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDecimalPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDecimalNumber
            // 
            this.lblDecimalNumber.AutoSize = true;
            this.lblDecimalNumber.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimalNumber.Location = new System.Drawing.Point(12, 41);
            this.lblDecimalNumber.Name = "lblDecimalNumber";
            this.lblDecimalNumber.Size = new System.Drawing.Size(249, 28);
            this.lblDecimalNumber.TabIndex = 0;
            this.lblDecimalNumber.Text = "Enter a decimal number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "How many decimal places do you want to round to";
            // 
            // numDecimalPlaces
            // 
            this.numDecimalPlaces.Location = new System.Drawing.Point(453, 98);
            this.numDecimalPlaces.Name = "numDecimalPlaces";
            this.numDecimalPlaces.Size = new System.Drawing.Size(58, 20);
            this.numDecimalPlaces.TabIndex = 2;
            // 
            // txtDecimalNumber
            // 
            this.txtDecimalNumber.Location = new System.Drawing.Point(279, 49);
            this.txtDecimalNumber.Name = "txtDecimalNumber";
            this.txtDecimalNumber.Size = new System.Drawing.Size(133, 20);
            this.txtDecimalNumber.TabIndex = 3;
            // 
            // btnRound
            // 
            this.btnRound.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRound.Location = new System.Drawing.Point(216, 158);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(79, 29);
            this.btnRound.TabIndex = 4;
            this.btnRound.Text = "Round ";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // frmPassByRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 216);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.txtDecimalNumber);
            this.Controls.Add(this.numDecimalPlaces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDecimalNumber);
            this.Name = "frmPassByRef";
            this.Text = "Rounding Number";
            ((System.ComponentModel.ISupportInitialize)(this.numDecimalPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecimalNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDecimalPlaces;
        private System.Windows.Forms.TextBox txtDecimalNumber;
        private System.Windows.Forms.Button btnRound;
    }
}

