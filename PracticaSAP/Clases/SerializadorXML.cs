using System;
using System.Xml.Serialization;
using  System.IO;
using System.Text;

namespace PracticaSAP.Clases
{
    public class SerializadorXML
    {
        public static Stream Serializar(object unObjeto)
        {
            XmlSerializer xmlSerializador = new XmlSerializer(unObjeto.GetType());
            Stream flujo = new MemoryStream();
            xmlSerializador.Serialize(flujo, unObjeto);

            return flujo;
        }

        public static T DeSerializar<T>(Stream ObjetoenXML) where T : new()
        {
            XmlSerializer xmlSerializador2 = new XmlSerializer(typeof(T));

            T Resultado = (T)xmlSerializador2.Deserialize(ObjetoenXML);

            return Resultado;
        }



        public static string StreamAString(Stream ss)
        {

            byte[] bytes = new byte[Convert.ToInt32(ss.Length) + 1];

            ss.Position = 0;

            ss.Read(bytes, 0, Convert.ToInt32(ss.Length));

            return Encoding.ASCII.GetString(bytes);

        }


    }
}