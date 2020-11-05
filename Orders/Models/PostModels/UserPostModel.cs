using System.Collections.Generic;

namespace Orders.Models.PostModels
{
    public class UserPostModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<OrderPostModel> Orders { get; set; }
    }
}
