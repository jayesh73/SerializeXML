namespace AuthoritativeInstructionXMLSerialization.ConsignmentService
{
    /// <remarks/>
 
    [System.SerializableAttribute()]
 
 
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class AuthoritativeInstructionActionCreate
    {
        /// <remarks/>
        public CreateType Instruction { get; set; }

        /// <remarks/>
        public CoalMetadataType CoalMetadata { get; set; }

        /// <remarks/>
        public LoadOutDetailsType LoadOutDetails { get; set; }

        /// <remarks/>
        public CommentType CreateComment { get; set; }
    }
}