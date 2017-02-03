namespace AuthoritativeInstructionXMLSerialization.ConsignmentService
{
    /// <remarks/>
 
    [System.SerializableAttribute()]
 
 
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class CreateType
    {
        /// <remarks/>
        public WagonType FirstWagon { get; set; }

        /// <remarks/>
        public WagonType LastWagon { get; set; }

        /// <remarks/>
        public uint Count { get; set; }

        /// <remarks/>
        public uint Stockpile { get; set; }
    }
}