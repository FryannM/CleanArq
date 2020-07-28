using CleanArq.Domain.Common;
using CleanArq.Domain.Enums;

namespace CleanArq.Domain.Entities
{
    public class Person  : AuditableEntity
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public int LastName { get; set; }
        public PriorityLevel Priority { get; set; }
    }
}
