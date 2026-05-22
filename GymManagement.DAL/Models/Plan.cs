using GymManagement.DAL.Models;

namespace Session01.Models
{
    public class Plan:BaseEntity
    {
        
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public int DurationDays { get; set; }
        public decimal Price { get; set; }
        
        public bool IsActive { get; set; }

        public ICollection<MemberShip> Members { get; set; } = new HashSet<MemberShip>();
    }
}
