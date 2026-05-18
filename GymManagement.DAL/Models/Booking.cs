namespace GymManagement.DAL.Models
{
    public class Booking :BaseEntity
    {
        public bool IsAttended { get; set; } = false;
        public Member Member { get; set; } = default!;
        public int MemberId { get; set; }
        public Trainer Trainer { get; set; } = default!;
        public int TrainerId { get; set; }
    }
}
