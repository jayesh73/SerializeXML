namespace AuthoritativeInstructionXMLSerialization.ConsignmentService
{
    /// <remarks/>
 
    [System.SerializableAttribute()]
 
 
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class WagonType
    {
        public WagonType()
        {
            this.Type = WagonTypeType.Wagon;
        }

        /// <remarks/>
        public int Sequence { get; set; }

        /// <remarks/>
        public uint Number { get; set; }

        /// <remarks/>
        public WagonTypeType Type { get; set; }

        /// <remarks/>
        public string Class { get; set; }
    }
}