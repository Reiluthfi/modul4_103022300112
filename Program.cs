class program
{
    static void Main()
    {
        Console.WriteLine("Masukkan Nama Barang: ");
        string namaProduk = Console.ReadLine();
        Console.WriteLine("Kode Produk: " + KodeProduk.GetKodeProduk(namaProduk));
    }
}