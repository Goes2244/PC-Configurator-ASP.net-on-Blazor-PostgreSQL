using System.ComponentModel.DataAnnotations;

namespace PC.Data.Models;

/// <summary>
/// Представляет сущность процессора в системе подбора компьютерных компонентов.
/// Содержит технические характеристики, необходимые для совместимости с другими компонентами.
/// </summary>
/// <remarks>
/// Модель процессора используется как первичный ключ (<see cref="KeyAttribute"/>).
/// Все свойства имеют аннотации валидации для обеспечения корректности данных.
/// </remarks>
public class Protsessor
{
    /// <summary>
    /// Уникальный идентификатор модели процессора.
    /// </summary>
    /// <value>Строка, содержащая название модели процессора. Не должна превышать 100 символов.</value>
    /// <example>Intel Core i9-13900K</example>
    [Key]
    [Required(ErrorMessage = "Модель обязательна")]
    [StringLength(100, ErrorMessage = "Модель не должна превышать 100 символов")]
    public string Model { get; set; } = string.Empty;

    /// <summary>
    /// Тип сокета, который определяет совместимость с материнской платой.
    /// </summary>
    /// <value>Строка, содержащая тип сокета. Не должна превышать 50 символов.</value>
    /// <example>LGA 1700</example>
    [Required(ErrorMessage = "Сокет обязателен")]
    [StringLength(50, ErrorMessage = "Сокет не должен превышать 50 символов")]
    public string Soket { get; set; } = string.Empty;

    /// <summary>
    /// Тепловая мощность (TDP) процессора в ваттах.
    /// </summary>
    /// <value>Целое число от 1 до 500 Вт.</value>
    /// <example>125</example>
    [Required(ErrorMessage = "Мощность обязательна")]
    [Range(1, 500, ErrorMessage = "Мощность должна быть от 1 до 500 Вт")]
    public int Moshchnost { get; set; }

    /// <summary>
    /// Базовая тактовая частота процессора в гигагерцах.
    /// </summary>
    /// <value>Десятичное число от 0.1 до 10.0 ГГц.</value>
    /// <example>3.5</example>
    [Required(ErrorMessage = "Тактовая частота обязательна")]
    [Range(0.1, 10.0, ErrorMessage = "Частота должна быть от 0.1 до 10.0 ГГц")]
    public decimal TaktovayaChastotaGz { get; set; }

    /// <summary>
    /// Количество физических ядер процессора.
    /// </summary>
    /// <value>Целое число от 1 до 128 ядер.</value>
    /// <example>24</example>
    [Required(ErrorMessage = "Количество ядер обязательно")]
    [Range(1, 128, ErrorMessage = "Количество ядер должно быть от 1 до 128")]
    public int KolichestvoYader { get; set; }

    /// <summary>
    /// Стоимость процессора в рублях (или другой валюте).
    /// </summary>
    /// <value>Десятичное число от 0.01 до 1000000.00.</value>
    /// <example>45999.99</example>
    [Required(ErrorMessage = "Цена обязательна")]
    [Range(0.01, 1000000.00, ErrorMessage = "Цена должна быть больше 0 и не больше 1 миллиона")]
    public decimal Tsena { get; set; }
}