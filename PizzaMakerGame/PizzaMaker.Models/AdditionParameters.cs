namespace PizzaMaker.Models
{
    public struct AdditionParameters
    {
        private readonly int calories;
        private readonly bool isVegetarian;
        private readonly decimal price;

        public AdditionParameters(decimal price, int calories, bool isVegetaranian)
        {
            this.price = price;
            this.calories = calories;
            this.isVegetarian = isVegetaranian;
        }

        public decimal Price => this.price;

        public int Calories => this.calories;

        public bool IsVegetarian => this.isVegetarian;
    }
}
