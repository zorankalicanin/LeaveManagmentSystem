using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagmentSystem.Web.Data
{
    public class LeaveType
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public required string Name { get; set; }
        public int NumberOfDays { get; set; }
        public required string Description { get; set; }
    }
}
