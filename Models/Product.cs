﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestFinal.Models
{
    public class Product
    {

        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ShortDescription { get; set; }
        public string ProductColor { get; set; }
        public string ProductPicture { get; set; }
        public string ProductPicture2 { get; set; }
        public string ProductPicture3 { get; set; }
        public string ProductVideo { get; set; }
        public int Pret { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }
        public int SubCategorieID { get; set; }
        public virtual Subcategory Subcategorie { get; set; }
        public string SerialNo { get; set; }

        public int ProductStock { get; set; }

    }

}
