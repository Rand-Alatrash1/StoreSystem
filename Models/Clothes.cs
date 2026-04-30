using StoreSystem.Abstract;

namespace StoreSystem.Models
{
    public class Clothes : Product
    {
        public Clothes(int id, string name) : base(id, name) { }

        public override double GetPrice()
        {
            return 50;
        }
    }
}