using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

    static class XmlSerialization
    {

        public static T ReadFromFile<T>(string filename)
        {
            //Open the file written above and read values from it.
            Stream stream = File.Open(filename, FileMode.Open);
            XmlSerializer bformatter = new XmlSerializer(typeof(T));
            Console.WriteLine("Reading Employee Information");
            T objeto =(T) bformatter.Deserialize(stream);
            stream.Close();
            return objeto;
        }

        public static void WriteToFile<T>(this T objeto, string filename)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            XmlSerializer bformatter = new XmlSerializer(typeof(T));
            Console.WriteLine("Writing Employee Information");
            bformatter.Serialize(stream, objeto);
            stream.Close();
        }

        public static object BinaryReadFromFile(string filename)
        {
            //Open the file written above and read values from it.
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();
            Console.WriteLine("Reading Employee Information");
            object objeto = bformatter.Deserialize(stream);
            stream.Close();
            return objeto;
        }

        public static void BinaryWriteToFile(string filename, object objeto)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();
            Console.WriteLine("Writing Employee Information");
            bformatter.Serialize(stream, objeto);
            stream.Close();
        }

    }
