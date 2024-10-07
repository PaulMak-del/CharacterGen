using System;

namespace DAL.Entities
{
    /**
     * Сущность "Происхождение". Содержит основную информацию о происхождении персонажа, например: "Благородный" 
     */
    public class Background
    {
        /** Идентификатор записи */
        public Guid Id { get; set; }

        /** Название происхождения */
        public string Name { get; set; }
    }
}