namespace Uppg_26_01_02;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.Write("input a number to run assignment number 3.{your number}: ");
                int num = int.Parse(Console.ReadLine()!);
                ((Action[])[three_one, three_two, three_three, three_four, three_five, three_six, three_seven, three_eight, three_nine])[--num]();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }

    static void three_one()
    {
        Console.Write("how old are you? ");
        Console.WriteLine(int.Parse(Console.ReadLine()!) switch
        {
            < 16 => "you are too young",
            > 19 => "you are too old",
            _ => "you may participate in the competition"
        });
    }

    static void three_two()
    {
        Console.Write("har du gått ur gymnasiet? [y/n] ");
        bool has_finished = Console.ReadLine() == "y";

        Console.Write("hur gammal är du? ");
        int age = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine((has_finished, age) switch
        {
            (true, < 22) => "Vi vill gärna anställa dig",
            _ => "Vi letar tyvärr efter annan personal just nu",
        });
    }

    static void three_three()
    {
        Console.Write("i hur många timmar vill du hyra en bil? ");

        Console.WriteLine($"Det kommer att kosta dig {(int.Parse(Console.ReadLine()!) * 80) switch
        {
            > 950 => 950,
            var x => x,
        }} kr");
    }

    static void three_four()
    {
        Console.WriteLine("hur lång är låten?");

        Console.Write("ange antelet minuter: ");
        int seconds = int.Parse(Console.ReadLine()!) * 60;

        Console.Write("ange antalet sekunder: ");
        seconds += int.Parse(Console.ReadLine()!);

        Console.WriteLine(seconds switch
        {
            > 4 * 60 + 20 or < 2 * 60 + 45 => "låten får inte spelas",
            _ => "låten får spelas",
        });
    }

    static void three_five()
    {
        Console.Write("ange det första talet: ");
        int first = int.Parse(Console.ReadLine()!);
        Console.Write("ange det andra talet: ");
        int second = int.Parse(Console.ReadLine()!);

        Console.WriteLine("""
        Välj ett räknesätt
        1. Addition
        2. Subtraktion
        3. Multiplikation
        4. Division
        """);

        Console.WriteLine(int.Parse(Console.ReadLine()!) switch
        {
            1 => $"{first + second}",
            2 => $"{first - second}",
            3 => $"{first * second}",
            4 => $"{first / second}",
            _ => "ogiltigt alternativ",
        });
    }

    static void three_six()
    {
        Console.Write("skriv ditt förnamn & efternamn: ");
        string[] names = Console.ReadLine()!.ToLower().Split();
        Console.WriteLine($"ditt {(names.Order().First() == names[0] ? "förnamn" : "efternamn")} kommer först");
    }

    static void three_seven()
    {
        Console.Write("skriv in en addition eller subtraktion: ");
        string input = Console.ReadLine()!;
        Console.WriteLine(input.Split(['+', '-']).Select(int.Parse).Aggregate((acc, x) => input.Contains('+') ? acc + x : acc - x));
    }

    static void three_eight()
    {
        Console.WriteLine("ange tre stycken ord: ");
        Console.WriteLine($"ordet på plats nr {Enumerable.Range(1, 3).Select(n => { Console.Write($"ord {n}: "); return (Console.ReadLine(), n); }).Order().First().n} kom först");
    }

    static void three_nine()
    {
        Console.Write("skriv in ditt uttryck: ");
        Console.WriteLine(Console.ReadLine()!.Split('+').Sum(int.Parse));
    }
}