namespace StringEqualityJohnN
{
    partial class frmStringEquality
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
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.lblString1 = new System.Windows.Forms.Label();
            this.lblString2 = new System.Windows.Forms.Label();
            this.lblInstruct = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(99, 109);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(164, 20);
            this.txtString1.TabIndex = 0;
            this.txtString1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(99, 177);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(164, 20);
            this.txtString2.TabIndex = 1;
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString1.Location = new System.Drawing.Point(12, 103);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(81, 26);
            this.lblString1.TabIndex = 2;
            this.lblString1.Text = "String 1:";
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString2.Location = new System.Drawing.Point(12, 171);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(81, 26);
            this.lblString2.TabIndex = 3;
            this.lblString2.Text = "String 2:";
            // 
            // lblInstruct
            // 
            this.lblInstruct.AutoSize = true;
            this.lblInstruct.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruct.Location = new System.Drawing.Point(37, 9);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Size = new System.Drawing.Size(226, 52);
            this.lblInstruct.TabIndex = 4;
            this.lblInstruct.Text = "Enter two strings to see if \r\nthey are equal";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(106, 216);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 41);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmStringEquality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 282);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblInstruct);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.lblString1);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.txtString1);
            this.Name = "frmStringEquality";
            this.Text = "String Equality";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.Label lblInstruct;
        private System.Windows.Forms.Button btnCheck;
    }
}

