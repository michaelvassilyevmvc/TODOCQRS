using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public class TodoItem: AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public PriorityLevel Priority { get; set; }

        public int ListId { get; set; }
        public TodoList List { get; set; }

    }
}
