using System.ComponentModel.DataAnnotations;

namespace MoneyManager.Models
{
  public class Expenditure
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Amount is required")]
    public string Amount { get; set; }
  }
}