

namespace Company.RouteMVCProject.DataAccessLayer.Models
{
    public class Department : BaseEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
