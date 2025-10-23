namespace Spoleto.AddressResolver
{
    /// <summary>
    /// ФИО индивидуального предпринимателя.
    /// </summary>
    public record PartyFio
    {
        /// <summary>Фамилия</summary>
        public string Surname { get; set; }

        /// <summary>Имя</summary>
        public string Name { get; set; }

        /// <summary>Отчество</summary>
        public string Patronymic { get; set; }

        /// <summary>Пол</summary>
        public string Gender { get; set; }
    }
}
