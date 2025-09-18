namespace biobiljett
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Filmer, priser, rabatt och moms (Movies, prices, discount and taxes)
            string[] movies = { "Super Mario Bros. Filmen", "Dumma Mig 3", "The BeeKeeper", "The Old Guard 2" };
            double[] prices = { 100, 100, 200, 200 };
            const double TAX = 0.06;    //6% moms (taxes)
            const double STUDENT_DISCOUNT = 0.15;   //15% rabatt för studenter (student discount)
            const string CURRENCY = "SEK"; //valuta

            //Välkomstmeddelande och visa filmer (Welcomemessage and show the movies)
            Console.WriteLine("Välkommen till Biobiljett.se!");
            Console.WriteLine("=============================\n");
            Console.WriteLine("Tillgängliga filmer:\n");
            for (int i = 0; i < movies.Length; i++)
            {
                double priceWithTax = prices[i] * (1 + TAX);
                Console.WriteLine($"{i + 1}. {movies[i]} - {priceWithTax:F2} {CURRENCY} (inkl. moms)");
            }

            //Val av film (Choose a movie)
            Console.Write("Välj en film genom att ange motsvarande nummer: \n");
            int choice = int.Parse(s: Console.ReadLine());
            string movie = movies[choice - 1];
            double basePrice = prices[choice - 1];

            //Biljetter (Tickets)
            Console.WriteLine("Hur många biljetter vill du köpa? ");
            int ticket = int.Parse(Console.ReadLine());

            //Studentrabatt (Student discount)
            Console.Write("Är du student? (ja/nej):\n");
            bool isStudent = Console.ReadLine().ToLower() == "ja";

            if (isStudent)
            {
                Console.WriteLine("Studentrabatt tillämpad.");
            }
            else
            {
                Console.WriteLine("Ingen rabatt tillämpad (endast studenter får rabatt).");
            }
            Console.WriteLine("\nTryck Enter för kvitto");

            //Beräkna totalpris (Calculate total price)
            double pricePerTicket = isStudent ? basePrice * (1 - STUDENT_DISCOUNT) : basePrice;
            double total = ticket * pricePerTicket * (1 + TAX);
            Console.ReadLine();

            //Kvittens (Receipt)
            Console.WriteLine("\n------ KVITTO ------\n");
            Console.WriteLine($"Film: {movie}");
            Console.WriteLine($"Antal biljetter: {ticket}");
            Console.WriteLine($"Studentrabett: {(isStudent ? "Ja" : "Nej")}");
            Console.WriteLine($"Totalt pris: {total:F2} {CURRENCY} (inkl. moms\n");

            Console.WriteLine("Tack för ditt köp! Ha en trevlig film!\n");
            Console.WriteLine("===========================");
        }
    }
}
