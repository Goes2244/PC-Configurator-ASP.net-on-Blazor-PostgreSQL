using Microsoft.EntityFrameworkCore;
using PC.Data.Models;

namespace PC.Data;

/// <summary>
/// Контекст базы данных для системы подбора и конфигурации компьютерных сборок.
/// Наследуется от <see cref="DbContext"/> и предоставляет доступ ко всем сущностям системы.
/// </summary>
/// <remarks>
/// Этот класс отвечает за сопоставление классов модели с таблицами базы данных и управление подключением к БД.
/// Все сущности регистрируются через свойства <see cref="DbSet{TEntity}"/> и конфигурируются в методе <see cref="OnModelCreating"/>.
/// </remarks>
public class AppDbContext : DbContext
{
    /// <summary>
    /// Инициализирует новый экземпляр <see cref="AppDbContext"/> с указанными параметрами.
    /// </summary>
    /// <param name="options">Параметры контекста базы данных, включая строку подключения и настройки провайдера.</param>
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    /// <summary>
    /// Представляет набор материнских плат в базе данных.
    /// </summary>
    /// <value>Доступ к коллекции сущностей <see cref="MaterinskayaPlata"/>.</value>
    public DbSet<MaterinskayaPlata> MaterinskiyePlaty { get; set; }
    
    /// <summary>
    /// Представляет набор процессоров в базе данных.
    /// </summary>
    /// <value>Доступ к коллекции сущностей <see cref="Protsessor"/>.</value>
    public DbSet<Protsessor> Protsessory { get; set; }
    
    /// <summary>
    /// Представляет набор модулей оперативной памяти в базе данных.
    /// </summary>
    /// <value>Доступ к коллекции сущностей <see cref="OperativnayaPamyat"/>.</value>
    public DbSet<OperativnayaPamyat> OperativnayaPamyati { get; set; }
    
    /// <summary>
    /// Представляет набор видеокарт в базе данных.
    /// </summary>
    /// <value>Доступ к коллекции сущностей <see cref="Videokarta"/>.</value>
    public DbSet<Videokarta> Videokarty { get; set; }
    
    /// <summary>
    /// Представляет набор накопителей данных в базе данных.
    /// </summary>
    /// <value>Доступ к коллекции сущностей <see cref="Nakopitel"/>.</value>
    public DbSet<Nakopitel> Nakopiteli { get; set; }
    
    /// <summary>
    /// Представляет набор блоков питания в базе данных.
    /// </summary>
    /// <value>Доступ к коллекции сущностей <see cref="BlokPitaniya"/>.</value>
    public DbSet<BlokPitaniya> BlokiPitaniya { get; set; }
    
    /// <summary>
    /// Представляет набор корпусов в базе данных.
    /// </summary>
    /// <value>Доступ к коллекции сущностей <see cref="Korpus"/>.</value>
    public DbSet<Korpus> Korpusa { get; set; }
    
    /// <summary>
    /// Представляет набор готовых сборок компьютеров в базе данных.
    /// </summary>
    /// <value>Доступ к коллекции сущностей <see cref="GotovayaSborka"/>.</value>
    public DbSet<GotovayaSborka> GotovyyeSborki { get; set; }

    /// <summary>
    /// Настраивает модель базы данных при ее создании.
    /// </summary>
    /// <param name="modelBuilder">Конструктор модели, используемый для настройки сопоставления сущностей с таблицами.</param>
    /// <remarks>
    /// В этом методе выполняется:
    /// 1. Вызов базовой реализации <see cref="DbContext.OnModelCreating(ModelBuilder)"/>.
    /// 2. Сопоставление каждого класса сущности с соответствующей таблицей в базе данных через <see cref="EntityTypeBuilder.ToTable(string)"/>.
    /// 3. Установка имен таблиц в соответствии с соглашениями именования (с использованием подчеркиваний для разделения слов).
    /// </remarks>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<MaterinskayaPlata>().ToTable("materinskiye_platy");
        modelBuilder.Entity<Protsessor>().ToTable("protsessory");
        modelBuilder.Entity<OperativnayaPamyat>().ToTable("operativnaya_pamyat");
        modelBuilder.Entity<Videokarta>().ToTable("videokarty");
        modelBuilder.Entity<Nakopitel>().ToTable("nakopiteli");
        modelBuilder.Entity<BlokPitaniya>().ToTable("bloki_pitaniya");
        modelBuilder.Entity<Korpus>().ToTable("korpusa");
        modelBuilder.Entity<GotovayaSborka>().ToTable("gotovyye_sborki");
    }
}