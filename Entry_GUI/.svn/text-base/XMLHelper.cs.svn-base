using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;

namespace Main_XNA_Game
{
   public class XMLHelper <T>
    {
       XmlSerializer mySerializer ;
       String ClassName;
       String BaseDirectory;
       
       public XMLHelper()
       {
           mySerializer = new XmlSerializer(typeof(T));
           BaseDirectory = "";
       }

       public XMLHelper(String myBaseDirectory)
       {
           mySerializer = new XmlSerializer(typeof(T));
           BaseDirectory = myBaseDirectory;
           if (!System.IO.Directory.Exists("Data"))
               System.IO.Directory.CreateDirectory("Data");
       }

       public String FileName(T myObj)
       {
           ClassName = myObj.GetType().Name;
           return BaseDirectory + "\\" + ClassName + ".xml";           
       }

       public void Save(T myObj)
        {
            TextWriter myWriter = new StreamWriter(FileName(myObj));
            mySerializer.Serialize(myWriter, myObj);
            myWriter.Close();
        }
       
        public void Load(ref T myObj)
        {
            String myFileName = FileName(myObj);
            if (System.IO.File.Exists(myFileName))
            {

                XmlSerializer mySerializer = new XmlSerializer(typeof(T));
                TextReader myReader = new StreamReader(myFileName);
                T NewObject = (T)mySerializer.Deserialize(myReader);
                myReader.Close();
                myObj = NewObject;
            }

        }
        
    }
}
