using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "pizza", "sushi", "burger", "popcorn", "salad" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string RandomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {RandomFood}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "sprite", "coke", "fanta" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drinks.Length);

            string RandomDrink = drinks[randomIndex];
            Console.WriteLine($"Computer picked: {RandomDrink}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Pulp Fiction", "Free Guy", "Last Samurai", "Joker", "Soo", "Jumper", "The Godfather" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movies.Length);

            string RandomMovie = movies[randomIndex];
            Console.WriteLine($"Computer picked: {RandomMovie}");
        }
    }
}
