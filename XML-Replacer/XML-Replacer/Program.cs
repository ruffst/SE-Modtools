using System;
using System.Xml;

namespace XML_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
			if (args.Length == 0)
			{
				Console.WriteLine("Invalid args");
				return;
			}

			var command = args[0];

			switch (command)
			{
				case "Path":
					//Push();
					break;
				case "commit" when args.Length == 3 && args[1] == "-m":
					//Commit(args[2]);
					break;
				default:
					Console.WriteLine("Invalid command");
					break;
			}

			//Console.WriteLine("Hello World!");
        }

		private void blaaa()
        {
			XmlTextReader textReader = new XmlTextReader("C:\\books.xml");
			textReader.Read();
			// If the node has value  

            while (textReader.Read())
            {
                XmlNodeType nType = textReader.NodeType;
                // If node type us a declaration  
                if (nType == XmlNodeType.XmlDeclaration)
                {
                    Console.WriteLine("Declaration:" + textReader.Name.ToString());
                    // xd = xd + 1;
                }
                // if node type is a comment  
                if (nType == XmlNodeType.Comment)
                {
                    Console.WriteLine("Comment:" + textReader.Name.ToString());
                    //cc = cc + 1;
                }
                // if node type us an attribute  
                if (nType == XmlNodeType.Attribute)
                {
                    Console.WriteLine("Attribute:" + textReader.Name.ToString());
                    //ac = ac + 1;
                }
                // if node type is an element  
                if (nType == XmlNodeType.Element)
                {
                    Console.WriteLine("Element:" + textReader.Name.ToString());
                    //el = el + 1;
                }
                // if node type is an entity\  
                if (nType == XmlNodeType.Entity)
                {
                    Console.WriteLine("Entity:" + textReader.Name.ToString());
                    //et = et + 1;
                }
                // if node type is a Process Instruction  
                if (nType == XmlNodeType.Entity)
                {
                    Console.WriteLine("Entity:" + textReader.Name.ToString());
                    // pi = pi + 1;
                }
                // if node type a document  
                if (nType == XmlNodeType.DocumentType)
                {
                    Console.WriteLine("Document:" + textReader.Name.ToString());
                    //dc = dc + 1;
                }
                // if node type is white space  
                if (nType == XmlNodeType.Whitespace)
                {
                    Console.WriteLine("WhiteSpace:" + textReader.Name.ToString());
                    //ws = ws + 1;
                }

            }

            XmlTextWriter textWriter = new XmlTextWriter("C:\\myXmFile.xml", null);
            // Opens the document  
            textWriter.WriteStartDocument();
            // Write comments  
            textWriter.WriteComment("First Comment XmlTextWriter Sample Example");
            textWriter.WriteComment("myXmlFile.xml in root dir");
            // Write first element  
            textWriter.WriteStartElement("Student");
            textWriter.WriteStartElement("r", "RECORD", "urn:record");
            // Write next element  
            textWriter.WriteStartElement("Name", "");
            textWriter.WriteString("Student");
            textWriter.WriteEndElement();
            // Write one more element  
            textWriter.WriteStartElement("Address", "");
            textWriter.WriteString("Colony");
            textWriter.WriteEndElement();
            // WriteChars  
            char[] ch = new char[3];
            ch[0] = 'a';
            ch[1] = 'r';
            ch[2] = 'c';
            textWriter.WriteStartElement("Char");
            textWriter.WriteChars(ch, 0, ch.Length);
            textWriter.WriteEndElement();
            // Ends the document.  
            textWriter.WriteEndDocument();
            // close writer  
            textWriter.Close();


            XmlDocument doc = new XmlDocument();
            //Load the the document with the last book node.  
            XmlTextReader reader = new XmlTextReader("c:\\books.xml");
            reader.Read();
            // load reader   
            doc.Load(reader);

        }
    }
}
