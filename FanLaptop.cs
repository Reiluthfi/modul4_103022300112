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
        Console.WriteLine("Enter Command : ");
        string command = Console.ReadLine();
        switch (mode)
        {
            case "Quiet":
                if (command == "Mode up")
                {
                    Console.WriteLine("Fan " + currentState + " Fan Mode Balanced");
                    currentState = State.Balanced;
                }
                else if (command == "Turbo Shortcut")
                {
                    Console.WriteLine("Fan " + currentState + " Fan Mode Turbo");
                    currentState = State.Turbo;
                }
                break;
            case "Balanced":
                if (command == "Mode up")
                {
                    Console.WriteLine("Fan " + currentState + " Fan Mode Performance");
                    currentState = State.Performance;
                }
                else if (command == "Mode down")
                {
                    Console.WriteLine("Fan " + currentState + " Fan Mode Quiet");
                    currentState = State.Quiet;
                }
                break;
            case "Performance":
                if (command == "Mode up")
                {
                    currentState = State.Turbo;
                    Console.WriteLine("Fan " + currentState + " Fan Mode Turbo");
                }
                else if (command == "Mode down")
                {
                    Console.WriteLine("Fan " + currentState + " Fan Mode balanced");
                    currentState = State.Balanced;
                }
                break;
            case "Turbo":
                if (command == "Mode down")
                {
                    Console.WriteLine("Fan " + currentState + " Fan Mode Performance");
                    currentState = State.Performance;
                }
                else if (command == "Turbo Shortcut")
                {
                    Console.WriteLine("Fan " + currentState + " Fan Mode Quiet");
                    currentState = State.Quiet;
                }
                break;
            default:
                Console.WriteLine("Mode tidak dikenal");
                break;


        }
    }
}
 