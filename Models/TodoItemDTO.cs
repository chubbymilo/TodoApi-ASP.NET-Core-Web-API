using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItemDTO
    {
        public long id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}
