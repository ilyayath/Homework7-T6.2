namespace Facade
{
    public class Ingredients
    {
        public void GatherIngredients()
        {
            Console.WriteLine("Gathering all necessary ingredients...");
        }

        public void PrepareIngredients()
        {
            Console.WriteLine("Washing, cutting, and preparing ingredients...");
        }
    }

    public class Cooking
    {
        public void CookDish()
        {
            Console.WriteLine("Cooking the dish...");
        }

        public void PlateDish()
        {
            Console.WriteLine("Plating the dish beautifully...");
        }
    }

    public class Serving
    {
        public void ServeDish()
        {
            Console.WriteLine("Serving the dish to the table...");
        }

        public void CleanUp()
        {
            Console.WriteLine("Cleaning up after the meal...");
        }
    }

    public class KitchenFacade
    {
        private Ingredients _ingredients;
        private Cooking _cooking;
        private Serving _serving;

        public KitchenFacade()
        {
            _ingredients = new Ingredients();
            _cooking = new Cooking();
            _serving = new Serving();
        }

        public void PrepareMeal()
        {
            _ingredients.GatherIngredients();
            _ingredients.PrepareIngredients();
            _cooking.CookDish();
            _cooking.PlateDish();
            _serving.ServeDish();
            Console.WriteLine("Meal is ready and served.");
        }

        public void FinishMeal()
        {
            _serving.CleanUp();
            Console.WriteLine("Meal preparation and serving process is complete.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KitchenFacade kitchenFacade = new KitchenFacade();

            kitchenFacade.PrepareMeal();
            Console.WriteLine();
            kitchenFacade.FinishMeal();

            Console.ReadKey();
        }
    }
}
