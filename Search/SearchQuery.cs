using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    internal class SearchQuery
    {
        public string Text;
        public Dates Dates;

        public SearchQuery(string text, Dates dates)
        {
            Text = text;
            Dates = dates;
        }

        public SearchQuery()
        {
            
        }
    }

}
