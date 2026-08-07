using System.ComponentModel.DataAnnotations;
using Domain.ValueObjects;
namespace Domain.Entities
{
  public class Attendance
  {
    public int Id { get; set; }
    [Required(ErrorMessage = "Instructor Name is required")]
    public string InstructorName { get; set; }
    [Required(ErrorMessage = "Status is required")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "UserAdded is required")]

    public string UserAdded { get; set; }

    [Required(ErrorMessage = "DateAdded is required")]
    public DateTime DateAdded { get; set; } = DateTime.UtcNow;
    //Prefic should match the Navigation property name
    [Required(ErrorMessage = "Classes is required")]
    public int ClasssId { get; set; }
    public AttendanceStatus Status { get; set; }

    //Nagivation properties
    public Classs Classs { get; set; }

  }
}