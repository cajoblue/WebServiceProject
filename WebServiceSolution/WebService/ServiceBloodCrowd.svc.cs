using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Hosting;
using System.Xml;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceBloodCrowd" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceBloodCrowd.svc or ServiceBloodCrowd.svc.cs at the Solution Explorer and start debugging.
    public class ServiceBloodCrowd : IServiceBloodCrowd
    {
        private static string FILEPATH;

        public ServiceBloodCrowd()
        {
            FILEPATH = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "blooddonors.xml");
        }

        public List<Donor> GetDonors()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);
            List<Donor> list_dadores = new List<Donor>();

            XmlNodeList donorNodes = doc.SelectNodes("/ListaDador/Dador");

            for (int i = 0; i < donorNodes.Count; i++)
            {
                //  XmlNode dadorNode = donorNodes[i].ChildNodes;
                int cm = Convert.ToInt32(donorNodes[i].ChildNodes[20].InnerText);
                double kg = double.Parse(donorNodes[i].ChildNodes[19].InnerText, CultureInfo.InvariantCulture);
                int age = Int32.Parse(donorNodes[i].ChildNodes[14].InnerText);
                int num_dador = int.Parse(donorNodes[i].ChildNodes[0].InnerText);
                int phone_number;
                int.TryParse(donorNodes[i].ChildNodes[11].InnerText, out phone_number);
                DateTime birthDate;
                DateTime.TryParse(donorNodes[i].ChildNodes[13].InnerText, out birthDate);
                double latitude;
                double.TryParse(donorNodes[i].ChildNodes[22].InnerText, out latitude);
                double longitude;
                double.TryParse(donorNodes[i].ChildNodes[23].InnerText, out longitude);

                Donor newDador = new Donor(num_dador, donorNodes[i].ChildNodes[1].InnerText,
                    donorNodes[i].ChildNodes[2].InnerText, donorNodes[i].ChildNodes[3].InnerText, donorNodes[i].ChildNodes[4].InnerText,
                    donorNodes[i].ChildNodes[5].InnerText, donorNodes[i].ChildNodes[6].InnerText, donorNodes[i].ChildNodes[7].InnerText,
                    donorNodes[i].ChildNodes[8].InnerText, donorNodes[i].ChildNodes[9].InnerText, donorNodes[i].ChildNodes[10].InnerText, phone_number,
                    donorNodes[i].ChildNodes[12].InnerText, birthDate, age, donorNodes[i].ChildNodes[15].InnerText, donorNodes[i].ChildNodes[16].InnerText,
                    donorNodes[i].ChildNodes[17].InnerText, donorNodes[i].ChildNodes[18].InnerText, kg, cm,
                    donorNodes[i].ChildNodes[21].InnerText, latitude
                    , longitude);

                list_dadores.Add(newDador);
            }

            return list_dadores;
        }
    }
}
