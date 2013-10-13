using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PriceList.Models
{
    public class ListModel
    {
        public ListModel()
        {
            Items = new List<string>();
        }

        public List<string> Items { get; set; }
    }
}