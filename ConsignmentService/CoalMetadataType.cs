namespace AuthoritativeInstructionXMLSerialization.ConsignmentService
{
    /// <remarks/>
 
    [System.SerializableAttribute()]
 
 
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class CoalMetadataType
    {
        /// <remarks/>
        public string CoalType { get; set; }

        /// <remarks/>
        public CoalMetadataTypeCoalProperty CoalProperty { get; set; }

        /// <remarks/>
        public float Moisture { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MoistureSpecified { get; set; }

        /// <remarks/>
        public float Ash { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AshSpecified { get; set; }
    }
}