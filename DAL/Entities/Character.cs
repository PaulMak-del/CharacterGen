using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DAL.Entities;

/**
 * Сущность "Персонаж". Содержит основную информацию о персонаже.
 */
public class Character
{
    /**
     * Идентификатор записи.
     */
    [Key]
    public Guid Id { get; set; }

    /**
     * Имя персонажа.
     */
    public string Name { get; set; }

    /**
     * Полное имя персонажа.
     */
    public string FullName { get; set; }

    /**
     * Возраст персонажа.
     */
    public int Age { get; set; }

    /**
     * Рост персонажа.
     */
    public int Height { get; set; }

    /**
     * Вес персонажа.
     */
    public int Weight { get; set; }

    /**
     * Пол персонажа.
     */
    public string Gender { get; set; }

    /**
     * Уровень персонажа.
     */
    public int Level { get; set; }

    /**
     * Опыт персонажа.
     */
    public int Expiriance { get; set; }

    /**
     * Путь к изображению персонажа.
     */
    public string PathToImage { get; set; }

    /**
     * Внешний ключ для навыков персонажа.
     */
    [ForeignKey("SkillsId")]
    public Guid SkillsId { get; set; }

    /**
     * Навыки персонажа.
     */
    public virtual Skills Skills { get; set; }

    /**
     * Внешний ключ для характеристик персонажа.
     */
    [ForeignKey("StatsId")]
    public Guid StatsId { get; set; }

    /**
     * Характеристики персонажа.
     */
    public virtual Stats Stats { get; set; }

    /**
     * Внешний ключ для спасбросков персонажа.
     */
    [ForeignKey("SavingThrowsId")]
    public Guid SavingThrowsId { get; set; }

    /**
     * Спасброски персонажа.
     */
    public virtual SavingThrows SavingThrows { get; set; }

    /**
     * Внешний ключ для расы персонажа.
     */
    [ForeignKey("RaceId")]
    public Guid RaceId { get; set; }

    /**
     * Раса персонажа.
     */
    public virtual Race Race { get; set; }

    /**
     * Внешний ключ для происхождения персонажа.
     */
    [ForeignKey("BackgroundId")]
    public Guid BackgroundId { get; set; }

    /**
     * Происхождение персонажа.
     */
    public virtual Background Background { get; set; }
}