using System.ComponentModel.DataAnnotations;

namespace PC.Data.Models;

/// <summary>
/// Представляет сущность корпуса системного блока в системе подбора компьютерных компонентов.
/// Определяет физические ограничения и совместимость с компонентами по размерам.
/// </summary>
public class Korpus
{
    /// <summary>
    /// Уникальный идентификатор модели корпуса.
    /// </summary>
    /// <value>Строка, содержащая название модели. Не должна превышать 100 символов.</value>
    /// <example>Lian Li PC-O11 Dynamic</example>
    [Key]
    [Required(ErrorMessage = "Модель обязательна")]
    [StringLength(100, ErrorMessage = "Модель не должна превышать 100 символов")]
    public string Model { get; set; } = string.Empty;

    /// <summary>
    /// Форм-факторы материнских плат, поддерживаемые корпусом.
    /// </summary>
    /// <value>Строка, содержащая перечень поддерживаемых форм-факторов. Не должна превышать 200 символов.</value>
    /// <example>ATX, Micro-ATX, Mini-ITX</example>
    [Required(ErrorMessage = "Поддерживаемые форм-факторы обязательны")]
    [StringLength(200, ErrorMessage = "Форм-факторы не должны превышать 200 символов")]
    public string PodderzhivayemyyeFormFaktory { get; set; } = string.Empty;

    /// <summary>
    /// Габаритные размеры корпуса.
    /// </summary>
    /// <value>Строка, содержащая размеры. Не должна превышать 100 символов.</value>
    /// <example>445×272×459 мм</example>
    [Required(ErrorMessage = "Размеры обязательны")]
    [StringLength(100, ErrorMessage = "Размеры не должны превышать 100 символов")]
    public string Razmery { get; set; } = string.Empty;

    /// <summary>
    /// Стоимость корпуса в рублях (или другой валюте).
    /// </summary>
    /// <value>Десятичное число от 0.01 до 1000000.00.</value>
    /// <example>14999.99</example>
    [Required(ErrorMessage = "Цена обязательна")]
    [Range(0.01, 1000000.00, ErrorMessage = "Цена должна быть больше 0")]
    public decimal Tsena { get; set; }
}