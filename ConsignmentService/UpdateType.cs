namespace AuthoritativeInstructionXMLSerialization.ConsignmentService
{
    /// <remarks/>
 
    [System.SerializableAttribute()]
 
 
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class UpdateType
    {
        /// <remarks/>
        public WagonType NewFirstWagon { get; set; }

        /// <remarks/>
        public WagonType NewLastWagon { get; set; }

        /// <remarks/>
        public uint NewCount { get; set; }

        /// <remarks/>
        public uint NewStockpile { get; set; }
    }
}