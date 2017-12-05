using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceBloodCrowd
    {
        //Listar dadores de sangue.
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/donors")]
        [Description("Gets all the Donors from the XML.")]
        List<Donor> GetDonors();

        //Listar dadores de sangue pelo nome pesquisado.
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/searchByName?donorName={name}")]
        [Description("Gets the Donors from the XML by name.")]
        List<Donor> searchByName(string name);

    }

    [DataContract]
    public class Donor //: DadosExtra
    {
        private int number;
        private string gender;
        private string givenName;
        private string surname;
        private string streetAddress;
        private string city;
        private string stateFull;
        private string zipCode;
        private string emailAddress;
        private string username;
        private string password;
        private int telephoneNumber;
        private string mothersMaiden;
        private DateTime birthday;
        private int age;
        private string occupation;
        private string company;
        private string vehicle;
        private string bloodType;
        private double kilograms;
        private int centimeters;
        private string guid;
        private double latitude;
        private double longitude;

        public Donor(int number, string gender, string givenName, string surname, string streetAddress, string city,
            string stateFull, string zipCode, string emailAddress, string username, string password,
            int telephoneNumber, string mothersMaiden, DateTime birthday, int age, string occupation, string company,
            string vehicle, string bloodType, double kilograms, int centimeters, string guid, double latitude,
            double longitude)
        {
            this.Number = number;
            this.Gender = gender;
            this.GivenName = givenName;
            this.Surname = surname;
            this.StreetAddress = streetAddress;
            this.City = city;
            this.StateFull = stateFull;
            this.ZipCode = zipCode;
            this.EmailAddress = emailAddress;
            this.Username = username;
            this.Password = password;
            this.TelephoneNumber = telephoneNumber;
            this.MothersMaiden = mothersMaiden;
            this.Birthday = birthday;
            this.age = age;
            this.Occupation = occupation;
            this.Company = company;
            this.Vehicle = vehicle;
            this.BloodType = bloodType;
            this.Kilograms = kilograms;
            this.Centimeters = centimeters;
            this.Guid = guid;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        [DataMember]
        public int Number
        {
            get => number;
            set => number = value;
        }

        [DataMember]
        public string Gender
        {
            get => gender;
            set => gender = value;
        }

        [DataMember]
        public string GivenName
        {
            get => givenName;
            set => givenName = value;
        }

        [DataMember]
        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        [DataMember]
        public string StreetAddress
        {
            get => streetAddress;
            set => streetAddress = value;
        }

        [DataMember]
        public string City
        {
            get => city;
            set => city = value;
        }

        [DataMember]
        public string StateFull
        {
            get => stateFull;
            set => stateFull = value;
        }

        [DataMember]
        public string ZipCode
        {
            get => zipCode;
            set => zipCode = value;
        }

        [DataMember]
        public string EmailAddress
        {
            get => emailAddress;
            set => emailAddress = value;
        }

        [DataMember]
        public string Username
        {
            get => username;
            set => username = value;
        }

        [DataMember]
        public string Password
        {
            get => password;
            set => password = value;
        }

        [DataMember]
        public int TelephoneNumber
        {
            get => telephoneNumber;
            set => telephoneNumber = value;
        }

        [DataMember]
        public string MothersMaiden
        {
            get => mothersMaiden;
            set => mothersMaiden = value;
        }

        [DataMember]
        public DateTime Birthday
        {
            get => birthday;
            set => birthday = value;
        }

        [DataMember]
        public string Occupation
        {
            get => occupation;
            set => occupation = value;
        }

        [DataMember]
        public string Company
        {
            get => company;
            set => company = value;
        }

        [DataMember]
        public string Vehicle
        {
            get => vehicle;
            set => vehicle = value;
        }

        [DataMember]
        public string BloodType
        {
            get => bloodType;
            set => bloodType = value;
        }

        [DataMember]
        public double Kilograms
        {
            get => kilograms;
            set => kilograms = value;
        }

        [DataMember]
        public int Centimeters
        {
            get => centimeters;
            set => centimeters = value;
        }

        [DataMember]
        public string Guid
        {
            get => guid;
            set => guid = value;
        }

        [DataMember]
        public double Latitude
        {
            get => latitude;
            set => latitude = value;
        }

        [DataMember]
        public double Longitude
        {
            get => longitude;
            set => longitude = value;
        }

           /*     
        [DataMember]
        public double GetIMC

        {
            get
            {
                var var_vazia = 0.0;
                double imc = var_vazia;
                double altura_m = Centimeters / (double)100;
                imc = kilograms / (altura_m * altura_m);
                imc = Math.Round(imc, 2);

                return imc;
            }
        }
        
        

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Number").Append(Number).Append("Gender").Append(Gender).Append("Givename").Append(GivenName)
                .Append("Surname").Append(Surname).Append("Street Address").Append(StreetAddress).Append("City")
                .Append(City)
                .Append("StateFull").Append(StateFull).Append("ZipCode").Append(ZipCode).Append("Email Address")
                .Append(EmailAddress)
                .Append("Username").Append(Username).Append("Password").Append(Password).Append("Telephone Number")
                .Append(TelephoneNumber)
                .Append("Mothers Maiden").Append(MothersMaiden).Append("Birthday").Append(Birthday).Append("Age")
                .Append(Age)
                .Append("Occupation").Append(Occupation).Append("Company").Append(Company).Append("Vehicle")
                .Append(Vehicle)
                .Append("BloodType").Append(BloodType).Append("Kilograms").Append(Kilograms).Append("Centimeters")
                .Append(Centimeters)
                .Append("GUID").Append(Guid).Append("Latitude").Append(Latitude).Append("Longitude").Append(Longitude);

            return builder.ToString();
        }

        // Use a data contract as illustrated in the sample below to add composite types to service operations.
    }

    [DataContract]
    public class DadosExtra
    {
        [DataMember]
        public int Age
        {
            get
            {
                int age;
                DateTime today = DateTime.Today;
                age = today.Year - birthday.Year;
                if (birthday.DayOfYear < today.DayOfYear)
                {
                    age -= 1;
                }
                return age;
            }
        }*/
    }

}
