
namespace ZastitaS
{
    partial class OdabirForma
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnMD5 = new System.Windows.Forms.RadioButton();
            this.rbtnA5 = new System.Windows.Forms.RadioButton();
            this.rbtnRC = new System.Windows.Forms.RadioButton();
            this.rbtnXTea = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDalje = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbtnMD5);
            this.panel1.Controls.Add(this.rbtnA5);
            this.panel1.Controls.Add(this.rbtnRC);
            this.panel1.Controls.Add(this.rbtnXTea);
            this.panel1.Location = new System.Drawing.Point(206, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 197);
            this.panel1.TabIndex = 7;
            this.panel1.TabStop = true;
            // 
            // rbtnMD5
            // 
            this.rbtnMD5.AutoSize = true;
            this.rbtnMD5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMD5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnMD5.Location = new System.Drawing.Point(112, 149);
            this.rbtnMD5.Name = "rbtnMD5";
            this.rbtnMD5.Size = new System.Drawing.Size(74, 27);
            this.rbtnMD5.TabIndex = 7;
            this.rbtnMD5.Text = "MD5";
            this.rbtnMD5.UseVisualStyleBackColor = true;
            // 
            // rbtnA5
            // 
            this.rbtnA5.AutoSize = true;
            this.rbtnA5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnA5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnA5.Location = new System.Drawing.Point(112, 105);
            this.rbtnA5.Name = "rbtnA5";
            this.rbtnA5.Size = new System.Drawing.Size(77, 27);
            this.rbtnA5.TabIndex = 6;
            this.rbtnA5.Text = "A5/2";
            this.rbtnA5.UseVisualStyleBackColor = true;
            // 
            // rbtnRC
            // 
            this.rbtnRC.AutoSize = true;
            this.rbtnRC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnRC.Location = new System.Drawing.Point(112, 62);
            this.rbtnRC.Name = "rbtnRC";
            this.rbtnRC.Size = new System.Drawing.Size(195, 27);
            this.rbtnRC.TabIndex = 5;
            this.rbtnRC.Text = "Railfence cipher ";
            this.rbtnRC.UseVisualStyleBackColor = true;
            // 
            // rbtnXTea
            // 
            this.rbtnXTea.AutoSize = true;
            this.rbtnXTea.Checked = true;
            this.rbtnXTea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnXTea.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnXTea.Location = new System.Drawing.Point(112, 18);
            this.rbtnXTea.Name = "rbtnXTea";
            this.rbtnXTea.Size = new System.Drawing.Size(78, 27);
            this.rbtnXTea.TabIndex = 4;
            this.rbtnXTea.TabStop = true;
            this.rbtnXTea.Text = "XTea";
            this.rbtnXTea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(266, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Odaberi algoritam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(1, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 56);
            this.panel2.TabIndex = 8;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinimize.Location = new System.Drawing.Point(677, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(726, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnDalje
            // 
            this.btnDalje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDalje.FlatAppearance.BorderSize = 0;
            this.btnDalje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDalje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnDalje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDalje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDalje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDalje.Location = new System.Drawing.Point(333, 375);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(112, 45);
            this.btnDalje.TabIndex = 9;
            this.btnDalje.Text = "Dalje";
            this.btnDalje.UseVisualStyleBackColor = false;
            this.btnDalje.Click += new System.EventHandler(this.btnDalje_Click);
            // 
            // OdabirForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDalje);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "OdabirForma";
            this.Text = "OdabirForma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnMD5;
        private System.Windows.Forms.RadioButton rbtnA5;
        private System.Windows.Forms.RadioButton rbtnRC;
        private System.Windows.Forms.RadioButton rbtnXTea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDalje;
    }
}