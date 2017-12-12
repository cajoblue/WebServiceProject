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

        public static Dictionary<String, List<String>> myDictionary = new Dictionary<string, List<string>>()
        {
            {"O-", new List<String>() {"O−", "O+", "A−", " A+", "B−", "B+", "AB−", "AB+"}},
            {"O+", new List<String>() {"O+", "A+", "B+", "AB+"}},
            {"A-", new List<String>() {"A-", "A+", "AB-", "AB+"}},
            {"A+", new List<String>() {"A+", "AB+"}},
            {"B-", new List<String>() {"B-", "B+", "AB-", "AB+"}},
            {"B+", new List<String>() {"B+", "AB+"}},
            {"AB-", new List<String>() {"AB-", "AB+"}},
            {"AB+", new List<String>() {"AB+"}}
        };

        public ServiceBloodCrowd()
        {
            FILEPATH = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "blooddonors.xml");
        }

        //Listar todos os dadores
        public List<Donor> GetDonors()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);
            List<Donor> list_dadores = new List<Donor>();

            XmlNodeList donorNodes = doc.SelectNodes("/ListaDador/Dador");

            for (int i = 0; i < donorNodes.Count; i++)
            {
                //XmlNode dadorNode = donorNodes[i].ChildNodes;
                int cm = Convert.ToInt32(donorNodes[i].ChildNodes[20].InnerText);
                double kg = double.Parse(donorNodes[i].ChildNodes[19].InnerText, CultureInfo.InvariantCulture);
                int num_dador = int.Parse(donorNodes[i].ChildNodes[0].InnerText);
                int phone_number;
                double imc = CalculateIMC(kg, cm);
                int.TryParse(donorNodes[i].ChildNodes[11].InnerText, out phone_number);
                DateTime.TryParseExact(donorNodes[i].ChildNodes[13].InnerText, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate);
                int age = CalculateAge(birthDate);
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
                    donorNodes[i].ChildNodes[21].InnerText, latitude, longitude, imc);
               list_dadores.Add(newDador);
            }
            return list_dadores;
        }

        //Método para calcular o IMC
        private double CalculateIMC (double kilograms, int centimeters)
        {            
                var var_vazia = 0.0;
                double imc = var_vazia;
                double altura_m = centimeters / (double)100;
                imc = kilograms / (altura_m * altura_m);
                imc = Math.Round(imc, 2);

                return imc;            
        }

            //Método para calcular a idade
            private int CalculateAge(DateTime birthDate)
        {
            int idade = DateTime.Today.Year - birthDate.Year;
            if (birthDate.AddYears(idade) > DateTime.Today)
            {
                idade = idade - 1;
            }
            return idade;
        }

        //Pesquisar dadores por nome
        public List<Donor> searchByName(string name)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);
            XmlElement root = doc.DocumentElement;
            List<Donor> list_dadoresFounded = new List<Donor>();

            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    XmlNode bookNode = root.ChildNodes[i];
                    string nameDador = bookNode.ChildNodes[2].InnerText;

                    if (nameDador.ToUpper().Equals(name.ToUpper()))
                    {
                        XmlNode dadorNode = root.ChildNodes[i];
                        int cm = Convert.ToInt32(dadorNode.ChildNodes[20].InnerText);
                        double kg = double.Parse(dadorNode.ChildNodes[19].InnerText, CultureInfo.InvariantCulture);
                        int age = Int32.Parse(dadorNode.ChildNodes[14].InnerText);
                        int num_dador = int.Parse(dadorNode.ChildNodes[0].InnerText);
                        int phone_number;
                        double imc = CalculateIMC(kg, cm);
                        int.TryParse(dadorNode.ChildNodes[11].InnerText, out phone_number);
                        DateTime.TryParseExact(dadorNode.ChildNodes[13].InnerText, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate);
                        double latitude;
                        double.TryParse(dadorNode.ChildNodes[22].InnerText, out latitude);
                        double longitude;
                        double.TryParse(dadorNode.ChildNodes[23].InnerText, out longitude);
                        Donor newDador = new Donor(num_dador, dadorNode.ChildNodes[1].InnerText, dadorNode.ChildNodes[2].InnerText,
                                                   dadorNode.ChildNodes[3].InnerText, dadorNode.ChildNodes[4].InnerText,
                                                   dadorNode.ChildNodes[5].InnerText, dadorNode.ChildNodes[6].InnerText,
                                                   dadorNode.ChildNodes[7].InnerText, dadorNode.ChildNodes[8].InnerText,
                                                   dadorNode.ChildNodes[9].InnerText, dadorNode.ChildNodes[10].InnerText,
                                                   phone_number, dadorNode.ChildNodes[12].InnerText, birthDate, age, dadorNode.ChildNodes[15].InnerText,
                                                   dadorNode.ChildNodes[16].InnerText, dadorNode.ChildNodes[17].InnerText, dadorNode.ChildNodes[18].InnerText,
                                                   kg, cm, dadorNode.ChildNodes[21].InnerText, latitude, longitude, imc);
                        list_dadoresFounded.Add(newDador);
                    }
                }
            }
            else
            {
                return null;
            }
            return list_dadoresFounded;
        }
        
        //Devolve uma lista com os tipos de sangue.
        public List<string> getBloodTypes()
        {
            return myDictionary.Keys.ToList();
        }

        //Pesquisar dadores pelo tipo sanguíneo.
        public List<Donor> searchByBloodType(string sh_blood)
        {
            XmlDocument doc = new XmlDocument();
            List<Donor> list_dadoresFounded = new List<Donor>();
            doc.Load(FILEPATH);
            XmlNode root = doc.DocumentElement;

            if (root.HasChildNodes)
            {
                string xpth_way = "//Dador/BloodType";
                XmlNodeList nodeList = root.SelectNodes(xpth_way);

                for (int i = 0; i < nodeList.Count; i++)
                {
                    if (nodeList[i].InnerText.Equals(sh_blood))
                    {
                        XmlNode dadorNode = root.ChildNodes[i];
                        int cm = Convert.ToInt32(dadorNode.ChildNodes[20].InnerText);
                        double kg = double.Parse(dadorNode.ChildNodes[19].InnerText, CultureInfo.InvariantCulture);
                        int age = Int32.Parse(dadorNode.ChildNodes[14].InnerText);
                        int num_dador = int.Parse(dadorNode.ChildNodes[0].InnerText);
                        int phone_number;
                        double imc = CalculateIMC(kg, cm);
                        int.TryParse(dadorNode.ChildNodes[11].InnerText, out phone_number);
                        DateTime.TryParseExact(dadorNode.ChildNodes[13].InnerText, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate);
                        double latitude;
                        double.TryParse(dadorNode.ChildNodes[22].InnerText, out latitude);
                        double longitude;
                        double.TryParse(dadorNode.ChildNodes[23].InnerText, out longitude);
                        Donor newDador = new Donor(num_dador, dadorNode.ChildNodes[1].InnerText, dadorNode.ChildNodes[2].InnerText,
                                                   dadorNode.ChildNodes[3].InnerText, dadorNode.ChildNodes[4].InnerText,
                                                   dadorNode.ChildNodes[5].InnerText, dadorNode.ChildNodes[6].InnerText,
                                                   dadorNode.ChildNodes[7].InnerText, dadorNode.ChildNodes[8].InnerText,
                                                   dadorNode.ChildNodes[9].InnerText, dadorNode.ChildNodes[10].InnerText,
                                                   phone_number, dadorNode.ChildNodes[12].InnerText, birthDate, age, dadorNode.ChildNodes[15].InnerText,
                                                   dadorNode.ChildNodes[16].InnerText, dadorNode.ChildNodes[17].InnerText, dadorNode.ChildNodes[18].InnerText,
                                                   kg, cm, dadorNode.ChildNodes[21].InnerText, latitude, longitude, imc);
                        list_dadoresFounded.Add(newDador);
                    }
                }
            }
            else
            {
                return null;
            }
            return list_dadoresFounded;
        }

        //Devolve uma lista de dadores compatíveis com o selecionado na combobox.
        public List<Donor> GetDonorsByCompBlood(string bloodType)
        {
            List<Donor> list_dadoresFounded = new List<Donor>();
            List<string> bloodTypesComp = myDictionary[bloodType];
            foreach (string var_bloodType in bloodTypesComp)
            {                
                list_dadoresFounded.AddRange(searchByBloodType(var_bloodType));
            }
            return list_dadoresFounded;
        }
        
        //Método para adicionar um novo dador.
        public bool addDador(Donor newDonor)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);
            XmlElement root = doc.DocumentElement;

            XmlElement dador = doc.CreateElement("Dador");
            XmlElement number = doc.CreateElement("Number");
            number.InnerText = newDonor.Number.ToString();
            XmlElement gender = doc.CreateElement("Gender");
            gender.InnerText = newDonor.Gender;
            XmlElement givenName = doc.CreateElement("GivenName");
            givenName.InnerText = newDonor.GivenName;
            XmlElement surname = doc.CreateElement("Surname");
            surname.InnerText = newDonor.Surname;
            XmlElement streetAddress = doc.CreateElement("StreetAddress");
            streetAddress.InnerText = newDonor.StreetAddress;
            XmlElement city = doc.CreateElement("City");
            city.InnerText = newDonor.City;
            XmlElement stateFull = doc.CreateElement("StateFull");
            stateFull.InnerText = newDonor.StateFull;
            XmlElement zipCode = doc.CreateElement("ZipCode");
            zipCode.InnerText = newDonor.ZipCode;
            XmlElement emailAddress = doc.CreateElement("EmailAddress");
            emailAddress.InnerText = newDonor.EmailAddress;
            XmlElement username = doc.CreateElement("Username");
            username.InnerText = newDonor.Username;
            XmlElement password = doc.CreateElement("Password");
            password.InnerText = newDonor.Password;
            XmlElement telephoneNumber = doc.CreateElement("TelephoneNumber");
            telephoneNumber.InnerText = newDonor.TelephoneNumber.ToString();
            XmlElement mothersMaiden = doc.CreateElement("MothersMaiden");
            mothersMaiden.InnerText = newDonor.MothersMaiden;
            XmlElement birthday = doc.CreateElement("Birthday");
            birthday.InnerText = newDonor.Birthday.ToString("M/d/yyyy", CultureInfo.InvariantCulture);

            XmlElement age = doc.CreateElement("Age");

            //age.InnerText = Model.calcularIdade(newDonor.Birthday).ToString();

            XmlElement occupation = doc.CreateElement("Occupation");
            occupation.InnerText = newDonor.Occupation;
            XmlElement company = doc.CreateElement("Company");
            company.InnerText = newDonor.Company;
            XmlElement vehicle = doc.CreateElement("Vehicle");
            vehicle.InnerText = newDonor.Vehicle;
            XmlElement bloodType = doc.CreateElement("BloodType");
            bloodType.InnerText = newDonor.BloodType;
            XmlElement kilograms = doc.CreateElement("Kilograms");
            kilograms.InnerText = newDonor.Kilograms.ToString();
            XmlElement centimeters = doc.CreateElement("Centimeters");
            centimeters.InnerText = newDonor.Centimeters.ToString();
            XmlElement guid = doc.CreateElement("GUID");
            guid.InnerText = newDonor.Guid;
            XmlElement latitude = doc.CreateElement("Latitude");
            latitude.InnerText = newDonor.Latitude.ToString();
            XmlElement longitude = doc.CreateElement("Longitude");
            longitude.InnerText = newDonor.Longitude.ToString();

            dador.AppendChild(number);
            dador.AppendChild(gender);
            dador.AppendChild(givenName);
            dador.AppendChild(surname);
            dador.AppendChild(streetAddress);
            dador.AppendChild(city);
            dador.AppendChild(stateFull);
            dador.AppendChild(zipCode);
            dador.AppendChild(emailAddress);
            dador.AppendChild(username);
            dador.AppendChild(password);
            dador.AppendChild(telephoneNumber);
            dador.AppendChild(mothersMaiden);
            dador.AppendChild(birthday);
            dador.AppendChild(age);
            dador.AppendChild(occupation);
            dador.AppendChild(company);
            dador.AppendChild(vehicle);
            dador.AppendChild(bloodType);
            dador.AppendChild(kilograms);
            dador.AppendChild(centimeters);
            dador.AppendChild(guid);
            dador.AppendChild(latitude);
            dador.AppendChild(longitude);
            root.AppendChild(dador);

            doc.Save(FILEPATH);

            return true;
        }

        

    }
}
