using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using PracticaSAP.Clases;

namespace PracticaSAP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public Stream Resultado { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
                    
            nota unaNota = new nota();
            unaNota.de = "pepe";
           
           

            //string Rutaarchivo = "D:\\Google Drive Carpeta\\Uni\\SAP Y TFI\\Vilaboa\\Practica Programacion SAP\\PracticaSAP\\PracticaSAP\\XMLPractica\\Datos\\XMLFile2.xml";


            //Resultado = SerializadorXML.Serializar(unaNota);

            //StreamWriter sw = new StreamWriter(Rutaarchivo);
            //sw.Write(SerializadorXML.StreamAString(Resultado));

            //sw.Close();






            StreamReader sr = new StreamReader("D:\\Google Drive Carpeta\\Uni\\SAP Y TFI\\Vilaboa\\Practica Programacion SAP\\PracticaSAP\\PracticaSAP\\XMLPractica\\Datos\\XMLFile2.xml");
            MemoryStream ms = new MemoryStream(Encoding.ASCII.GetBytes(sr.ReadToEnd()));

            
            unaNota = SerializadorXML.DeSerializar<nota>(ms);
            TextBox1.Text = unaNota.asunto;
        }




    }
}