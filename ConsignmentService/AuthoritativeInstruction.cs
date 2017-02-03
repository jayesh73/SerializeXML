namespace AuthoritativeInstructionXMLSerialization.ConsignmentService
{
    using System.Xml.Linq;

    /// <summary>
    /// The authoritative instruction.
    /// </summary>
    /// <remarks>
    /// </remarks>
 
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService", IsNullable = false)]
    public partial class AuthoritativeInstruction
    {
        /// <remarks/>
        public AuthoritativeInstructionHeader Header { get; set; }

        /// <remarks/>
        public AuthoritativeInstructionAction Action { get; set; }
        
    }
}