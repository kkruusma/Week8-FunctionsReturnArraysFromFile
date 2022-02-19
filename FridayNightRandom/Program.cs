using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }


        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };
            //pikalt välja kirjutatult 3 rida:
            //int randomIndex = GenerateRandomIndex(foods);
            //string randomFood = foods[randomIndex];
            //Console.WriteLine($"Computer picked: {randomFood}");

            //lühidalt saab niimoodi:
            Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };

            Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Die hard", "Home alone", "Spiderman" };
            
            Console.WriteLine($"Computer picked: {movies[GenerateRandomIndex(movies)]}");
        }

    }
}
