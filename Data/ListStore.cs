using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Data
{
    public class ListStore : IGetList
    {
        public List<string> GetList()
        {
            var list = new List<string>() { "product one", "my second product", "this product came from data layer" };
            return list;
        }

    }
}
