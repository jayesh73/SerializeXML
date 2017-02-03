namespace AuthoritativeInstructionXMLSerialization.ConsignmentService
{
    using System;

    /// <remarks/>
 
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class AuthoritativeInstructionHeader
    {
        /// <remarks/>
        public CustomerAuthorityType CustomerAuthority { get; set; }

        /// <remarks/>
        public AuthorisationIdType Identifier { get; set; }

        /// <remarks/>
        public DateTime MessageTimeStamp { get; set; }
    }
}