using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;
using System.Configuration;
using System.Collections.Specialized;

namespace Class_Library
{
   public class XMLHelper <T>
    {
       XmlSerializer mySerializer ;
       String BaseDirectory;

       public XMLHelper()
       {
           mySerializer = new XmlSerializer(typeof(T));
           
           BaseDirectory = Convert.ToString(ClassSettings.Default["DataDirectory"]);

           if (!System.IO.Directory.Exists(BaseDirectory))
               System.IO.Directory.CreateDirectory(BaseDirectory);
       }

       public String FileName(T myObj)
       {
           String ClassName = myObj.GetType().Name;
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
                myObj = (T)mySerializer.Deserialize(myReader);
                myReader.Close();
            }
        }
        
    }
}
