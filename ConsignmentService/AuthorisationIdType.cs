namespace AuthoritativeInstructionXMLSerialization.ConsignmentService
{
    using System;

    /// <remarks/>
 
    [System.SerializableAttribute()]
 
 
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class AuthorisationIdType
    {
        /// <remarks/>
        public string RailServiceID { get; set; }

        /// <remarks/>
        public DateTime RailServiceDateTime { get; set; }

        /// <remarks/>
        public string Consignment { get; set; }
    }
}