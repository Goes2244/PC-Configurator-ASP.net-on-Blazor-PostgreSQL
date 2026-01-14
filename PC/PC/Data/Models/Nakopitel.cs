using System.ComponentModel.DataAnnotations;

namespace PC.Data.Models;

/// <summary>
/// Представляет сущность накопителя данных (SSD/HDD) в системе подбора компьютерных компонентов.
/// Определяет характеристики устройства хранения данных.
/// </summary>
public class Nakopitel
{
    /// <summary>
    /// Уникальный идентификатор модели накопителя.
    /// </summary>
    /// <value>Строка, содержащая название модели. Не должна превышать 100 символов.</value>
    /// <example>Samsung 990 PRO 2TB</example>
    [Key]
    [Required(ErrorMessage = "Модель обязательна")]
    [StringLength(100, ErrorMessage = "Модель не должна превышать 100 символов")]
    public string Model { get; set; } = string.Empty;

    /// <summary>
    /// Тип накопителя (технология и форм-фактор).
    /// </summary>
    /// <value>Строка, содержащая тип накопителя. Не должна превышать 20 символов.</value>
    /// <example>NVMe SSD</example>
    [Required(ErrorMessage = "Тип обязателен")]
    [StringLength(20, ErrorMessage = "Тип не должен превышать 20 символов")]
    public string Tip { get; set; } = string.Empty;

    /// <summary>
    /// Емкость накопителя в гигабайтах.
    /// </summary>
    /// <value>Целое число от 1 до 20000 ГБ.</value>
    /// <example>2048</example>
    [Required(ErrorMessage = "Объем обязателен")]
    [Range(1, 20000, ErrorMessage = "Объем должен быть от 1 до 20000 ГБ")]
    public int ObyomGb { get; set; }

    /// <summary>
    /// Скорость последовательного чтения данных в мегабайтах в секунду.
    /// </summary>
    /// <value>Целое число от 10 до 15000 МБ/с.</value>
    /// <example>7450</example>
    [Required(ErrorMessage = "Скорость чтения обязательна")]
    [Range(10, 15000, ErrorMessage = "Скорость чтения должна быть от 10 до 15000 МБ/с")]
    public int SkorostChteniyaMbS { get; set; }

    /// <summary>
    /// Скорость последовательной записи данных в мегабайтах в секунду.
    /// </summary>
    /// <value>Целое число от 10 до 15000 МБ/с.</value>
    /// <example>6900</example>
    [Required(ErrorMessage = "Скорость записи обязательна")]
    [Range(10, 15000, ErrorMessage = "Скорость записи должна быть от 10 до 15000 МБ/с")]
    public int SkorostZapisiMbS { get; set; }

    /// <summary>
    /// Стоимость накопителя в рублях (или другой валюте).
    /// </summary>
    /// <value>Десятичное число от 0.01 до 1000000.00.</value>
    /// <example>18999.99</example>
    [Required(ErrorMessage = "Цена обязательна")]
    [Range(0.01, 1000000.00, ErrorMessage = "Цена должна быть больше 0")]
    public decimal Tsena { get; set; }
}