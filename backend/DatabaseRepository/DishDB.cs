using backend.Models;

namespace backend.DatabaseRepository
{
    public class DishDB
    {
        // Get All
        public static List<Dish> GetAllDishes() 
        {
            List<Dish> list = new List<Dish>();

            Dish dish1 = new Dish();
            dish1.DishId = 1;
            dish1.DishTitle = "Classic Breakfast";
            dish1.DishSubtitle = "Eggs, Bacon, and Toast";
            dish1.DishDescription = "A hearty breakfast with sunny-side-up eggs, crispy bacon, and toasted bread.";
            dish1.DishImage = "url_to_image_of_classic_breakfast";
            list.Add(dish1);

            Dish dish2 = new Dish();
            dish2.DishId = 2;
            dish2.DishTitle = "Vegan Salad Bowl";
            dish2.DishSubtitle = "Fresh and Nutritious";
            dish2.DishDescription = "A mix of fresh veggies, quinoa, and avocado with a tangy vinaigrette.";
            dish2.DishImage = "url_to_image_of_vegan_salad_bowl";
            list.Add(dish2);

            Dish dish3 = new Dish();
            dish3.DishId = 3;
            dish3.DishTitle = "Spaghetti Carbonara";
            dish3.DishSubtitle = "Classic Italian";
            dish3.DishDescription = "Creamy pasta with pancetta, eggs, and pecorino cheese.";
            dish3.DishImage = "url_to_image_of_spaghetti_carbonara";
            list.Add(dish3);

            return list;
        }

        // Get Single
        public static Dish GetDishById(int DishId)
        {
            var dish = new Dish();
            dish = GetAllDishes().Where(p => p.DishId == DishId).FirstOrDefault();

            return dish;
        }

        // Delete
        public static Dish DeleteDishById(int DishId)
        {
            var dish = new Dish();
            dish = GetAllDishes().Where(p => p.DishId == DishId).FirstOrDefault();

            return dish;
        }

        // Edit
        public static Dish EditDishById(int DishId)
        {
            var dish = new Dish();
            dish = GetAllDishes().Where(p => p.DishId == DishId).FirstOrDefault();

            return dish;
        }
    }
}
