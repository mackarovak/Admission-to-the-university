using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veryhelpfulsystem
{
    [Serializable]
    public class NewsItem
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageURL { get; set; }
        public DateTime Date { get; set; }
    }
}
