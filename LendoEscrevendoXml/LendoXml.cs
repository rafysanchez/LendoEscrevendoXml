using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace LendoEscrevendoXml
{
    class LendoXml
    {

        public static void Ler()
        {
            XmlSerializer ser = new XmlSerializer(typeof(NFe));
            TextReader textReader = (TextReader)new StreamReader("c:\\temp\\nfe.xml");
            XmlTextReader reader = new XmlTextReader(textReader);
            reader.Read();

            NFe nota = (NFe)ser.Deserialize(reader);


        }


    }
}
