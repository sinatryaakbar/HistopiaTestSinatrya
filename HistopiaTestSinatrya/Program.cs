// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using HistopiaTestSinatrya.Answer;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
int NomorSoal = -1;

while (NomorSoal < 0 || NomorSoal > 3)
{
    Console.WriteLine("Input No Soal (1, 2, 3) atau Enter untuk exit :");
    var inputSoal = Console.ReadLine();
    int.TryParse(inputSoal, out NomorSoal);
    if (string.IsNullOrEmpty(inputSoal))
        NomorSoal = 0;
    else if (NomorSoal == 0)
        NomorSoal = -1;

    //Console.WriteLine($"Input yang dipilih : {NomorSoal}");
    switch (NomorSoal)
    {
        case 1:
            Console.WriteLine("Soal No 1: ");
            Console.WriteLine("Menghitung Bobot dari string yang input sesuai urutan alfabet, untuk dibandingkan dengan Queries yang berupa himpunan angka");
            Console.WriteLine("Non Alfabet tidak dihitung bobotnya..");

            string InputStringNo1 = string.Empty;
            while (string.IsNullOrEmpty(InputStringNo1))
            {
                Console.WriteLine("Masukan string alfabet untuk dihitung bobotnya : ");
                InputStringNo1 = (Console.ReadLine() ?? string.Empty).Trim();
            }

            List<int> queries = new();
            string InputQueries = string.Empty;
            while (!string.IsNullOrEmpty(InputQueries) || !queries.Any())
            {
                Console.WriteLine($"Masukan Angka untuk untuk masuk ke himpunan angka [ {string.Join(", ", queries)} ] : ");
                if (queries.Any())
                    Console.WriteLine("Atau Tekan Enter Untuk Melanjutkan.");
                InputQueries = (Console.ReadLine()??string.Empty).Trim();
                int thisQueries = -1;
                if (int.TryParse(InputQueries, out thisQueries) && !queries.Contains(thisQueries))
                    queries.Add(thisQueries);
                else
                    continue;
            }
            var resNo1 = SoalNo1.GetWeightedStrings(InputStringNo1, queries);
            Console.WriteLine($"Hasil Soal No 1: Pebandingan bobot dari Input String: {InputStringNo1} dan queries: [ {string.Join(", ", queries)} ] adalah ");
            Console.WriteLine($"[ {string.Join(", ", resNo1)} ]");
            
            Console.WriteLine();
            NomorSoal = -1;
            break;
        case 2:
            Console.WriteLine("Soal No 2: ");
            Console.WriteLine("Validasi Bracket Balance berdasarkan string yang di-input ");
            Console.WriteLine("Tanda Bracket / karakter yang diperbolehkan adalah ( , ) , { , } , atau [ , ].  ");
            string InputStringNo2 = string.Empty;
            while (string.IsNullOrEmpty(InputStringNo2))
            {
                Console.WriteLine("Masukan string kumpulan bracket : ");
                InputStringNo2 = (Console.ReadLine() ?? string.Empty).Trim();
            }
            var resNo2 = SoalNo2.GetBalancedBracket(InputStringNo2);
            Console.WriteLine($"Hasil Soal 2 Validasi Bracket Balance dari {InputStringNo2} adalah ");
            Console.WriteLine($"'{resNo2}'");
            
            Console.WriteLine();
            NomorSoal = -1;
            break;
        case 3:
            Console.WriteLine("Soal No 3: ");
            Console.WriteLine("Membuat Palindrom Tertinggi berdasarkan string yang di-input, dan replacement karakter sejumlah variable K");
            string InputStringNo3 = string.Empty;
            while (string.IsNullOrEmpty(InputStringNo3))
            {
                Console.WriteLine("Masukkan Angka untuk mendapatkan palindrom Tertinggi : ");
                InputStringNo3 = (Console.ReadLine() ?? string.Empty).Trim();
            }

            int K = 0;
            string inputK = string.Empty;
            while (string.IsNullOrEmpty(inputK))
            {
                Console.WriteLine("Masukan variable K : ");
                inputK = (Console.ReadLine() ?? string.Empty).Trim();
                if (!int.TryParse(inputK, out K))
                    inputK = string.Empty;
            }


            var resNo3 = SoalNo3.GetHighestPalindrome(InputStringNo3, K);
            Console.WriteLine($"Hasil Soal 3 Palindrom Terbesar dari : {InputStringNo3} dengan jumlah replacement : {K} adalah ");
            Console.WriteLine($"'{resNo3}'");

            Console.WriteLine();
            NomorSoal = -1;
            break;
        default:
            break;
    }
}
