namespace BakeryMarkTest.Models
{
    public class Ingredients
    {
        public int IngridientID { get; set; }
        public string IngredientName { get; set; }
        public string IngredientType { get; set; }
        public bool IsAllergen { get; set; }

        public Ingredients()
        {

        }
    }
}
