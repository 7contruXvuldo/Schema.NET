namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// </summary>
    [DataContract]
    public class AllocateAction : OrganizeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AllocateAction";
    }
}
