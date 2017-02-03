namespace AuthoritativeInstructionXMLSerialization.ConsignmentService
{
    /// <remarks/>
 
    [System.SerializableAttribute()]
 
 
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class CustomerAuthorityType
    {
        /// <remarks/>
        public string DispatchingMine { get; set; }

        /// <remarks/>
        public string DispatchingCustomer { get; set; }

        /// <remarks/>
        public string UnloadLocation { get; set; }
    }
}