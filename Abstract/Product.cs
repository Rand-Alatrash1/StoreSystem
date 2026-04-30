 using StoreSystem.Interfaces;

namespace StoreSystem.Abstract
    {
        public abstract class Product : IProduct
        {
            private int id;

            public int Id
            {
                get { return id; }
            }

            public string Name { get; set; }

            public Product(int id, string name)
            {
                this.id = id;
                Name = name;
            }

            public abstract double GetPrice();
        }
    }
