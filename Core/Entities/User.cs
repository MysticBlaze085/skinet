
namespace Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int RolesId { get; set; }
        public RoleType RoleType { get; set; }
    }
}