using System.ComponentModel.DataAnnotations;

namespace PC.Data.Models;

/// <summary>
/// Представляет сущность видеокарты в системе подбора компьютерных компонентов.
/// Определяет графические возможности сборки, важные для игр и профессиональных приложений.
/// </summary>
public class Videokarta
{
    /// <summary>
    /// Уникальный идентификатор модели видеокарты.
    /// </summary>
    /// <value>Строка, содержащая название модели. Не должна превышать 100 символов.</value>
    /// <example>NVIDIA GeForce RTX 4090</example>
    [Key]
    [Required(ErrorMessage = "Модель обязательна")]
    [StringLength(100, ErrorMessage = "Модель не должна превышать 100 символов")]
    public string Model { get; set; } = string.Empty;

    /// <summary>
    /// Уровень вычислительной мощности видеокарты (качественная оценка).
    /// </summary>
    /// <value>Строка, описывающая уровень производительности. Не должна превышать 50 символов.</value>
    /// <example>Экстремальная</example>
    [Required(ErrorMessage = "Вычислительная мощность обязательна")]
    [StringLength(50, ErrorMessage = "Вычислительная мощность не должна превышать 50 символов")]
    public string VychislitelnayaMoshchnost { get; set; } = string.Empty;

    /// <summary>
    /// Объем видеопамяти в гигабайтах.
    /// </summary>
    /// <value>Целое число от 1 до 48 ГБ.</value>
    /// <example>24</example>
    [Required(ErrorMessage = "Объем памяти обязателен")]
    [Range(1, 48, ErrorMessage = "Объем памяти должен быть от 1 до 48 ГБ")]
    public int ObyemPamyatiGb { get; set; }

    /// <summary>
    /// Тепловая мощность (TDP) видеокарты в ваттах.
    /// </summary>
    /// <value>Целое число от 50 до 1000 Вт.</value>
    /// <example>450</example>
    [Required(ErrorMessage = "Мощность обязательна")]
    [Range(50, 1000, ErrorMessage = "Мощность должна быть от 50 до 1000 Вт")]
    public int Moshchnost { get; set; }

    /// <summary>
    /// Стоимость видеокарты в рублях (или другой валюте).
    /// </summary>
    /// <value>Десятичное число от 0.01 до 1000000.00.</value>
    /// <example>199999.99</example>
    [Required(ErrorMessage = "Цена обязательна")]
    [Range(0.01, 1000000.00, ErrorMessage = "Цена должна быть больше 0")]
    public decimal Tsena { get; set; }
}