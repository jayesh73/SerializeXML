namespace AuthoritativeInstructionXMLSerialization.ConsignmentService
{
    /// <remarks/>
 
    [System.SerializableAttribute()]
 
 
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class AuthoritativeInstructionActionCancel
    {
        /// <remarks/>
        public CancelType Instruction { get; set; }

        /// <remarks/>
        public CommentType CancellationComment { get; set; }
    }
}