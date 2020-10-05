using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public long id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
        public string Secret { get; set; }
    }
}
