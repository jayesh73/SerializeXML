using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthoritativeInstructionXMLSerialization
{
    using System.IO;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    using AuthoritativeInstructionXMLSerialization.ConsignmentService;

    class Program
    {
        private static void Main(string[] args)
        {

            try
            {
                Program p = new Program();
                p.GenerateCreateMessage("createai.xml");
                p.GenerateUpdateMessage("updateai.xml");
                p.GenerateCancelMessage("cancelai.xml");
                p.GenerateInfoMessage("infoai.xml");
                p.SerializeAI("ai.xml");
                p.DeserializeAI("ai.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Generate Sample Authoritative Instruction Create Message
        /// </summary>
        /// <param name="filename"></param>
        private void GenerateCreateMessage(string filename)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("ns", "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService");

            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to serialize.
            var serializer = new XmlSerializer(typeof(AuthoritativeInstruction));
            TextWriter writer = new StreamWriter(filename);

            //Customer Authority Type
            var ca = new CustomerAuthorityType
            {
                DispatchingMine = "Curragh",
                DispatchingCustomer = "Curragh",
                UnloadLocation = "GLD"
            };

            var aid = new AuthorisationIdType { Consignment = "AA24288", RailServiceID = "B53M" };
            var dt = new DateTime(2015, 05, 16);
            aid.RailServiceDateTime = dt; //DateTime.ParseExact(dt.ToString("yyyy-MM-dd"),"yyyy-MM-dd",null);

            var aih = new AuthoritativeInstructionHeader { CustomerAuthority = ca, Identifier = aid };
            var msgDt = DateTime.Now;
            aih.MessageTimeStamp = msgDt;

            var firstwagon = new WagonType { Sequence = 2, Number = 56012, Type = WagonTypeType.Wagon, Class = "VCBS" };

            var lastwagon = new WagonType { Sequence = 104, Number = 49717, Type = WagonTypeType.Wagon, Class = "VSAL" };

            var ct = new CreateType { Count = 102, Stockpile = 661, FirstWagon = firstwagon, LastWagon = lastwagon };

            var cm = new CoalMetadataType
            {
                CoalType = "Curragh Mid Ash",
                CoalProperty = CoalMetadataTypeCoalProperty.Normal,
                Ash = 0.25f,
                AshSpecified = true,
                Moisture = 0.25f,
                MoistureSpecified = true
            };

            var dtNow = DateTime.Now;
            var ld = new LoadOutDetailsType
            {
                LoadLocation = "ALocation",
                LoadOutOperator = "CurraghUser",
                TonnesLoaded = 8328,
                UnloadInstruction = "A Sample Instruction",
                LoadCompleteDateTime = dtNow.AddHours(-1)
            };

            var cc = new CommentType
            {
                ConsignmentComment = "Optional Create Comment"
            };

            var aiCreate = new AuthoritativeInstructionActionCreate
            {
                Instruction = ct,
                CoalMetadata = cm,
                LoadOutDetails = ld,
                CreateComment = cc
            };

            var aiAction = new AuthoritativeInstructionAction { Item = aiCreate };

            var ai = new AuthoritativeInstruction { Action = aiAction, Header = aih };

            /***** To see generated XML Uncomment the code below: ******/

            var sw = new StringWriter();
            var xmlWriter = XmlWriter.Create(sw, new XmlWriterSettings() { OmitXmlDeclaration = true, Indent = true });

            serializer.Serialize(xmlWriter, ai, ns);
            string xmlString = sw.ToString();
            Console.WriteLine("Create Authoritative Instruction XML For Create Message : " + xmlString + " \n\n\n");
        }

        /// <summary>
        /// Generate Sample Authoritative Instruction Update Message
        /// </summary>
        /// <param name="filename"></param>
        private void GenerateUpdateMessage(string filename)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("ns", "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService");

            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to serialize.
            var serializer = new XmlSerializer(typeof(AuthoritativeInstruction));
            TextWriter writer = new StreamWriter(filename);

            //Customer Authority Type
            var ca = new CustomerAuthorityType
            {
                DispatchingMine = "Curragh",
                DispatchingCustomer = "Curragh",
                UnloadLocation = "GLD"
            };

            var aid = new AuthorisationIdType { Consignment = "AA24288", RailServiceID = "B53M" };
            var dt = new DateTime(2015, 05, 16);
            aid.RailServiceDateTime = dt; 

            var aih = new AuthoritativeInstructionHeader { CustomerAuthority = ca, Identifier = aid };
            var msgDt = DateTime.Now;
            aih.MessageTimeStamp = msgDt;

            var newfirstwagon = new WagonType { Sequence = 2, Number = 56012, Type = WagonTypeType.Wagon, Class = "VCBS" };

            var newlastwagon = new WagonType { Sequence = 104, Number = 49717, Type = WagonTypeType.Wagon, Class = "VSAL" };

            var ut = new UpdateType { NewCount = 102, NewStockpile = 661, NewFirstWagon = newfirstwagon, NewLastWagon = newlastwagon };

            var cm = new CoalMetadataType
            {
                CoalType = "Curragh PCI Coal",
                CoalProperty = CoalMetadataTypeCoalProperty.Normal,
                Ash = 0.05f,
                Moisture = 0.05f
            };

            var uc = new CommentType
            {
                ConsignmentComment = "Mendatory Update Comment..."
            };

            var aiUpdate = new AuthoritativeInstructionActionUpdate()
            {
                Instruction = ut,
                CoalMetadata = cm,
                UpdateComment = uc
            };

            var aiAction = new AuthoritativeInstructionAction { Item = aiUpdate };

            var ai = new AuthoritativeInstruction { Action = aiAction, Header = aih };

            var sw = new StringWriter();
            var xmlWriter = XmlWriter.Create(sw, new XmlWriterSettings() { OmitXmlDeclaration = true, Indent = true });

            serializer.Serialize(xmlWriter, ai, ns);
            string xmlString = sw.ToString();
            Console.WriteLine("Authoritative Instruction XML For Update Message : " + xmlString + " \n\n\n");
        }

        /// <summary>
        /// Generate Sample Authoritative Instruction Cancellation Message
        /// </summary>
        /// <param name="filename"></param>
        private void GenerateCancelMessage(string filename)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("ns", "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService");

            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to serialize.
            var serializer = new XmlSerializer(typeof(AuthoritativeInstruction));
            TextWriter writer = new StreamWriter(filename);

            //Customer Authority Type
            var ca = new CustomerAuthorityType
            {
                DispatchingMine = "Curragh",
                DispatchingCustomer = "Curragh",
                UnloadLocation = "GLD"
            };

            var aid = new AuthorisationIdType { Consignment = "AA24288", RailServiceID = "B53M" };
            var dt = new DateTime(2015, 05, 16);
            aid.RailServiceDateTime = dt; 

            var aih = new AuthoritativeInstructionHeader { CustomerAuthority = ca, Identifier = aid };
            var msgDt = DateTime.Now;
            aih.MessageTimeStamp = msgDt;

            var firstwagon = new WagonType { Sequence = 2, Number = 56012, Type = WagonTypeType.Wagon, Class = "VCBS" };

            var lastwagon = new WagonType { Sequence = 104, Number = 49717, Type = WagonTypeType.Wagon, Class = "VSAL" };

            var ct = new CancelType { Count = 102, Stockpile = 661, FirstWagon = firstwagon, LastWagon = lastwagon };

            var cc = new CommentType
            {
                ConsignmentComment = "Mendatory Cancellation Comment..."
            };

            var aiCancel = new AuthoritativeInstructionActionCancel()
            {
                Instruction = ct,
                CancellationComment = cc
            };

            var aiAction = new AuthoritativeInstructionAction { Item = aiCancel };

            var ai = new AuthoritativeInstruction { Action = aiAction, Header = aih };

            /***** To see generated XML Uncomment the code below: ******/

            var sw = new StringWriter();
            var xmlWriter = XmlWriter.Create(sw, new XmlWriterSettings() { OmitXmlDeclaration = true, Indent = true });

            serializer.Serialize(xmlWriter, ai, ns);
            string xmlString = sw.ToString();
            Console.WriteLine("Authoritative Instruction XML For Cancellation Message : " + xmlString + " \n\n\n");
        }

        /// <summary>
        /// Generate Sample Authoritative Instruction Info Message
        /// </summary>
        /// <param name="filename"></param>
        private void GenerateInfoMessage(string filename)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("ns", "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService");

            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to serialize.
            var serializer = new XmlSerializer(typeof(AuthoritativeInstruction));
            TextWriter writer = new StreamWriter(filename);

            //Customer Authority Type
            var ca = new CustomerAuthorityType
            {
                DispatchingMine = "Curragh",
                DispatchingCustomer = "Curragh",
                UnloadLocation = "GLD"
            };

            var aid = new AuthorisationIdType { Consignment = "AA24288", RailServiceID = "B53M" };
            var dt = new DateTime(2015, 05, 16);
            aid.RailServiceDateTime = dt; 

            var aih = new AuthoritativeInstructionHeader { CustomerAuthority = ca, Identifier = aid };
            var msgDt = DateTime.Now;
            aih.MessageTimeStamp = msgDt;
            
            var aiInfo = new AuthoritativeInstructionActionInfo()
            {
                Message = "This is a New Info Message For Concote: AA24288"
            };

            var aiAction = new AuthoritativeInstructionAction { Item = aiInfo };

            var ai = new AuthoritativeInstruction { Action = aiAction, Header = aih };

            /***** To see generated XML Uncomment the code below: ******/

            var sw = new StringWriter();
            var xmlWriter = XmlWriter.Create(sw, new XmlWriterSettings() { OmitXmlDeclaration = true, Indent = true });

            serializer.Serialize(xmlWriter, ai, ns);
            string xmlString = sw.ToString();
            Console.WriteLine("Authoritative Instruction XML For Info Message : " + xmlString + " \n\n\n");
        }

        /// <summary>
        /// Create and Serialize Authoritative Instruction XML
        /// </summary>
        /// <param name="filename"></param>
        private void SerializeAI(string filename)
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("ns", "http://gpcopsschema.azurewebsites.net/schema/2015/1.0/ConsignmentService");

            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to serialize.
            var serializer = new XmlSerializer(typeof(AuthoritativeInstruction));
            TextWriter writer = new StreamWriter(filename);

            //Customer Authority Type
            var ca = new CustomerAuthorityType
            {
                DispatchingMine = "Curragh",
                DispatchingCustomer = "Curragh",
                UnloadLocation = "GLD"
            };

            var aid = new AuthorisationIdType { Consignment = "AA24288", RailServiceID = "B53M" };
            var dt = new DateTime(2015, 05, 16);
            aid.RailServiceDateTime = dt; //DateTime.ParseExact(dt.ToString("yyyy-MM-dd"),"yyyy-MM-dd",null);

            var aih = new AuthoritativeInstructionHeader { CustomerAuthority = ca, Identifier = aid };
            var msgDt = DateTime.Now;
            aih.MessageTimeStamp = msgDt;

            var firstwagon = new WagonType { Sequence = 2, Number = 56012, Type = WagonTypeType.Wagon, Class = "VCBS" };

            var lastwagon = new WagonType { Sequence = 104, Number = 49717, Type = WagonTypeType.Wagon, Class = "VSAL" };

            var ct = new CreateType { Count = 102, Stockpile = 661, FirstWagon = firstwagon, LastWagon = lastwagon };

            var cm = new CoalMetadataType
            {
                CoalType = "Curragh Mid Ash",
                CoalProperty = CoalMetadataTypeCoalProperty.Normal,
                Ash = 0.25f,
                Moisture = 0.25f
            };

            var dtNow = DateTime.Now;
            var ld = new LoadOutDetailsType
            {
                LoadLocation = "ALocation",
                LoadOutOperator = "CurraghUser",
                TonnesLoaded = 8328,
                UnloadInstruction = "A Sample Instruction",
                LoadCompleteDateTime = dtNow.AddHours(-1)
            };

            var cc = new CommentType
            {
                ConsignmentComment = "Optional Create Comment"
            };

            var aiCreate = new AuthoritativeInstructionActionCreate
            {
                Instruction = ct,
                CoalMetadata = cm,
                LoadOutDetails = ld,
                CreateComment = cc
            };

            var aiAction = new AuthoritativeInstructionAction { Item = aiCreate };

            var ai = new AuthoritativeInstruction { Action = aiAction, Header = aih };

            // Serializes the authoritative instruction messgae, and closes the TextWriter.
            serializer.Serialize(writer, ai, ns);
            writer.Close();

            /***** To see generated XML Uncomment the code below: ******/

            //var sw = new StringWriter();
            //var xmlWriter = XmlWriter.Create(sw, new XmlWriterSettings() { OmitXmlDeclaration = true, Indent = true });

            //serializer.Serialize(xmlWriter, ai, ns);
            //string xmlString = sw.ToString();
            //Console.WriteLine("XML : " + xmlString + " \n\n\n");
        }


        /// <summary>
        /// Deserialize and Read Authoritative Instruction XML
        /// </summary>
        /// <param name="filename"></param>
        protected void DeserializeAI(string filename)
        {
            // Creates an instance of the XmlSerializer class and specifies the type of object to be deserialized.
            XmlSerializer serializer = new XmlSerializer(typeof(AuthoritativeInstruction));

            // If the XML document has been altered with unknown nodes or attributes, handles them with the UnknownNode and UnknownAttribute events.
            serializer.UnknownNode += new XmlNodeEventHandler(this.serializer_UnknownNode);
            serializer.UnknownAttribute += new XmlAttributeEventHandler(this.serializer_UnknownAttribute);

            // A FileStream is needed to read the XML document.
            var fs = new FileStream(filename, FileMode.Open);

            // Declares an object variable of the type AuthoritativeInstruction to be deserialized.
            AuthoritativeInstruction ai;
            
            // Uses the Deserialize method to restore the object's state with data from the XML document. */
            ai = (AuthoritativeInstruction)serializer.Deserialize(fs);

            // Reads the order date.
            Console.WriteLine("\nService ID: " + ai.Header.Identifier.RailServiceID);
            Console.WriteLine("\nService Date: " + ai.Header.Identifier.RailServiceDateTime);
            Console.WriteLine("\nConsignment: " + ai.Header.Identifier.Consignment);
    
            // Reads the shipping address.
            var action = ai.Action;
            var aiCreate = (AuthoritativeInstructionActionCreate)action.Item;
            Console.WriteLine("\nFirst Wagon Sequence: " + aiCreate.Instruction.FirstWagon.Sequence);
            Console.WriteLine("\nLast Wagon Sequence: " + aiCreate.Instruction.LastWagon.Sequence);
            Console.WriteLine("\nCoal Type: " + aiCreate.CoalMetadata.CoalType);
            Console.WriteLine("\nCoal Property: " + aiCreate.CoalMetadata.CoalProperty);
            Console.WriteLine("\nLoad Location: " + aiCreate.LoadOutDetails.LoadLocation);
            Console.WriteLine("\nLoad Out Operator: " + aiCreate.LoadOutDetails.LoadOutOperator);
            Console.WriteLine("\nTonnes Loaded: " + aiCreate.LoadOutDetails.TonnesLoaded);
            Console.WriteLine("\nConsignment Comment: " + aiCreate.CreateComment.ConsignmentComment);

            Console.ReadKey();
        }
    
        protected void serializer_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("Unknown Node:" +   e.Name + "\t" + e.Text);
        }

        protected void serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            Console.WriteLine("Unknown attribute " + 
            attr.Name + "='" + attr.Value + "'");
        }
    }
}
