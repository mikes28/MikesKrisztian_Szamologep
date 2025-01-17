internal class Program
{
    private static void Main(string[] args)
    {
        Indit();
    }
    private static void Indit()
    {
        Console.WriteLine("Kérem adja meg az első számot: ");
        int numA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kérem adja meg a második számot: ");
        int numB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Az elvégzendő művelet jele (+, -, *, /, %): ");
        char operation = Console.ReadLine()[0];

        int result = 0;
        switch (operation)
        {
            case '+':
                result = Osszeadas(numA, numB);
                break;
            case '-':
                result = Kivonas(numA, numB);
                break;
            case '*':
                result = Szorzas(numA, numB);
                break;
            case '/':
                result = Osztas(numA, numB);
                break;
            case '%':
                result = Szazalek(numA, numB);
                break;
            default:
                Console.WriteLine("Érvénytelen műveleti jel.");
                return;
        }

        Console.WriteLine($"Az eredmény: {result}");
    }
    private static Int32 Osszeadas(Int32 numA, Int32 numB)
    {
        return numA + numB;
    }

    private static Int32 Kivonas(Int32 numA, Int32 numB)
    {
        return numA - numB;
    }
    private static Int32 Osztas(Int32 numA, Int32 numB)
    {
        return numA / numB;
    }
    private static Int32 Szorzas(Int32 numA, Int32 numB)
    {
        return numA * numB;
    }

    private static Int32 Szazalek(Int32 numA, Int32 numB)
    {
        return numA % numB;
    }

}