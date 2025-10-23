namespace Spoleto.AddressResolver
{
    /// <summary>Документ организации</summary>
    public record PartyDocuments
    {
        /// <summary>
        /// Свидетельство о регистрации в налоговой
        /// </summary>
        public PartyDocument? FtsRegistration { get; set; }

        /// <summary>
        /// Сведения об учете в налоговом органе
        /// </summary>
        public PartyDocument? FtsReport { get; set; }

        /// <summary>
        /// Свидетельство о регистрации в Пенсионном фонде
        /// </summary>
        public PartyDocument? PfRegistration { get; set; }

        /// <summary>
        /// Свидетельство о регистрации в Фонде соц. страхования
        /// </summary>
        public PartyDocument? SifRegistration { get; set; }

        /// <summary>
        /// Запись в реестре малого и среднего предпринимательства
        /// </summary>
        public PartyDocumentSmb? Smb { get; set; }
    }
}
