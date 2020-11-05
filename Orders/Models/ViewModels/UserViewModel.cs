using System.Collections.Generic;

namespace Orders.Models.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<OrderViewModel> Orders { get; set; }
    }
}
