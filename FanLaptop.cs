class FanLaptop
{
    private enum State { Quiet, Balanced, Performance, Turbo }
    private State currentState;

    public FanLaptop()
    {
        currentState = State.Quiet;
        Console.WriteLine("Fan Laptop Mode Quiet");
    }
    public void setMode(string mode)
    {
        switch (mode)
        {
            case "Quiet":
                Console.WriteLine("Fan Mode " + currentState + " Berubah Menjadi Mode Quiet");
                currentState = State.Quiet;
                break;
            case "Balanced":
                Console.WriteLine("Fan Mode " + currentState + " Berubah Menjadi Mode Balanced");
                currentState = State.Balanced;
                break;
            case "Performance":
                Console.WriteLine("Fan Mode " + currentState + " Berubah Menjadi Mode Performance");
                currentState = State.Performance;
                break;
            case "Turbo":
                Console.WriteLine("Fan Mode " + currentState + " Berubah Menjadi Mode Turbo");
                currentState = State.Turbo;
                break;
            default:
                Console.WriteLine("Fan Laptop Mode Tidak Ada");
                break;
        }
    }

}