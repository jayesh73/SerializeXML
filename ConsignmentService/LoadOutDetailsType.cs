namespace AuthoritativeInstructionXMLSerialization.ConsignmentService
{
    using System;

    /// <remarks/>
 
    [System.SerializableAttribute()]
 
 
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class LoadOutDetailsType
    {
        /// <remarks/>
        public string LoadLocation { get; set; }

        /// <remarks/>
        public uint TonnesLoaded { get; set; }

        /// <remarks/>
        public string LoadOutOperator { get; set; }

        /// <remarks/>
        public DateTime LoadCompleteDateTime { get; set; }

        /// <remarks/>
        public string UnloadInstruction { get; set; }
    }
}