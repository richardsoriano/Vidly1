using System.ComponentModel.DataAnnotations;

namespace vidly1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipTypes MembershipTypes { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}