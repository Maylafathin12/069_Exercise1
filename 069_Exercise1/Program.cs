using System;

namespace _069_Exercise1
{
    class Algoritma
    {
        //mendeklarasikan array int dengan ukuran 89
        //dimana 89 merupakan penambahan dari 2 digit angka terakhir +10+20+20-2x15 
        public decimal[] mayla = new decimal[89];

        //deklarasi untuk menyimpan banyaknya array
        public decimal n;

        //membuat fungsi method 
        public void Input()//dimana digunakan untuk melewatkan suatu nilai
        {
            //mengguhnakan perulangan while
            while (true)
            {
                //digunakan untuk menampilkan 
                Console.Write("");
                Console.WriteLine("Masukkan banyaknya elemen pada array");

                //disimpan di dalam variable s
                string s = Console.ReadLine();

                //mengonversikan bentuk eksplisit menggunakan parse
                n = decimal.Parse(s);

                //menggunakan if else untuk membuat keputusan
                //jika i <= 89 maka akan dilanjutkan
                if (n <= 89)
                    break;

                //jika i > 89 maka akan muncul tulisan
                else
                    Console.WriteLine("");
                Console.WriteLine("Array hanya dapat menampung sampai 89!");
            }
            //menampilkan bagian untuk memasukkan nilai array
            Console.WriteLine("Masukkan elemen Array :");

            //memasukkan elemen pada array
            //nilai akan terus berulang sampai mendapatkan hasil < dari 89 atau = 89
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + i + 1 + ">");

                //data yang sekarang tersimpan adalah data string
                string s1 = Console.ReadLine();
                mayla[i] = decimal.Parse(s1);
            }
        }
        //method untuk tidak mengembalikan nilai
        //method yang digunakan hanya untuk menampilkan array
        public void Tampil()
        {
            //menampilkan bagian array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("Elemen array telah tersusun");

            for (int MF = 0; MF < n - 1; MF++)

                //digunakan untuk menuliskan data yang sudah terurut
                Console.WriteLine((Convert.ToDecimal(mayla[MF])));
        }
        public void Algoritma2()
        {
            //untuk mengulangi step 2 dan 3
            for (int i = 1; i < n; i++)
            {
                //set temp arr[i]
                _ = mayla[i];
                //set j = i-1
                int MF = i - 1;
                //diulangi sampai mendapatkan hasil
                while (MF >= 0) ;
            }
        }
        public void AlgoArray()
        {
            for (int i = 1; i < n; i++) // for n - 1 passes
            {
                // Pada pass 1, bandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int MF = 0; MF < n - i; MF++)
                {
                    if (mayla[MF] > mayla[MF + 1]) //jika elemen tidak ada dalam urutan yang benar
                    {
                        // tukar elemen
                        int temp;
                        temp = (int)mayla[MF];
                        mayla[MF] = mayla[MF + 1];
                        mayla[MF + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //membuat objek di kelas bubble sort 
            Algoritma myList = new Algoritma();

            //memanggil fungsi untuk menerima elemen array
            myList.Input();
            //memanggil fungsi untuk mengurutkan array
            myList.AlgoArray();
            //memanggil fungsi untuk menampilkan array yang tersusun
            myList.Tampil();
            //nggak tau ini manggil apa :(((((((((
            myList.Algoritma2();

            //keluar
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}

