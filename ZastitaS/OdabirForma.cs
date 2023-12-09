using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZastitaS
{
    public partial class OdabirForma : Form
    {
        Algoritam algoritam;
        public OdabirForma()
        {
            InitializeComponent();
            //labela, groupbox, dugme centrirani
            label1.Left = (this.ClientSize.Width - label1.Size.Width) / 2;
            panel1.Left = (this.ClientSize.Width - panel1.Size.Width) / 2;
            btnDalje.Left = (this.ClientSize.Width - btnDalje.Size.Width) / 2;
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (rbtnXTea.Checked)
            {
                algoritam = new XTea();
                Form1 xtea = new Form1(algoritam);
                xtea.ShowDialog();
               
            }
            if (rbtnRC.Checked)
            {
                
                RC rcA = new RC();
                rcA.ShowDialog();
            }
            if (rbtnA5.Checked)
            {
               
                A5Form a5 = new A5Form();
                a5.ShowDialog();
            }
            if (rbtnMD5.Checked)
            {
                
                MDForm md = new MDForm();
                md.ShowDialog();
            }
        }

           private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

