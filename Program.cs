class program
{
    static void Main()
    {
        Console.WriteLine("Masukkan Nama Barang: ");
        string namaProduk = Console.ReadLine();
        Console.WriteLine("Kode Produk: " + KodeProduk.GetKodeProduk(namaProduk));

        FanLaptop fan = new FanLaptop();
        Console.WriteLine("\nSimulasi Mode Fan");
        fan.setMode("Balanced");
        fan.setMode("Performance");
        fan.setMode("Turbo");
        fan.setMode("Quiet");
        fan.setMode("Ekstra");

    }

}