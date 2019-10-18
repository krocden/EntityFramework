using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework;

namespace EntityFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Code Here. Test Methods

            // Add Methods
            // One record for each table.
            var food = new Food();
            food.name = "Spaghetti";
            food.size = "40*60";
            food.active = true;
            myDb.AddFood(food);

            var ingredient = new Ingredient();
            ingredient.name = "Pasta";
            ingredient.size = "4*130";
            ingredient.weight = "60g";
            ingredient.active = true;
            myDb.AddIngredient(ingredient);

            var product = new Product();
            product.foodId = food.foodId;
            product.ingredientId = ingredient.ingredientId;
            product.productionDate = DateTime.Today;
            myDb.AddProduct(product);

            // Edit Method
            var ingredient2 = new Ingredient();
            ingredient2.weight = "75g";
            myDb.EditIngredient(ingredient.ingredientId, ingredient2);

            //Display all
            var ProductList = myDb.GetProducts();

            foreach (Product p in ProductList)
            {
                Food foodD = myDb.GetFood(p.foodId);
                Ingredient ingredientD = myDb.GetIngredient(p.ingredientId);
                Console.WriteLine("Food name = "+foodD.name+" and Ingredient = "+ingredientD.name);
            }
        }
    }
}
