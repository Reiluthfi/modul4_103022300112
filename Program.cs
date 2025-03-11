class program
{
    static void Main()
    {
        Console.WriteLine("Masukkan Nama Barang: ");
        string namaProduk = Console.ReadLine();
        Console.WriteLine("Kode Produk: " + KodeProduk.GetKodeProduk(namaProduk));

        FanLaptop fan = new FanLaptop();
        Console.WriteLine("\nSimulasi Mode Fan ");
        Console.WriteLine("Masukkan Mode : ");
        string comms = Console.ReadLine();
        fan.setMode(comms);

        Console.WriteLine("Masukkan Mode : ");
        comms = Console.ReadLine();
        fan.setMode(comms);

        Console.WriteLine("Masukkan Mode : ");
        comms = Console.ReadLine();
        fan.setMode(comms);

        Console.WriteLine("Masukkan Mode : ");
        comms = Console.ReadLine();
        fan.setMode(comms);

        Console.WriteLine("Masukkan Mode : ");
        comms = Console.ReadLine();
        fan.setMode(comms);

        Console.WriteLine("Masukkan Mode : ");
        comms = Console.ReadLine();
        fan.setMode(comms);

        Console.WriteLine("Masukkan Mode : ");
        comms = Console.ReadLine();
        fan.setMode(comms);

        Console.WriteLine("Masukkan Mode : ");
        comms = Console.ReadLine();
        fan.setMode(comms);


    }

}