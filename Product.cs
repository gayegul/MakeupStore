using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupStore
{
    class Product
    {
        #region Properties
        public int Id { get; private set; }
        public string Type { get; private set; }
        public string Brand { get; private set; }
        public double Price { get; private set; }
        public string Color { get; private set; }
        public string Name { get; private set; }
        #endregion
    }
}
