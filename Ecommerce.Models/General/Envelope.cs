using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.General
{
    public class Envelope<T>
    {
        public int StatusCode { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }

    }
}
