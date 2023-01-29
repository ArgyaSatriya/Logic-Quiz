using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Threading.Tasks.Sources;

namespace LogicQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Home();
            //Sedekah();
        }

        static void Home()
        {
            Console.Clear();
            Console.WriteLine("Pilih MENU.");
            Console.WriteLine("===============================");
            Console.WriteLine("[1] Keliling Lingkaran");
            Console.WriteLine("[2] Luas Lingkaran");
            Console.WriteLine("[3] Luas Persegi");
            Console.WriteLine("[4] Keliling Persegi");
            Console.WriteLine("[5] Cek Modulus");
            Console.WriteLine("[6] Putung Rokok");
            Console.WriteLine("[7] Beautiful Day");
            Console.WriteLine("[8] Max-Min Sum");
            Console.WriteLine("[9] Birthday Cake Candles");
            Console.WriteLine("[10] Time Conversion");
            Console.WriteLine("=================================");
            Console.Write("Pilih Program : ");

            int Pilih = int.Parse(Console.ReadLine());
            switch (Pilih)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Penghitungan Keliling Lingkaran");
                    Console.WriteLine();
                    Console.Write("Nilai r : ");
                    double r = double.Parse(Console.ReadLine());
                    double Keliling = KelilingLingkaran(r);
                    Console.WriteLine("Keliling Lingkaran :" + String.Format("{0:0.00}", Keliling));
                    Console.ReadLine();
                    Home();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Penghitungan Luas Lingkaran");
                    Console.WriteLine();
                    Console.Write("Nilai r : ");
                    double c = double.Parse(Console.ReadLine());
                    double Luas = LuasLingkaran(c);
                    Console.WriteLine("Luas Lingkaran :" + String.Format("{0:0.00}", Luas));
                    Console.ReadLine();
                    Home();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Penghitungan Luas Persegi");
                    Console.WriteLine();
                    Console.Write("Nilai Panjang s : ");
                    int s = int.Parse(Console.ReadLine());
                    double L = LuasPersegi(s);
                    Console.WriteLine("Luas Persegi :" + L);
                    Console.ReadLine();
                    Home();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Penghitungan Keliling Persegi");
                    Console.WriteLine();
                    Console.Write("Nilai Panjang s : ");
                    int sisi = int.Parse(Console.ReadLine());
                    int K = KelilingPersegi(sisi);
                    Console.WriteLine("Keliling Persegi :" + K);
                    Console.ReadLine();
                    Home();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Pengecekan Nilai Modulus");
                    Console.WriteLine();
                    CekMod();
                    Console.ReadLine();
                    Home();
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Pengecekan Putung Rokok");
                    Console.WriteLine();
                    Console.WriteLine("Masukkan Putung Rokok yang di Peroleh :");
                    int x = int.Parse(Console.ReadLine());
                    int hasil = Pemulung(x);
                    Console.WriteLine("Rokok yang berhasil di rangkai : " + hasil);
                    Console.WriteLine("Hasil Penjulan Rokok : " + (hasil * 500));
                    Console.ReadLine();
                    Home();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Pengecekan Beautiful Day");
                    Console.WriteLine();
                    Console.Write("Masukkan Tanggal Awal :");
                    int i = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan Tanggal Akhir :");
                    int j = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan Pembagi : ");
                    int k = int.Parse(Console.ReadLine());
                    beautifulDays(i, j, k);
                    //Console.WriteLine("Berapa Hari : " + result);
                    Console.ReadLine();
                    Home();
                    break;
                case 8:
                    Console.Clear();
                    Console.WriteLine("Pengecekan Grade Nilai");
                    Console.WriteLine();
                    Console.Write("Masukkan Nilai Yang didapatkan :");
                    int n = int.Parse(Console.ReadLine());
                    gradeNilai(n);
                    //Console.WriteLine("Nilai yang ditapatkan: " + Nilai);
                    Console.ReadLine();
                    Home();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("Pengecekan Poin Pulsa");
                    Console.WriteLine();
                    Console.Write("Membeli Pulsa sebesar :");
                    int pulsa = int.Parse(Console.ReadLine());
                    int poin = pulsaPoit(pulsa);
                    Console.WriteLine("Poin yang di dapatkan: " + poin);
                    Console.ReadLine();
                    Home();
                    break;
                case 10:
                    Console.Clear();
                    Console.WriteLine("Pengecekan Huruf Besar");
                    Console.WriteLine();
                    Console.Write("Masukkan Kata :");
                    string kata =Console.ReadLine();
                    Console.WriteLine("Poin yang di dapatkan: " + upperCase(kata));
                    Console.ReadLine();
                    Home();
                    break;
                case 11:
                    Console.Clear();
                    Console.WriteLine("Invoice Penjualan : ");
                    Console.WriteLine();
                    Console.Write("Batas Atas :");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Batas Bawah :");
                    int b = int.Parse(Console.ReadLine());
                    invoicePenjualan(a,b);
                    Console.ReadLine();
                    Home();
                    break;
                case 12:
                    Console.Clear();
                    Console.WriteLine("Remove Nilai");
                    Console.WriteLine();
                    Keranjang();
                    Console.ReadLine();
                    Home();
                    break;
            }

        }

        /*static double Lingkaran(double r)
        {
            string x = Console.ReadLine().ToLower();
            double phi = (22 / 7);
            double k = 0;
            double l = 0;
            if (x == "keliling")
            {
                k = 2 * phi * r;
            }
            else if(x == "luas") 
            {
                l = phi*r*r;
            }
            return (k,l) ;
        }*/

        static double KelilingLingkaran(double r)
        {
            double phi = (3.14);
            return 2 * (phi * r);
        }

        static double LuasLingkaran(double r)
        {
            double phi = (3.14);
            return phi * r * r;
        }

        static int LuasPersegi(int s)
        {
            return s * s;
        }

        static int KelilingPersegi(int s)
        {
            return 4 * s;
        }

        static void CekMod()
        {
            Console.Write("Masukkan Nilai Angka :");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Nilai Pembagi :");
            int y = int.Parse(Console.ReadLine());

            if (x % y == 0)
            {
                Console.WriteLine($"angka {x}%{y} adalah 0");
            }
            else
            {
                Console.WriteLine($"angka {x}%{y} adalah {x % y}");
            }
        }

        static int Pemulung(int x)
        {
            int a = x % 8;
            int b = (x - a) / 8;
            return b;
        }

        public static void beautifulDays(int i, int j, int k)
        {
            int c = 0;
            List<int> r = new List<int>();
            for (int x = i; x <= j; x++)
            {
                char[] arr = x.ToString().ToCharArray();
                Array.Reverse(arr);
                int d = x - int.Parse(new string(arr));
                if (d % k == 0)
                {
                    c++;
                    r.Add(x);
                    //Console.WriteLine("Tanggal yang cocok : " + x);
                }
            }
            Console.WriteLine("Tanggal Hasil: "+ String.Join(", ",r));
        }

        static int gradeNilai(int n)
        {
            int m = 0;
            if (n >= 90)
            {
                Console.WriteLine("Grade A");
                m += n;
            }
            else if (n < 90 && n >= 70)
            {
                Console.WriteLine("Grade B");
                m += n;
            }
            else if (n < 70 && n >= 50)
            {
                Console.WriteLine("Grade C");
                m += n;
            }
            else
            {
                Console.WriteLine("Grade E");
                m += n;
            }
            return m;
        }

        static int pulsaPoit(int pulsa)
        {
            int poin = 0;
            if (pulsa >= 100000)
            {
                poin += 800;
            }
            else if(pulsa >= 50000)
            {
                poin+= 400;
            }
            else if (pulsa >= 25000)
            {
                poin += 200;
            }
            else if (pulsa>=10000)
            {
                poin += 80;
            }
            return poin;
        }

        static void grabFood(int belanja,int jarak,string co)
        {
            string code = "JKTOVO";
            int ongkir = jarak * 1000;
            double diskon = belanja * 0.4;
            if(belanja >= 30000 && co == code)
            {
                Console.WriteLine("Belanja : " + belanja);
                Console.WriteLine("Diskon 40% : " + diskon);
                Console.WriteLine("Ongkir : " + ongkir);
                Console.WriteLine("Total Belanja : " + ((belanja+ongkir)-diskon));
            }
        }

        static int upperCase(string s)
        {
            int c = 0;
            //char[] arr= s.ToCharArray();
            foreach(char i in s)
            {
                if(char.IsUpper(i))
                {
                    c++;
                }
            }
            return c;
        }

        static void invoicePenjualan(int a,int b)
        {
            string awal = "XA";
            DateTime dateTime = DateTime.Now;
            for (int i = a; i <= b; i++)
            {
                string nomer = i.ToString().PadLeft(5, '0');
                Console.WriteLine(awal + "-" + dateTime.ToString("ddMMyyyy") + "-" + nomer);
            }
        }

        static void Keranjang()
        {
            List<int> krj = new List<int>() { 14,0,10};
            Console.WriteLine("Nilai Awal : "+String.Join(",", krj));
            Console.Write("Hapus Nilai : ");
            krj.Remove(int.Parse(Console.ReadLine()));
            Console.WriteLine("Nilai Setelah Remove :"+ String.Join(",", krj));
            Console.WriteLine("Hasil Penjumlahan : "+krj.Sum());
        }

        static void Sedekah()
        {
            //Console.WriteLine("Ingin Input lagi? y/n"+ Console.ReadLine());
            Console.Write("Laki Dewasa : ");
            int lakiDe =(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Ingin Input lagi? y/n" + Console.ReadLine());
            Console.Write("Wanita Dewasa : ");
            int WanitaDe =2*int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingin Input lagi? y/n" + Console.ReadLine());
            Console.Write("Anak-Anak : ");
            int anakAnak =3*int.Parse(Console.ReadLine());
            //Console.Write("Ingin Input lagi? y/n" + Console.ReadLine());
            Console.Write("Bayi : ");
            int bayi =5*int.Parse(Console.ReadLine());
            int total = lakiDe+WanitaDe+anakAnak+bayi;

            if (total%2 !=0 && total>10)
            {
                Console.WriteLine("Total Baju dibutuhkan : "+(lakiDe+anakAnak+bayi+WanitaDe+((WanitaDe/2))));
            }
            else
            {
                Console.WriteLine("Total Baju dibutuhkan : " + total);
            }

           
        }

        static void gradingStudents(List<int> grades)
        {
            List<int> Final = new List<int>() { };
            foreach (int grade in grades)
            {
                if (grade < 38)
                {
                    Final.Add(grade);
                }
                else if ((grade % 5) >= 3)
                {
                    Final.Add((grade - (grade % 5)) + 5);
                }
                else
                {
                    Final.Add(grade);
                }
            }
            Console.WriteLine("Nilai Final"+Final);
        }

    }


}

