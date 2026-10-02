namespace Uppg_26_01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            three_five();
        }

        static void three_one()
        {
            Console.Write("how old are you? ");
            int age = int.Parse(Console.ReadLine()!);
            Console.WriteLine(age switch {
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
            Console.WriteLine((has_finished, age) switch {
                (true, <22) => "Vi vill gärna anställa dig",
                _ => "Vi letar tyvärr efter annan personal just nu",
            });
        }

        static void three_three()
        {
            Console.Write("i hur många timmar vill du hyra en bil? ");
            int hours = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Det kommer att kosta dig {(hours * 80) switch
            {
                >950 => 950,
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
                >4 * 60 + 20 or <2 * 60 + 45 => "låten får inte spelas",
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

            Console.WriteLine(int.Parse(Console.ReadLine()!) switch {
            1 => $"{first + second}",
            2 => $"{first - second}",
            3 => $"{first * second}",
            4 => $"{first / second}",
            _ => "ogiltigt alternativ",
            });
        }
    }
}
