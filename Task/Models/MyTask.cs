using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    public class MyTask
    {
        public int MyTaskId { get; set; }
        
        [Required(ErrorMessage = "Task name is requires")]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Description is required")]
        [StringLength(60)]
        public string Description { get; set; }
    }
}