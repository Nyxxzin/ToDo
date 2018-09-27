using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoMvc.Models;

namespace ToDoMvc.Services
{
    public interface IToDoItemService
    {

        Task<IEnumerable<ToDoItem>> GetIncompleteItemAsync();
        Task<bool> AddItemAsync(NewToDoItem newItem);
        Task<bool> MarkDoneAsync(Guid id);
    }
}
