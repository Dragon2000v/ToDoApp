using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ToDoDemo.Models
{
    public class Status
    {
      
        public string StatusId { get; set; } = string.Empty;
        
        public string Name { get; set; } = string.Empty;

    }
}
