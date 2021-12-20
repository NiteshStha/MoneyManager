using System.ComponentModel.DataAnnotations;

namespace MoneyManager.Models
{
  public class Income
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Source is required")]
    public string Source { get; set; }

    [Required(ErrorMessage = "Amount is required")]
    public string Amount { get; set; }
  }
}