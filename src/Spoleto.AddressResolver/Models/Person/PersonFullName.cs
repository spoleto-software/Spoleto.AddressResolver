namespace Spoleto.AddressResolver
{
    /// <summary>
    /// ФИО.
    /// </summary>
    public class PersonFullName
    {
        /// <summary>
        /// Исходное ФИО одной строкой
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Стандартизованное ФИО одной строкой
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// ФИО в родительном падеже (кого?)
        /// </summary>
        public string ResultGenitive { get; set; }

        /// <summary>
        /// ФИО в дательном падеже (кому?)
        /// </summary>
        public string ResultDative { get; set; }

        /// <summary>
        /// ФИО в творительном падеже (кем?)
        /// </summary>
        public string ResultAblative { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Пол: М — мужской, Ж — женский, НД — не удалось определить
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Код проверки (0 — уверенно, 1 — требуется ручная проверка)
        /// </summary>
        public int? QualityCode { get; set; }
    }
}
