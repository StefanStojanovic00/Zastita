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
    public partial class RC : Form
    {
        public string StartFolder;
        public string OutputFolder;
        public string DebugFolder = @"C:\Users\SS\source\repos\ZastitaS\ZastitaS\bin\Fajlovi\zaenkripciju";
        FileSystemWatcher fsw = new FileSystemWatcher("..\\Fajlovi\\zaenkripciju\\");
        RailfenceCipher RailC = new RailfenceCipher();
        private OpenFileDialog openFileDialog1;
        public bool Initialized { get; set; }

        public RC()
        {
            InitializeComponent();
            Initialized = false;
            fsw.EnableRaisingEvents = false;            

        }

        private void btnEnkripcija_Click(object sender, EventArgs e)
        {
            if (OutputFolder != null)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))

                    {
                        StartFolder = Directory.GetParent(ofd.FileName).FullName;
                        Kodiranje(ofd.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Izaberite odredisni folder!!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnDekripcija_Click(object sender, EventArgs e)
        {

            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                int kljuc1; int kljuc2 = 0;
                string file = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                Directory.SetCurrentDirectory(DebugFolder);
                StreamReader fs = new StreamReader("Enkripcija.txt");
                while (true)
                {
                    string p = "rca";
                    string algoritam;
                    string line = fs.ReadLine();
                    if (line.Equals(file + ".txt") == true)
                    {
                        if (p.Equals(algoritam = fs.ReadLine()))
                        {
                            kljuc1 = Convert.ToInt32(fs.ReadLine());
                            kljuc2 = Convert.ToInt32(fs.ReadLine());
                        }
                        else { kljuc1 = Convert.ToInt32(fs.ReadLine()); }
                        Directory.SetCurrentDirectory(System.IO.Path.GetDirectoryName(openFileDialog1.FileName));
                        byte[] bajtovi = File.ReadAllBytes(line);
                        byte[] noviniz = new byte[bajtovi.Length];
                      
                            var bits = new BitArray(bajtovi);
                            noviniz = RailC.Dekripcija(bits, ShiftovanjeKljuca(kljuc1, false));
                        
                        upisidek(noviniz);
                        break;
                    }
                }
            }
        }

        private void btnSetInput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    if (fbd.SelectedPath.CompareTo(OutputFolder) == 0)
                    {
                        MessageBox.Show("Izvorni i odredisni folder ne mogu biti isti!", "Greska sa ulazom!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    fsw.Path = fbd.SelectedPath;
                    StartFolder = fsw.Path;
                    Podesavanja();
                }
            }
        }

        private void btnSetOutput_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    if (fbd.SelectedPath.CompareTo(fsw.Path) == 0)
                    {
                        MessageBox.Show("Odredisni folder ne moze biti isti kao izvorni!", "Postoji greska u ulazu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    OutputFolder = fbd.SelectedPath;

                    Podesavanja();
                }
            }
        }


        private void btnFSW_Click(object sender, EventArgs e)
        {
            if (!fsw.EnableRaisingEvents && (string.IsNullOrEmpty(fsw.Path) || fsw.Path.CompareTo(".") == 0))
            {
                MessageBox.Show("Izaberite izvorni folder!!", "Greska!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            fsw.EnableRaisingEvents = !fsw.EnableRaisingEvents;
            btnFSW.BackColor = Color.Green;
            Podesavanja();
        }
        private void Evidencija(string filename)
        {
            Directory.SetCurrentDirectory(DebugFolder);
            File.AppendAllText(DebugFolder + "/Enkripcija.txt", filename + ".txt" + Environment.NewLine + "rfc" + Environment.NewLine + ShiftovanjeKljuca(RailC.Kljuc, true).ToString() + Environment.NewLine);
            
           

        }
        static void upisidek(byte[] poruka)
        {
            SaveFileDialog sc = new SaveFileDialog();
            sc.Filter = "Text Document|*.txt";
            if (sc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllBytes(sc.FileName, poruka);

            }
        }
        private void Kodiranje(string filename)
        {


            string file = Path.GetFileNameWithoutExtension(filename);

            Directory.SetCurrentDirectory(StartFolder);
            FileStream fs = new FileStream(file + ".txt", FileMode.Open, FileAccess.Read); ;
            byte[] bajtovi = File.ReadAllBytes(file + ".txt");
            var bits = new BitArray(bajtovi);
            byte[] noviniz = new byte[bajtovi.Length];
           
           
                RailC.Kljuc = Convert.ToInt32(numUD.Value);

                noviniz = RailC.Enkripcija(bits, Convert.ToInt32(numUD.Value));

           
            fsw.EnableRaisingEvents = false;
            Directory.SetCurrentDirectory(OutputFolder);
            String fff = "File" + $@"{DateTime.Now.Ticks}";
            fs = File.Create(fff + ".txt");
            fs.Close();
            File.WriteAllBytes(fff + ".txt", noviniz);
            fs.Close();
            Evidencija(fff);
        }
        private void Podesavanja()
        {
            btnFSW.BackColor = fsw.EnableRaisingEvents ? Color.Green : Color.Red;
            btnFSW.Text = fsw.EnableRaisingEvents ? "File System Watcher: ON" : "File System Watcher: OFF";
            btnFSW.Enabled = !string.IsNullOrEmpty(OutputFolder) && !string.IsNullOrEmpty(fsw.Path) && fsw.Path.CompareTo(".") != 0;
            btnDekripcija.Enabled = (!fsw.EnableRaisingEvents);
            btnEnkripcija.Enabled = !fsw.EnableRaisingEvents && !string.IsNullOrEmpty(OutputFolder);
            btnSetOutput.Enabled = !fsw.EnableRaisingEvents;
            btnSetInput.Enabled = !fsw.EnableRaisingEvents;
            btnEBMP.Enabled= !fsw.EnableRaisingEvents;
            btnDBMP.Enabled = !fsw.EnableRaisingEvents;
        }
        private void fsw_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Kodiranje(e.FullPath);
        }



        public int ShiftovanjeKljuca(int kljuc, bool smer)
        {
            byte pom = 2;
            if (smer == true) return kljuc << pom;
            else return kljuc >> pom;
        }

        private void fsw_Created(object sender, FileSystemEventArgs e)
        {
            Kodiranje(e.FullPath);
        }

        public void EncrypteBMPFile(string inputName,string outputName,int kljuc)
        {
            FileStream input = new FileStream(inputName, FileMode.Open, FileAccess.Read);
            byte[] header = new byte[54];
            int count = input.Read(header, 0, 54);
            FileStream output = new FileStream(outputName, FileMode.Create, FileAccess.Write);
            output.Write(header, 0, 54);
            byte[] data = new byte[512];
            var bit = new BitArray(data);
            RcInterface rcd = new RcInterface(kljuc);
            while (input.Read(data,0,512)>0)
            {
                byte[] enc = rcd.Encrypt(bit,kljuc);
                output.Write(enc,0,512);
            }

            output.Close();
            input.Close();
        }

        public void DecrypteBMPFile(string inputName, string outputName, int kljuc)
        {
            FileStream input = new FileStream(inputName, FileMode.Open, FileAccess.Read);
            byte[] header = new byte[54];
            int count = input.Read(header, 0, 54);
            FileStream output = new FileStream(outputName, FileMode.Create, FileAccess.Write);
            output.Write(header, 0, 54);
            byte[] data = new byte[512];
            var bit = new BitArray(data);
            RcInterface rcd = new RcInterface(kljuc);
         

            while (input.Read(data, 0, 512) > 0)
            {
                byte[] enc = rcd.Decrypt(bit, kljuc);
                output.Write(enc, 0, 512);
            }

            output.Close();
            input.Close();
        }

        private void btnEBMP_Click(object sender, EventArgs e)
        {


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
