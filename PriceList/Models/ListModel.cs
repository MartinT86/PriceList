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
            Items = new List<ListModelItem>();
        }

        public List<ListModelItem> Items { get; set; }
    }
}