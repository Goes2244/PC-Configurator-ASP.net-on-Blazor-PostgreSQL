using System.ComponentModel.DataAnnotations;

namespace PC.Data.Models;

public class OperativnayaPamyat
{
    [Key]
    [Required(ErrorMessage = "Модель обязательна")]
    [StringLength(100, ErrorMessage = "Модель не должна превышать 100 символов")]
    public string Model { get; set; } = string.Empty;

    [Required(ErrorMessage = "Тип обязателен")]
    [StringLength(20, ErrorMessage = "Тип не должен превышать 20 символов")]
    public string Tip { get; set; } = string.Empty;

    [Required(ErrorMessage = "Объем обязателен")]
    [Range(1, 256, ErrorMessage = "Объем должен быть от 1 до 256 ГБ")]
    public int ObyomModulyaGb { get; set; }

    [Required(ErrorMessage = "Частота обязательна")]
    [Range(800, 10000, ErrorMessage = "Частота должна быть от 800 до 10000 МГц")]
    public int ChastotaMgts { get; set; }

    [Required(ErrorMessage = "Цена обязательна")]
    [Range(0.01, 999999.99, ErrorMessage = "Цена должна быть больше 0")]
    public decimal Tsena { get; set; }
}