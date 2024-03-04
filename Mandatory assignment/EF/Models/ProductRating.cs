using EF_Compulsory_Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Compulsory_Assignment.Models
{
    public class ProductRating
    {
        public int ProductRatingId { get; set; }
        public int ProductId_FK { get; set; }
        public int Rate { get; set; }
        public Product Product { get; set; }
    }
}
