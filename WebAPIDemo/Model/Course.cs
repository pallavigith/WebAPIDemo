using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemo.Model
{
    [Table("Course")]//Mapping Of Table Product With Class
   
    
    public class Course
    {
        [Key]
        public int Id { get; set; }
            public string Name { get; set; }
            public decimal Fees { get; set; }

        }
    }
