using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenu.Models
{
    public class Ingredient
    {
        private int _id;
        private string _name;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public Ingredient(int id, string name)
        {
            Id = id;
            _name = name;
        }

        public static List<string> GetIng()
        {
            List<string> list = new List<string>();
            foreach(Ingredient i in FillModels.FillIngredients())
            {
                list.Add(i.Name);
            }
            return list;
        }
    }
}
