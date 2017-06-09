namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A specific branch of medical science that is concerned with the diagnosis and treatment of diseases, debilities and provision of care to the aged.
    /// </summary>
    [DataContract]
    public class Geriatric : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Geriatric";
    }
}
