using Ecommerce.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class OrderModel : BaseModel
    {
        public string CustomerName { get; set; }
        public int ProductId { get; set; }
        public int OrderQuantity { get; set; }
    }
}
