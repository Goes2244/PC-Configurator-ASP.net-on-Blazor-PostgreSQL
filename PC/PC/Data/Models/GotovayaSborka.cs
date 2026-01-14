using System.ComponentModel.DataAnnotations;

namespace PC.Data.Models;

/// <summary>
/// Представляет сущность готовой компьютерной сборки, состоящей из совместимых компонентов.
/// Интегрирует все отдельные компоненты в единую конфигурацию с расчетом общих характеристик.
/// </summary>
public class GotovayaSborka
{
    /// <summary>
    /// Уникальный идентификатор сборки.
    /// </summary>
    /// <value>Строка, содержащая ID сборки. Не должна превышать 50 символов.</value>
    /// <example>GAMING_PC_001</example>
    [Key]
    [Required(ErrorMessage = "ID сборки обязателен")]
    [StringLength(50, ErrorMessage = "ID сборки не должен превышать 50 символов")]
    public string IdSborki { get; set; } = string.Empty;

    /// <summary>
    /// Модель материнской платы, используемой в сборке.
    /// </summary>
    /// <value>Строка, содержащая модель материнской платы.</value>
    [Required(ErrorMessage = "Материнская плата обязательна")]
    public string MaterinskayaPlataModel { get; set; } = string.Empty;

    /// <summary>
    /// Модель процессора, используемого в сборке.
    /// </summary>
    /// <value>Строка, содержащая модель процессора.</value>
    [Required(ErrorMessage = "Процессор обязателен")]
    public string ProtsessorModel { get; set; } = string.Empty;

    /// <summary>
    /// Модель оперативной памяти, используемой в сборке.
    /// </summary>
    /// <value>Строка, содержащая модель оперативной памяти.</value>
    [Required(ErrorMessage = "Оперативная память обязательна")]
    public string OperativnayaPamyatModel { get; set; } = string.Empty;

    /// <summary>
    /// Модель видеокарты, используемой в сборке.
    /// </summary>
    /// <value>Строка, содержащую модель видеокарты.</value>
    [Required(ErrorMessage = "Видеокарта обязательна")]
    public string VideokartaModel { get; set; } = string.Empty;

    /// <summary>
    /// Модель накопителя, используемого в сборке.
    /// </summary>
    /// <value>Строка, содержащая модель накопителя.</value>
    [Required(ErrorMessage = "Накопитель обязателен")]
    public string NakopitelModel { get; set; } = string.Empty;

    /// <summary>
    /// Модель блока питания, используемого в сборке.
    /// </summary>
    /// <value>Строка, содержащая модель блока питания.</value>
    [Required(ErrorMessage = "Блок питания обязателен")]
    public string BlokPitaniyaModel { get; set; } = string.Empty;

    /// <summary>
    /// Модель корпуса, используемого в сборке.
    /// </summary>
    /// <value>Строка, содержащая модель корпуса.</value>
    [Required(ErrorMessage = "Корпус обязателен")]
    public string KorpusModel { get; set; } = string.Empty;

    /// <summary>
    /// Общая вычислительная мощность сборки (качественная оценка).
    /// </summary>
    /// <value>Строка, описывающая уровень производительности. Не должна превышать 50 символов.</value>
    /// <example>Высокая</example>
    [Required(ErrorMessage = "Вычислительная мощность обязательна")]
    [StringLength(50, ErrorMessage = "Вычислительная мощность не должна превышать 50 символов")]
    public string VychislitelnayaMoshchnost { get; set; } = string.Empty;

    /// <summary>
    /// Суммарная стоимость всех компонентов сборки.
    /// </summary>
    /// <value>Десятичное число от 0.01 до 10000000.00.</value>
    /// <example>215999.50</example>
    [Required(ErrorMessage = "Общая стоимость обязательна")]
    [Range(0.01, 10000000.00, ErrorMessage = "Общая стоимость должна быть больше 0")]
    public decimal ObshchayaStoimost { get; set; }

    /// <summary>
    /// Общая потребляемая мощность сборки в ваттах.
    /// </summary>
    /// <value>Целое число от 100 до 2000 Вт.</value>
    /// <example>750</example>
    [Required(ErrorMessage = "Мощность обязательна")]
    [Range(100, 2000, ErrorMessage = "Мощность должна быть от 100 до 2000 Вт")]
    public int MoshnostVt { get; set; }
}