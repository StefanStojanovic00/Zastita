using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ZastitaS
{
    public partial class MDForm : Form
    {
        public MDForm()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MD5 obj = new MD5();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult dr = openFileDialog1.ShowDialog();
            string Naziv;
            if (dr == DialogResult.OK)
            {
                string putanja = openFileDialog1.FileName;
                Naziv = Path.GetFileName(putanja);

                    byte[] bajtoviFajla = new byte[File.ReadAllBytes(putanja).Length];
                    bajtoviFajla = File.ReadAllBytes(putanja);
                    string permutacijaX = perX.Text;
                    string permutacijaY = perY.Text;
                    int dimenzijaX = Convert.ToInt32(dimX.Text);
                    int dimenzijaY = Convert.ToInt32(dimY.Text);
                    string bajtoviString = System.Text.Encoding.UTF8.GetString(bajtoviFajla);
                    int faktor;
                    if (dimenzijaX > dimenzijaY)
                        faktor = dimenzijaX;
                    else
                        faktor = dimenzijaY;
                    if (bajtoviString.Length < dimenzijaX - dimenzijaY)
                    {
                        MessageBox.Show("Potrebno je uneti veci fajl");
                    }
                    else
                    {
                        char[,] transponozicionaMatrica = new char[dimenzijaX, dimenzijaY];
                        for (int i = 0; i < dimenzijaX; i++)
                        {
                            for (int j = 0; j < dimenzijaY; j++)
                            {
                                transponozicionaMatrica[i, j] = bajtoviString[dimenzijaY * i + j];
                            }
                        }
                        string stringToHash = "";
                        for (int i = 0; i < dimenzijaX; i++)
                        {
                            for (int j = 0; j < dimenzijaY; j++)
                            {
                                stringToHash += transponozicionaMatrica[i, j];
                            }
                        }
                        string hesovanString = obj.MD5Hash(stringToHash);
                        string zaslanjeString = obj.DTCrypt(transponozicionaMatrica, permutacijaX, permutacijaY, dimenzijaX, dimenzijaY, Naziv);
                        hashList.Items.Add(hesovanString);
                        string Hashkod;
                        string Textfajla;
                        Hashkod = hesovanString;
                        Textfajla = File.ReadAllText(putanja);
                       

                    }

                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
