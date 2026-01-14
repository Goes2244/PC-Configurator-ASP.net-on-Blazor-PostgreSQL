using System.ComponentModel.DataAnnotations;

namespace PC.Data.Models;

/// <summary>
/// Представляет сущность материнской платы в системе подбора компьютерных компонентов.
/// Является центральным компонентом, определяющим совместимость всех остальных элементов сборки.
/// </summary>
public class MaterinskayaPlata
{
    /// <summary>
    /// Уникальный идентификатор модели материнской платы.
    /// </summary>
    /// <value>Строка, содержащая название модели. Не должна превышать 100 символов.</value>
    /// <example>ASUS ROG Maximus Z790 Hero</example>
    [Key]
    [Required(ErrorMessage = "Модель обязательна")]
    [StringLength(100, ErrorMessage = "Модель не должна превышать 100 символов")]
    public string Model { get; set; } = string.Empty;

    /// <summary>
    /// Стандарт размеров и расположения креплений материнской платы.
    /// </summary>
    /// <value>Строка, содержащая форм-фактор. Не должна превышать 50 символов.</value>
    /// <example>ATX</example>
    [Required(ErrorMessage = "Форм-фактор обязателен")]
    [StringLength(50, ErrorMessage = "Форм-фактор не должен превышать 50 символов")]
    public string FormFaktor { get; set; } = string.Empty;

    /// <summary>
    /// Тип сокета для установки процессора.
    /// </summary>
    /// <value>Строка, содержащая тип сокета. Не должна превышать 50 символов.</value>
    /// <example>LGA 1700</example>
    [Required(ErrorMessage = "Сокет обязателен")]
    [StringLength(50, ErrorMessage = "Сокет не должен превышать 50 символов")]
    public string Soket { get; set; } = string.Empty;

    /// <summary>
    /// Тип поддерживаемой оперативной памяти.
    /// </summary>
    /// <value>Строка, содержащая тип ОЗУ. Не должна превышать 50 символов.</value>
    /// <example>DDR5</example>
    [Required(ErrorMessage = "Тип ОЗУ обязателен")]
    [StringLength(50, ErrorMessage = "Тип ОЗУ не должен превышать 50 символов")]
    public string TipPodderzhivayemoyOzu { get; set; } = string.Empty;

    /// <summary>
    /// Максимальный общий объем оперативной памяти, поддерживаемый платой.
    /// </summary>
    /// <value>Целое число от 1 до 2048 ГБ.</value>
    /// <example>128</example>
    [Required(ErrorMessage = "Макс. объем ОЗУ обязателен")]
    [Range(1, 2048, ErrorMessage = "Объем должен быть от 1 до 2048 ГБ")]
    public int MaksimalnyyObyomOzuGb { get; set; }

    /// <summary>
    /// Типы поддерживаемых накопителей (интерфейсы подключения).
    /// </summary>
    /// <value>Строка, содержащая типы накопителей. Не должна превышать 100 символов.</value>
    /// <example>M.2 NVMe, SATA 3.0</example>
    [Required(ErrorMessage = "Тип накопителей обязателен")]
    [StringLength(100, ErrorMessage = "Тип накопителей не должен превышать 100 символов")]
    public string TipPodderzhivayemixNakopiteli { get; set; } = string.Empty;

    /// <summary>
    /// Стоимость материнской платы в рублях (или другой валюте).
    /// </summary>
    /// <value>Десятичное число от 0.01 до 1000000.00.</value>
    /// <example>54999.99</example>
    [Required(ErrorMessage = "Цена обязательна")]
    [Range(0.01, 1000000.00, ErrorMessage = "Цена должна быть больше 0")]
    public decimal Tsena { get; set; }
}