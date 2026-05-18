using GymManagement.DAL.Models.Enums;

namespace GymManagement.DAL.Models
{
    public class Trainer : GymUser
    {
        //Note : HireDate =CreatedAt
        public Specialties  Specialties { get; set; }

        public ICollection<Session> Sessions { get; set; }
    }
}
