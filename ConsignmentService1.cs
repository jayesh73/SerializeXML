using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    using System.Xml.Serialization;


    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService", IsNullable = false)]
    public partial class ConsignmentService
    {

        /// <remarks/>
        public ConsignmentServiceHeader Header;

        /// <remarks/>
        public ConsignmentServiceBody Body;
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class ConsignmentServiceHeader
    {

        /// <remarks/>
        public ConsignmentServiceHeaderReference Reference;

        /// <remarks/>
        public PartyType Sender;

        /// <remarks/>
        public ConsignmentServiceHeaderReceiver Receiver;
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class ConsignmentServiceHeaderReference : ReferenceType
    {
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class ReferenceType
    {

        /// <remarks/>
        public IdentifierType Identifier;

        /// <remarks/>
        public System.DateTime DateTime;
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class IdentifierType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class LastWagonType
    {

        /// <remarks/>
        public LastWagonTypeWagon Wagon;
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class LastWagonTypeWagon : WagonType
    {
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class WagonType
    {

        /// <remarks/>
        public int Sequence;

        /// <remarks/>
        public string Number;

        /// <remarks/>
        public WagonTypeType Type;

        public WagonType()
        {
            this.Type = WagonTypeType.Wagon;
        }
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public enum WagonTypeType
    {

        /// <remarks/>
        Locomotive,

        /// <remarks/>
        Wagon,

        /// <remarks/>
        Container,

        /// <remarks/>
        Carriage,

        /// <remarks/>
        Nonloadable,

        /// <remarks/>
        Van,
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class FirstWagonType
    {

        /// <remarks/>
        public FirstWagonTypeWagon Wagon;
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class FirstWagonTypeWagon : WagonType
    {
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class ConsignmentType
    {

        /// <remarks/>
        public string ConsignmentNo;

        /// <remarks/>
        public string Customer;

        /// <remarks/>
        public string Mine;

        /// <remarks/>
        public int Stockpile;

        /// <remarks/>
        public string CoalType;

        /// <remarks/>
        public ConsignmentTypeCoalProperty CoalProperty;

        /// <remarks/>
        public string CoalPropertyComment;

        /// <remarks/>
        public float Moisture;

        /// <remarks/>
        public float Ash;

        /// <remarks/>
        public ConsignmentTypeWagons Wagons;

        /// <remarks/>
        public int WagonsLoaded;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string TonnesLoaded;

        /// <remarks/>
        public string LoadLocation;

        /// <remarks/>
        public System.DateTime LoadCompleteDateTime;

        /// <remarks/>
        public string LoadOutOperator;

        /// <remarks/>
        public object UnloadLocation;

        /// <remarks/>
        public string UnloadInstruction;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any;
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public enum ConsignmentTypeCoalProperty
    {

        /// <remarks/>
        Normal,

        /// <remarks/>
        Wet,

        /// <remarks/>
        Sticky,

        /// <remarks/>
        Dry,
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class ConsignmentTypeWagons
    {

        /// <remarks/>
        public FirstWagonType FirstWagon;

        /// <remarks/>
        public LastWagonType LastWagon;
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class ModifierType
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value;
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class PartyType
    {

        /// <remarks/>
        public IdentifierType Identifier;

        /// <remarks/>
        public ModifierType Modifiers;
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class ConsignmentServiceHeaderReceiver : PartyType
    {
    }

    /// <remarks/>

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService")]
    public partial class ConsignmentServiceBody
    {

        /// <remarks/>
        public string ServiceId;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime ServiceDate;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Consignment", IsNullable = false)]
        public ConsignmentType[] Consignments;
    }

