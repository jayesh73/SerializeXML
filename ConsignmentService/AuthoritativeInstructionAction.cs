namespace AuthoritativeInstructionXMLSerialization.ConsignmentService
{
    using System.Xml.Linq;

    /// <remarks/>
 
    [System.SerializableAttribute()]
 
 
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class AuthoritativeInstructionAction
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cancel", typeof(AuthoritativeInstructionActionCancel)), System.Xml.Serialization.XmlElementAttribute("Create", typeof(AuthoritativeInstructionActionCreate)), System.Xml.Serialization.XmlElementAttribute("Info", typeof(AuthoritativeInstructionActionInfo)), System.Xml.Serialization.XmlElementAttribute("Update", typeof(AuthoritativeInstructionActionUpdate))]
        public object Item { get; set; }
    }
}