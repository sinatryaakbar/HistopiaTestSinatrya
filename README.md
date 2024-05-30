# HistopiaTestSinatrya

Berikut penjelasan  kompleksitas koding dari soal nomer 2

## Deklarasi Variabel dan Pemeriksaan Awal :

    var queue = new Stack<char>(); // 𝑂(1)
    if (InputString.Length == 0) return "NO"; // 𝑂(1)

Baris-baris ini dieksekusi dalam waktu konstan, yaitu 𝑂(1).

## Perulangan Char Array dari Parameter InputString :

    foreach (var chr in InputString)
    {
        // Switch statement with multiple cases
    }
Loop ini berjalan sebanyak `n` kali, di mana `n` adalah panjang dari `InputString. Oleh karena itu, loop ini berkontribusi 𝑂(𝑛) terhadap kompleksitas.

## Pernyataan Switch:

    switch (chr)
    {
        case ' ':
            break; // 𝑂(1)
        case '(':
        case '[':
        case '{':
            queue.Push(chr); // 𝑂(1)
            break;
        case ')':
            if (queue.Count == 0 || queue.Pop() != '(') return "NO"; // 𝑂(1)
            break;
        case ']':
            if (queue.Count == 0 || queue.Pop() != '[') return "NO"; // 𝑂(1)
            break;
        case '}':
            if (queue.Count == 0 || queue.Pop() != '{') return "NO"; // 𝑂(1)
            break;
        default:
            return $"{chr} Is Invalid Character..!"; // 𝑂(1)
    }
Setiap kasus dalam pernyataan switch dieksekusi dalam waktu konstan, yaitu 𝑂(1).

Operasi stack (`Push`, `Pop`, `Count`) semuanya 𝑂(1). Jadi, setiap iterasi dalam loop memiliki kompleksitas 𝑂(1).

## Pemeriksaan Akhir:

    return (queue.Count == 0) ? "YES" : "NO"; // 𝑂(1)

Baris ini dieksekusi dalam waktu konstan, yaitu 𝑂(1).


### Total Kompleksitas Waktu : 

Jika kita mempertimbangkan semua bagian bersama-sama:
 - Loop berjalan sebanyak n kali, dan setiap operasi di dalam loop
   adalah 𝑂(1).
Maka, kompleksitas waktu keseluruhan dari kode ini adalah:


> **Total Kompleksitas Waktu**=𝑂(𝑛)

### Kompleksitas Ruang : 

1. **Alokasi Stack:**

    var queue = new Stack<char>();

Kompleksitas ruang untuk stack tergantung pada jumlah kurung buka dalam string input. Dalam kasus terburuk, di mana semua karakter adalah kurung buka, stack akan menyimpan n elemen.

 2. **Variabel Lainnya**: 
Semua variabel dan operasi lainnya. Maka, kompleksitas ruang adalah:

> Total Kompleksitas Ruang=𝑂(𝑛)
 
menggunakan ruang konstan.

You can export the current file by clicking **Export to disk** in the menu. You can choose to export the file as plain Markdown, as HTML using a Handlebars template or as a PDF.


### Kesimpulan

 - Kompleksitas Waktu: 𝑂(𝑛), di mana n adalah panjang dari string input.
 - Kompleksitas Ruang: 𝑂(𝑛), terutama karena stack yang digunakan untuk menyimpan kurung buka.

Ini berarti algoritma tersebut memiliki kompleksitas linear baik dalam hal waktu maupun ruang sehubungan dengan ukuran string input.
