using StoreSystem.Abstract;

namespace StoreSystem.Models
{
    public class Electronics : Product
    {
        public Electronics(int id, string name) : base(id, name) { }

        public override double GetPrice()
        {
            return 100;
        }
    }
}