﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }

       

        public string Name { get; set; }=null!;

       

        public string Code { get; set; } = null!;


      
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }

       public bool IsDeleted { get; set; }
        

    }
}
