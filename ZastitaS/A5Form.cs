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
    public partial class A5Form : Form
    {
        bool tmp_flag = true;
        private FolderBrowserDialog fbdChooseFolder;
        string destinationBrowseFolder;

        string key;
        bool keySet;

        byte[] _ucitanFajl;

        private A52 a52;
        public A5Form()
        {
            InitializeComponent();
            destinationBrowseFolder = @"C:\Users\SS\source\repos\ZastitaS\ZastitaS\bin\Fajlovi\A52";
            this.fbdChooseFolder = new FolderBrowserDialog();
            keySet = false;
            InitializeComponent();
        }

        private void cRdCr_Button_Click(object sender, EventArgs e)
        {
            if (!keySet)
            {
                MessageBox.Show("Please set the key!",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            if (this.TEXT_CR_DECR_Tbx.Text.Length == 0)
            {
                MessageBox.Show("Please input the text for crypting.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }

            if (!RadioButtonsChecked())
            {
                MessageBox.Show("Please check radio buttons.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            SetTmpFlag();

            this.TEXT_CR_DECR_Tbx.Text = keySet ? tmp_flag ? a52.Crypt(this.TEXT_CR_DECR_Tbx.Text)
                                                    : a52.DeCrypt(this.TEXT_CR_DECR_Tbx.Text) : "";
        }

        private void LOADFILE_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text|*.txt|All|*.*";
            dialog.InitialDirectory = @"C:\Users\SS\source\repos\ZastitaS\ZastitaS\bin\Fajlovi\A52";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String putanja = dialog.FileName;
                FileStream fajlZaCitanje = null;
                try
                {
                    fajlZaCitanje = new FileStream(putanja, FileMode.Open);
                    int velicina = (int)fajlZaCitanje.Length;
                    byte[] nizBajtova = new byte[velicina];
                    fajlZaCitanje.Read(nizBajtova, 0, velicina);
                    _ucitanFajl = nizBajtova;
                    TEXT_CR_DECR_Tbx.Text = Encoding.ASCII.GetString(_ucitanFajl);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString(),
                "Error",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                }
                finally
                {
                    fajlZaCitanje.Close();
                }
                return;
            }
            MessageBox.Show("TXT FILE NOT SELECTED.",
                         "Notification",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);

        }

        private void SAVEFILE_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog folderDialog = new SaveFileDialog();
            folderDialog.Filter = "Text|*.txt|All|*.*";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fajlZaUpis = null;
                try
                {
                    byte[] tekstZaUpis = new byte[this.TEXT_CR_DECR_Tbx.TextLength];
                    tekstZaUpis = Encoding.UTF8.GetBytes(this.TEXT_CR_DECR_Tbx.Text);

                    fajlZaUpis = new FileStream(folderDialog.FileName, FileMode.Create);
                    fajlZaUpis.Write(tekstZaUpis, 0, tekstZaUpis.Length);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    fajlZaUpis.Close();
                }
                return;
            }
            MessageBox.Show("FOLDER ISN'T SELECTED.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

        }
        private bool RadioButtonsChecked()
        {
           
            if (rdbCrypt.Checked == true || rdbDecrypt.Checked == true)
                return true;
            else
                return false;
        }
        private void SetTmpFlag()
        {
           
           if (rdbCrypt.Checked == true)
                tmp_flag = true;
            else
                tmp_flag = false;
        }

        private void SetKey_Click(object sender, EventArgs e)
        {
            
            if (KEY_Tbx.Text.Length != 64)
            {
                MessageBox.Show("YOU DIDN'T INPUT 64 BITS.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            this.key = KEY_Tbx.Text;
            keySet = true;
            a52 = new A52(this.key);

        }

        private void SetDefault_Click(object sender, EventArgs e)
        {
            a52 = new A52();
            this.key = a52.Key;
            this.KEY_Tbx.Text = this.key;
            keySet = true;
            MessageBox.Show(this.key);
            
        }

     
    }
}
