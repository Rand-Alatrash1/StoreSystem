using StoreSystem.Abstract;

namespace StoreSystem.Models
{
    public class Food : Product
    {
        public Food(int id, string name) : base(id, name) { }

        public override double GetPrice()
        {
            return 10;
        }
    }
}
