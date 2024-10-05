using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    /**
     * Сущность "Раса". Содержит основную информацию о расах персонажа, например: "Человек", "Эльф" или "Дворф"
     */
    public class Race
    {
        /** Идентификатор записи */
        public Guid Id { get; set; }

        /** Название расы */
        public string Name { get; set; }
    }
}
