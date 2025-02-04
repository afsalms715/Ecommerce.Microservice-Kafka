using System.Security.Principal;

namespace Ecommerce.Models.General
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; } = true;
    }
}
