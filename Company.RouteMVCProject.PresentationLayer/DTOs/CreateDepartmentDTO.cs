using System.ComponentModel.DataAnnotations;

namespace Company.RouteMVCProject.PresentationLayer.DTOs
{
    public class CreateDepartmentDTO
    {
        [Required(ErrorMessage ="Code is Required !!")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name is Required !!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Create At is Required !!")]
        public DateTime CreateAt { get; set; }
    }
}
