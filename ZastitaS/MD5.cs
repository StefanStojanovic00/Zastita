using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Collections;

namespace ZastitaS
{
    class MD5
    {
        public string MD5Hash(byte[] bajtovi)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(bajtovi);
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        public string MD5Hash(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();


            md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(text));


            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
        public string DTCrypt(char[,] transpozicionaMatrica, string permX, string permY, int x, int y, string fileName)
        {
            string[] permutacijeX = permX.Split(',');
            string[] permutacijeY = permY.Split(',');

            char[,] transpozicionaPoX = new char[x, y];
            for (int i = 0; i < permutacijeX.Length; i++)
            {
                int vrednostPermX = Convert.ToInt32(permutacijeX[i]);
                for (int j = 0; j < y; j++)
                {
                    transpozicionaPoX[i, j] = transpozicionaMatrica[vrednostPermX, j];
                }
            }
            char[,] transpozicionaPoY = new char[x, y];
            for (int i = 0; i < permutacijeY.Length; i++)
            {
                int vrednostPermY = Convert.ToInt32(permutacijeY[i]);
                for (int j = 0; j < x; j++)
                {
                    transpozicionaPoY[j, i] = transpozicionaPoX[j, vrednostPermY];
                }
            }
            string krajnjiString = "";
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    krajnjiString += transpozicionaPoY[i, j];
                }
            }


            string imeFajla = fileName;
            imeFajla = imeFajla.Replace(@"\", string.Empty);
            char[] charToTrim = { 'C', ':', '.' };
            string trimovanoimefajla = imeFajla.Trim(charToTrim);
            string ime = @"C:\Users\SS\source\repos\ZastitaS\ZastitaS\bin\Fajlovi\md5\" + "DT" + trimovanoimefajla;

            if (File.Exists(ime))
                File.Delete(ime);
            string tekstFajla = "";
            tekstFajla += Convert.ToString(x) + "," + Convert.ToString(y) + "," + permX + "," + permY;

            using (StreamWriter sw = File.CreateText(ime))
            {
                sw.WriteLine(tekstFajla);
            }



            return krajnjiString;

        }
        public string DTDecrypt(string kriptovaniStr, string podaci)
        {
            string[] splitPodaci = podaci.Split(',');
            int x = Convert.ToInt32(splitPodaci[0]);
            int y = Convert.ToInt32(splitPodaci[1]);
            string permutacijeX = "";
            string permutacijeY = "";
            int faktor;
            for (int i = 2; i < x + 2; i++)
            {
                permutacijeX += splitPodaci[i];
            }
            for (int i = x + 2; i < x + 2 + y; i++)
            {
                permutacijeY += splitPodaci[i];
            }
            if (x > y)
                faktor = x;
            else
                faktor = y;
            int k = 0;
            char[,] transpozicionaMatrica = new char[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    transpozicionaMatrica[i, j] = kriptovaniStr[k];
                    k++;
                }
            }

            char[,] transpozicionaPoY = new char[x, y];
            for (int i = 0; i < permutacijeY.Length; i++)
            {
                int vrednostPerY = Convert.ToInt32(permutacijeY[i].ToString());
                for (int j = 0; j < x; j++)
                {
                    transpozicionaPoY[j, vrednostPerY] = transpozicionaMatrica[j, i];
                }
            }
            char[,] transpozicionaPoX = new char[x, y];
            for (int i = 0; i < permutacijeX.Length; i++)
            {
                int vrednostPerX = System.Convert.ToInt32(permutacijeX[i].ToString());
                for (int j = 0; j < y; j++)
                {
                    transpozicionaPoX[vrednostPerX, j] = transpozicionaPoY[i, j];
                }
            }

            string dekriptovaniString = "";

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    dekriptovaniString += transpozicionaPoX[i, j];
                }
            }

            return dekriptovaniString;




        }
    }
}
