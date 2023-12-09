
namespace ZastitaS
{
    partial class MDForm
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.hashList = new System.Windows.Forms.ListBox();
            this.perY = new System.Windows.Forms.TextBox();
            this.perX = new System.Windows.Forms.TextBox();
            this.dimY = new System.Windows.Forms.TextBox();
            this.dimX = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(293, 325);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(201, 28);
            this.btnUpload.TabIndex = 11;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // hashList
            // 
            this.hashList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hashList.FormattingEnabled = true;
            this.hashList.ItemHeight = 16;
            this.hashList.Location = new System.Drawing.Point(102, 165);
            this.hashList.Margin = new System.Windows.Forms.Padding(4);
            this.hashList.Name = "hashList";
            this.hashList.Size = new System.Drawing.Size(600, 116);
            this.hashList.TabIndex = 10;
            // 
            // perY
            // 
            this.perY.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.perY.Location = new System.Drawing.Point(628, 97);
            this.perY.Margin = new System.Windows.Forms.Padding(4);
            this.perY.Name = "perY";
            this.perY.Size = new System.Drawing.Size(132, 22);
            this.perY.TabIndex = 9;
            this.perY.Text = "1,2,1";
            // 
            // perX
            // 
            this.perX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.perX.Location = new System.Drawing.Point(409, 97);
            this.perX.Margin = new System.Windows.Forms.Padding(4);
            this.perX.Name = "perX";
            this.perX.Size = new System.Drawing.Size(132, 22);
            this.perX.TabIndex = 8;
            this.perX.Text = "3,0,1,2";
            // 
            // dimY
            // 
            this.dimY.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dimY.Location = new System.Drawing.Point(218, 97);
            this.dimY.Margin = new System.Windows.Forms.Padding(4);
            this.dimY.Name = "dimY";
            this.dimY.Size = new System.Drawing.Size(132, 22);
            this.dimY.TabIndex = 7;
            this.dimY.Text = "4";
            // 
            // dimX
            // 
            this.dimX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dimX.Location = new System.Drawing.Point(41, 97);
            this.dimX.Margin = new System.Windows.Forms.Padding(4);
            this.dimX.Name = "dimX";
            this.dimX.Size = new System.Drawing.Size(123, 22);
            this.dimX.TabIndex = 6;
            this.dimX.Text = "5";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(27, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 56);
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
            this.btnMinimize.Location = new System.Drawing.Point(639, 11);
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
            this.btnExit.Location = new System.Drawing.Point(704, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.hashList);
            this.Controls.Add(this.perY);
            this.Controls.Add(this.perX);
            this.Controls.Add(this.dimY);
            this.Controls.Add(this.dimX);
            this.Name = "MDForm";
            this.Text = "MDForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ListBox hashList;
        private System.Windows.Forms.TextBox perY;
        private System.Windows.Forms.TextBox perX;
        private System.Windows.Forms.TextBox dimY;
        private System.Windows.Forms.TextBox dimX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
    }
}