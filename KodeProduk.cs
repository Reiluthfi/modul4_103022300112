class KodeProduk
{
    private static readonly Dictionary<string, string> kodeProduk = new Dictionary<string, string>
    {
        { "Laptop", "E100" },
        { "Smartphone", "E101" },
        { "Tablet", "E102" },
        { "Headset", "E103" },
        { "Keyboard", "E104" },
        { "Mouse", "E105" },
        { "Printer", "E106" },
        { "Monitor", "E107" },
        { "SmartWatch", "E108" },
        { "Kamera", "E109" }
    };
    public static string GetKodeProduk(string namaProduk)
    {
        return kodeProduk[namaProduk];
    }
}