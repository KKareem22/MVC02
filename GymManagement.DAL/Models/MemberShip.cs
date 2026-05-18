using Session01.Models;

namespace GymManagement.DAL.Models
{
    public class MemberShip : BaseEntity
    {
        public DateTime EndDate { get; set; }
        public Member Member { get; set; } = null!;
        public int MemberId { get; set; }
        public Plan Plan { get; set; } = null!;
        public int PlanId { get; set; }


    }
}
