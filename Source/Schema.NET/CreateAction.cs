namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of deliberately creating/producing/generating/building a result out of the agent.
    /// </summary>
    [DataContract]
    public class CreateAction : Action
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CreateAction";
    }
}
