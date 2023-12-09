
namespace ZastitaS
{
    partial class RC
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
            this.btnDekripcija = new System.Windows.Forms.Button();
            this.btnEnkripcija = new System.Windows.Forms.Button();
            this.btnSetOutput = new System.Windows.Forms.Button();
            this.btnSetInput = new System.Windows.Forms.Button();
            this.btnFSW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDBMP = new System.Windows.Forms.Button();
            this.btnEBMP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.numUD = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDekripcija
            // 
            this.btnDekripcija.Location = new System.Drawing.Point(302, 235);
            this.btnDekripcija.Margin = new System.Windows.Forms.Padding(4);
            this.btnDekripcija.Name = "btnDekripcija";
            this.btnDekripcija.Size = new System.Drawing.Size(148, 59);
            this.btnDekripcija.TabIndex = 18;
            this.btnDekripcija.Text = "Decryption";
            this.btnDekripcija.UseVisualStyleBackColor = true;
            this.btnDekripcija.Click += new System.EventHandler(this.btnDekripcija_Click);
            // 
            // btnEnkripcija
            // 
            this.btnEnkripcija.Location = new System.Drawing.Point(302, 156);
            this.btnEnkripcija.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnkripcija.Name = "btnEnkripcija";
            this.btnEnkripcija.Size = new System.Drawing.Size(148, 46);
            this.btnEnkripcija.TabIndex = 17;
            this.btnEnkripcija.Text = "Encryption";
            this.btnEnkripcija.UseVisualStyleBackColor = true;
            this.btnEnkripcija.Click += new System.EventHandler(this.btnEnkripcija_Click);
            // 
            // btnSetOutput
            // 
            this.btnSetOutput.Location = new System.Drawing.Point(569, 235);
            this.btnSetOutput.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetOutput.Name = "btnSetOutput";
            this.btnSetOutput.Size = new System.Drawing.Size(161, 59);
            this.btnSetOutput.TabIndex = 16;
            this.btnSetOutput.Text = "Set Output Folder";
            this.btnSetOutput.UseVisualStyleBackColor = true;
            this.btnSetOutput.Click += new System.EventHandler(this.btnSetOutput_Click);
            // 
            // btnSetInput
            // 
            this.btnSetInput.Location = new System.Drawing.Point(569, 156);
            this.btnSetInput.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetInput.Name = "btnSetInput";
            this.btnSetInput.Size = new System.Drawing.Size(161, 46);
            this.btnSetInput.TabIndex = 15;
            this.btnSetInput.Text = "Set Input Folder";
            this.btnSetInput.UseVisualStyleBackColor = true;
            this.btnSetInput.Click += new System.EventHandler(this.btnSetInput_Click);
            // 
            // btnFSW
            // 
            this.btnFSW.BackColor = System.Drawing.Color.Red;
            this.btnFSW.Location = new System.Drawing.Point(429, 71);
            this.btnFSW.Margin = new System.Windows.Forms.Padding(4);
            this.btnFSW.Name = "btnFSW";
            this.btnFSW.Size = new System.Drawing.Size(209, 44);
            this.btnFSW.TabIndex = 20;
            this.btnFSW.Text = "File System Watcher: OFF";
            this.btnFSW.UseVisualStyleBackColor = false;
            this.btnFSW.Click += new System.EventHandler(this.btnFSW_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(66, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Railfence cipher ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDBMP
            // 
            this.btnDBMP.Location = new System.Drawing.Point(569, 312);
            this.btnDBMP.Margin = new System.Windows.Forms.Padding(4);
            this.btnDBMP.Name = "btnDBMP";
            this.btnDBMP.Size = new System.Drawing.Size(161, 59);
            this.btnDBMP.TabIndex = 24;
            this.btnDBMP.Text = "Decryption BMP";
            this.btnDBMP.UseVisualStyleBackColor = true;
            // 
            // btnEBMP
            // 
            this.btnEBMP.Location = new System.Drawing.Point(302, 312);
            this.btnEBMP.Margin = new System.Windows.Forms.Padding(4);
            this.btnEBMP.Name = "btnEBMP";
            this.btnEBMP.Size = new System.Drawing.Size(148, 59);
            this.btnEBMP.TabIndex = 23;
            this.btnEBMP.Text = "Encryption BMP";
            this.btnEBMP.UseVisualStyleBackColor = true;
            this.btnEBMP.Click += new System.EventHandler(this.btnEBMP_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(-9, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 56);
            this.panel2.TabIndex = 25;
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
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // numUD
            // 
            this.numUD.Location = new System.Drawing.Point(71, 219);
            this.numUD.Name = "numUD";
            this.numUD.Size = new System.Drawing.Size(120, 22);
            this.numUD.TabIndex = 27;
            // 
            // RC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numUD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDBMP);
            this.Controls.Add(this.btnEBMP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFSW);
            this.Controls.Add(this.btnDekripcija);
            this.Controls.Add(this.btnEnkripcija);
            this.Controls.Add(this.btnSetOutput);
            this.Controls.Add(this.btnSetInput);
            this.Name = "RC";
            this.Text = "RC";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDekripcija;
        private System.Windows.Forms.Button btnEnkripcija;
        private System.Windows.Forms.Button btnSetOutput;
        private System.Windows.Forms.Button btnSetInput;
        private System.Windows.Forms.Button btnFSW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDBMP;
        private System.Windows.Forms.Button btnEBMP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown numUD;
    }
}