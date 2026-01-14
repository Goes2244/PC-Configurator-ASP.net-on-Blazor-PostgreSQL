using System.ComponentModel.DataAnnotations;

namespace PC.Data.Models;

/// <summary>
/// Представляет сущность блока питания в системе подбора компьютерных компонентов.
/// Определяет характеристики источника электропитания для сборки компьютера.
/// </summary>
/// <remarks>
/// Модель блока питания используется как первичный ключ (<see cref="KeyAttribute"/>).
/// </remarks>
public class BlokPitaniya
{
    /// <summary>
    /// Уникальный идентификатор модели блока питания.
    /// </summary>
    /// <value>Строка, содержащая название модели. Не должна превышать 100 символов.</value>
    /// <example>Seasonic PRIME TX-1000</example>
    [Key]
    [Required(ErrorMessage = "Модель обязательна")]
    [StringLength(100, ErrorMessage = "Модель не должна превышать 100 символов")]
    public string Model { get; set; } = string.Empty;

    /// <summary>
    /// Номинальная мощность блока питания в ваттах.
    /// </summary>
    /// <value>Целое число от 100 до 2000 Вт.</value>
    /// <example>1000</example>
    [Required(ErrorMessage = "Мощность обязательна")]
    [Range(100, 2000, ErrorMessage = "Мощность должна быть от 100 до 2000 Вт")]
    public int MoshchnostVt { get; set; }

    /// <summary>
    /// Сертификат энергоэффективности блока питания (опционально).
    /// </summary>
    /// <value>Строка, содержащая тип сертификации. Не должна превышать 50 символов.</value>
    /// <example>80 PLUS Titanium</example>
    [StringLength(50, ErrorMessage = "Сертификация не должна превышать 50 символов")]
    public string Sertifikatsiya { get; set; } = string.Empty;

    /// <summary>
    /// Стоимость блока питания в рублях (или другой валюте).
    /// </summary>
    /// <value>Десятичное число от 0.01 до 1000000.00.</value>
    /// <example>24999.99</example>
    [Required(ErrorMessage = "Цена обязательна")]
    [Range(0.01, 1000000.00, ErrorMessage = "Цена должна быть больше 0")]
    public decimal Tsena { get; set; }
}