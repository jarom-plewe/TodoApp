using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set;}
        public string user { get; set; }
        
    }
}
