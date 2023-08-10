internal class PIN
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter PIN 456");
        int a = 0;
        do
        {
            string input = Console.ReadLine();
            int pin;
            pin = Convert.ToInt32(input);

            switch (pin)
            {
                case 456:
                    a = 3;
                    Console.WriteLine("Access granted");
                    break;

                default:
                    Console.WriteLine("Incorrect PIN");
                    if (a != 3) a++;
                    if (a == 3) Console.WriteLine("Sorry your account will be temporarily disable. Visit your nearest branch for reactivation");
                    break;
            }

        }
        while (a != 3);
    }
}