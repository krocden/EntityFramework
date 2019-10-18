using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class myDb
    {
        //Entity Framework Object 
        private static FoodEntities db = new FoodEntities();

        // table Product has 2 foreign key with table Ingredient and table Food.

        // Enums for full list.
        public static IEnumerable<Food> GetFoods()
        {
            return db.Foods.ToList();
        }
        public static IEnumerable<Ingredient> GetIngredient()
        {
            return db.Ingredients.ToList();
        }
        public static IEnumerable<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        // Data retrieval Methods for table Food, Ingredient and Product
        public static Food GetFood(int x)
        {
            return db.Foods.Find(x);
        }
        public static Ingredient GetIngredient(int x)
        {
            return db.Ingredients.Find(x);
        }
        public static Product GetProduct(int x)
        {
            return db.Products.Find(x);
        }

        //Add Methods 
        public static void AddFood(Food x)
        {
            db.Foods.Add(x);
            db.SaveChanges();
        }
        public static void AddIngredient(Ingredient x)
        {
            db.Ingredients.Add(x);
            db.SaveChanges();
        }
        public static void AddProduct(Product x)
        {
            db.Products.Add(x);
            db.SaveChanges();
        }

        // Edit method
        public static void EditFood(int id, Food x)
        {
            db.Foods.Find(id).name = x.name;
            db.Foods.Find(id).size = x.size;
            db.SaveChanges();
        }
        public static void EditIngredient(int id, Ingredient x)
        {
            db.Ingredients.Find(id).name = x.name;
            db.Ingredients.Find(id).size = x.size;
            db.Ingredients.Find(id).weight = x.weight;
            db.SaveChanges();
        }
        public static void EditProduct(int id, Product x)
        {
            db.Products.Find(id).productionDate = x.productionDate;
            db.SaveChanges();
        }

        // Delete methods (Set to non active)
        public void DeleteFood(int x)
        {
            Food food = db.Foods.Find(x);
            db.Foods.Find(x).active = false;
            db.SaveChanges();
        }
        public void DeleteIngredient(int x)
        {
            Ingredient ingredient = db.Ingredients.Find(x);
            db.Ingredients.Find(x).active = false;
            db.SaveChanges();
        }
        public void DeleteProduct(int x)
        {
            Product product = db.Products.Find(x);
            db.Products.Find(x).active = false;
            db.SaveChanges();
        }
  
    }
}
