namespace biobiljett
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Filmer, priser, rabatt och moms (Movies, prices, discount and taxes)
            string[] movies = { "Super Mario Bros. Filmen", "Dumma Mig 3", "The BeeKeeper", "The Old Guard 2" };
            double[] prices = { 120, 100, , 180, 190 };
            const double TAX = 0.06;    //6% moms (taxes)
            const double STUDENT_DISCOUNT = 0.15;   //15% rabatt för studenter (student discount)
            const string CURRENCY = "SEK"; //valuta

            //Välkomstmeddelande och visa filmer (Welcomemessage and show the movies)
            Console.WriteLine("Välkommen till Biobiljett.se!");
            Console.WriteLine("==============================");
            Console.WriteLine("Tillgängliga filmer:");
            for (int i = 0; i < movies.Length; i++)
            {
                double priceWithTax = prices[i] * (1 + TAX);
                Console.WriteLine($"{i + 1}. {movies[i]} - {priceWithTax:F2} {CURRENCY} (inkl. moms)");
            }

        }
    }
}
