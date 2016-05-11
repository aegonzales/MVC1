using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Counter
    {
        [Key]
        public int CounterId { get; set; }
        public int CounterCount { get; set; }
    }
}