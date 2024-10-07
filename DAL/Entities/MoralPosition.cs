

using System.ComponentModel.DataAnnotations;

/**
 * Сущность "Моральная позиция". Содержит основную информацию о моральных позициях.
 */
public class MoralPosition
{
    /**
     * Идентификатор записи.
     */
    [Key]
    public Guid Id { get; set; }

    /**
     * Название моральной позиции.
     */
    public string Name { get; set; }
}