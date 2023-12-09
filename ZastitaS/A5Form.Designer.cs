
namespace ZastitaS
{
    partial class A5Form
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
            this.SetDefault = new System.Windows.Forms.Button();
            this.SetKey = new System.Windows.Forms.Button();
            this.KEY_Tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TEXT_CR_DECR_Tbx = new System.Windows.Forms.TextBox();
            this.LOADFILE_Button = new System.Windows.Forms.Button();
            this.SAVEFILE_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbCrypt = new System.Windows.Forms.RadioButton();
            this.rdbDecrypt = new System.Windows.Forms.RadioButton();
            this.cRdCr_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetDefault
            // 
            this.SetDefault.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SetDefault.Location = new System.Drawing.Point(161, 131);
            this.SetDefault.Margin = new System.Windows.Forms.Padding(4);
            this.SetDefault.Name = "SetDefault";
            this.SetDefault.Size = new System.Drawing.Size(179, 38);
            this.SetDefault.TabIndex = 15;
            this.SetDefault.Text = "SET DEFAULT KEY";
            this.SetDefault.UseVisualStyleBackColor = true;
            this.SetDefault.Click += new System.EventHandler(this.SetDefault_Click);
            // 
            // SetKey
            // 
            this.SetKey.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SetKey.Location = new System.Drawing.Point(581, 131);
            this.SetKey.Margin = new System.Windows.Forms.Padding(4);
            this.SetKey.Name = "SetKey";
            this.SetKey.Size = new System.Drawing.Size(119, 38);
            this.SetKey.TabIndex = 14;
            this.SetKey.Text = "SET KEY";
            this.SetKey.UseVisualStyleBackColor = true;
            this.SetKey.Click += new System.EventHandler(this.SetKey_Click);
            // 
            // KEY_Tbx
            // 
            this.KEY_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KEY_Tbx.Location = new System.Drawing.Point(161, 93);
            this.KEY_Tbx.Margin = new System.Windows.Forms.Padding(4);
            this.KEY_Tbx.MaxLength = 10000;
            this.KEY_Tbx.Name = "KEY_Tbx";
            this.KEY_Tbx.Size = new System.Drawing.Size(539, 30);
            this.KEY_Tbx.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "TEXT:";
            // 
            // TEXT_CR_DECR_Tbx
            // 
            this.TEXT_CR_DECR_Tbx.Location = new System.Drawing.Point(34, 242);
            this.TEXT_CR_DECR_Tbx.Margin = new System.Windows.Forms.Padding(4);
            this.TEXT_CR_DECR_Tbx.Multiline = true;
            this.TEXT_CR_DECR_Tbx.Name = "TEXT_CR_DECR_Tbx";
            this.TEXT_CR_DECR_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TEXT_CR_DECR_Tbx.Size = new System.Drawing.Size(399, 203);
            this.TEXT_CR_DECR_Tbx.TabIndex = 17;
            // 
            // LOADFILE_Button
            // 
            this.LOADFILE_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LOADFILE_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.LOADFILE_Button.Location = new System.Drawing.Point(34, 454);
            this.LOADFILE_Button.Margin = new System.Windows.Forms.Padding(4);
            this.LOADFILE_Button.Name = "LOADFILE_Button";
            this.LOADFILE_Button.Size = new System.Drawing.Size(175, 44);
            this.LOADFILE_Button.TabIndex = 18;
            this.LOADFILE_Button.Text = "LOAD FILE";
            this.LOADFILE_Button.UseVisualStyleBackColor = false;
            this.LOADFILE_Button.Click += new System.EventHandler(this.LOADFILE_Button_Click);
            // 
            // SAVEFILE_Button
            // 
            this.SAVEFILE_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SAVEFILE_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SAVEFILE_Button.Location = new System.Drawing.Point(268, 452);
            this.SAVEFILE_Button.Margin = new System.Windows.Forms.Padding(4);
            this.SAVEFILE_Button.Name = "SAVEFILE_Button";
            this.SAVEFILE_Button.Size = new System.Drawing.Size(165, 46);
            this.SAVEFILE_Button.TabIndex = 19;
            this.SAVEFILE_Button.Text = "SAVE FILE";
            this.SAVEFILE_Button.UseVisualStyleBackColor = false;
            this.SAVEFILE_Button.Click += new System.EventHandler(this.SAVEFILE_Button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbCrypt);
            this.panel1.Controls.Add(this.rdbDecrypt);
            this.panel1.Location = new System.Drawing.Point(441, 242);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 97);
            this.panel1.TabIndex = 20;
            // 
            // rdbCrypt
            // 
            this.rdbCrypt.AutoSize = true;
            this.rdbCrypt.Location = new System.Drawing.Point(48, 15);
            this.rdbCrypt.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCrypt.Name = "rdbCrypt";
            this.rdbCrypt.Size = new System.Drawing.Size(75, 21);
            this.rdbCrypt.TabIndex = 8;
            this.rdbCrypt.TabStop = true;
            this.rdbCrypt.Text = "CRYPT";
            this.rdbCrypt.UseVisualStyleBackColor = true;
            // 
            // rdbDecrypt
            // 
            this.rdbDecrypt.AutoSize = true;
            this.rdbDecrypt.Location = new System.Drawing.Point(48, 62);
            this.rdbDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDecrypt.Name = "rdbDecrypt";
            this.rdbDecrypt.Size = new System.Drawing.Size(94, 21);
            this.rdbDecrypt.TabIndex = 9;
            this.rdbDecrypt.TabStop = true;
            this.rdbDecrypt.Text = "DECRYPT";
            this.rdbDecrypt.UseVisualStyleBackColor = true;
            // 
            // cRdCr_Button
            // 
            this.cRdCr_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cRdCr_Button.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.cRdCr_Button.Location = new System.Drawing.Point(441, 366);
            this.cRdCr_Button.Margin = new System.Windows.Forms.Padding(4);
            this.cRdCr_Button.Name = "cRdCr_Button";
            this.cRdCr_Button.Size = new System.Drawing.Size(166, 52);
            this.cRdCr_Button.TabIndex = 21;
            this.cRdCr_Button.Text = "CRYPT/DECRYPT";
            this.cRdCr_Button.UseVisualStyleBackColor = false;
            this.cRdCr_Button.Click += new System.EventHandler(this.cRdCr_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(484, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "UNESITE 64-BIT KLJUC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "A5/2 ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 51);
            this.panel2.TabIndex = 66;
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
            this.btnMinimize.Location = new System.Drawing.Point(568, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 32);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
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
            this.btnExit.Location = new System.Drawing.Point(625, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // A5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(715, 513);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cRdCr_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SAVEFILE_Button);
            this.Controls.Add(this.LOADFILE_Button);
            this.Controls.Add(this.TEXT_CR_DECR_Tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SetDefault);
            this.Controls.Add(this.SetKey);
            this.Controls.Add(this.KEY_Tbx);
            this.Name = "A5Form";
            this.Text = "A5Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SetDefault;
        private System.Windows.Forms.Button SetKey;
        private System.Windows.Forms.TextBox KEY_Tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TEXT_CR_DECR_Tbx;
        private System.Windows.Forms.Button LOADFILE_Button;
        private System.Windows.Forms.Button SAVEFILE_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbCrypt;
        private System.Windows.Forms.RadioButton rdbDecrypt;
        private System.Windows.Forms.Button cRdCr_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
    }
}