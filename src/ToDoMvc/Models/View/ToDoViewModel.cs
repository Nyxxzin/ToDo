using System.Collections.Generic;
using ToDoMvc.Models;

namespace ToDoMvc.Models.View
{
    public class ToDoViewModel
    {
        public IEnumerable<ToDoItem> Items { get; set; }
    }
}