﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Donor", Namespace="http://schemas.datacontract.org/2004/07/WebService")]
    [System.SerializableAttribute()]
    public partial class Donor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthdayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BloodTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CentimetersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GivenNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GuidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ImcField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double KilogramsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LatitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LongitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MothersMaidenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OccupationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateFullField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TelephoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VehicleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipCodeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Birthday {
            get {
                return this.BirthdayField;
            }
            set {
                if ((this.BirthdayField.Equals(value) != true)) {
                    this.BirthdayField = value;
                    this.RaisePropertyChanged("Birthday");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BloodType {
            get {
                return this.BloodTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.BloodTypeField, value) != true)) {
                    this.BloodTypeField = value;
                    this.RaisePropertyChanged("BloodType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Centimeters {
            get {
                return this.CentimetersField;
            }
            set {
                if ((this.CentimetersField.Equals(value) != true)) {
                    this.CentimetersField = value;
                    this.RaisePropertyChanged("Centimeters");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Company {
            get {
                return this.CompanyField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyField, value) != true)) {
                    this.CompanyField = value;
                    this.RaisePropertyChanged("Company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GivenName {
            get {
                return this.GivenNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GivenNameField, value) != true)) {
                    this.GivenNameField = value;
                    this.RaisePropertyChanged("GivenName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Guid {
            get {
                return this.GuidField;
            }
            set {
                if ((object.ReferenceEquals(this.GuidField, value) != true)) {
                    this.GuidField = value;
                    this.RaisePropertyChanged("Guid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Imc {
            get {
                return this.ImcField;
            }
            set {
                if ((this.ImcField.Equals(value) != true)) {
                    this.ImcField = value;
                    this.RaisePropertyChanged("Imc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Kilograms {
            get {
                return this.KilogramsField;
            }
            set {
                if ((this.KilogramsField.Equals(value) != true)) {
                    this.KilogramsField = value;
                    this.RaisePropertyChanged("Kilograms");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Latitude {
            get {
                return this.LatitudeField;
            }
            set {
                if ((this.LatitudeField.Equals(value) != true)) {
                    this.LatitudeField = value;
                    this.RaisePropertyChanged("Latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Longitude {
            get {
                return this.LongitudeField;
            }
            set {
                if ((this.LongitudeField.Equals(value) != true)) {
                    this.LongitudeField = value;
                    this.RaisePropertyChanged("Longitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MothersMaiden {
            get {
                return this.MothersMaidenField;
            }
            set {
                if ((object.ReferenceEquals(this.MothersMaidenField, value) != true)) {
                    this.MothersMaidenField = value;
                    this.RaisePropertyChanged("MothersMaiden");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Number {
            get {
                return this.NumberField;
            }
            set {
                if ((this.NumberField.Equals(value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Occupation {
            get {
                return this.OccupationField;
            }
            set {
                if ((object.ReferenceEquals(this.OccupationField, value) != true)) {
                    this.OccupationField = value;
                    this.RaisePropertyChanged("Occupation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StateFull {
            get {
                return this.StateFullField;
            }
            set {
                if ((object.ReferenceEquals(this.StateFullField, value) != true)) {
                    this.StateFullField = value;
                    this.RaisePropertyChanged("StateFull");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StreetAddress {
            get {
                return this.StreetAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetAddressField, value) != true)) {
                    this.StreetAddressField = value;
                    this.RaisePropertyChanged("StreetAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TelephoneNumber {
            get {
                return this.TelephoneNumberField;
            }
            set {
                if ((this.TelephoneNumberField.Equals(value) != true)) {
                    this.TelephoneNumberField = value;
                    this.RaisePropertyChanged("TelephoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Vehicle {
            get {
                return this.VehicleField;
            }
            set {
                if ((object.ReferenceEquals(this.VehicleField, value) != true)) {
                    this.VehicleField = value;
                    this.RaisePropertyChanged("Vehicle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ZipCode {
            get {
                return this.ZipCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipCodeField, value) != true)) {
                    this.ZipCodeField = value;
                    this.RaisePropertyChanged("ZipCode");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServiceBloodCrowd")]
    public interface IServiceBloodCrowd {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/GetDonors", ReplyAction="http://tempuri.org/IServiceBloodCrowd/GetDonorsResponse")]
        WindowsFormsApp1.ServiceReference1.Donor[] GetDonors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/GetDonors", ReplyAction="http://tempuri.org/IServiceBloodCrowd/GetDonorsResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Donor[]> GetDonorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/GetDonorsByName", ReplyAction="http://tempuri.org/IServiceBloodCrowd/GetDonorsByNameResponse")]
        WindowsFormsApp1.ServiceReference1.Donor[] GetDonorsByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/GetDonorsByName", ReplyAction="http://tempuri.org/IServiceBloodCrowd/GetDonorsByNameResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Donor[]> GetDonorsByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/GetDonorsByBloodType", ReplyAction="http://tempuri.org/IServiceBloodCrowd/GetDonorsByBloodTypeResponse")]
        WindowsFormsApp1.ServiceReference1.Donor[] GetDonorsByBloodType(string sh_blood);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/GetDonorsByBloodType", ReplyAction="http://tempuri.org/IServiceBloodCrowd/GetDonorsByBloodTypeResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Donor[]> GetDonorsByBloodTypeAsync(string sh_blood);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/getBloodTypes", ReplyAction="http://tempuri.org/IServiceBloodCrowd/getBloodTypesResponse")]
        string[] getBloodTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/getBloodTypes", ReplyAction="http://tempuri.org/IServiceBloodCrowd/getBloodTypesResponse")]
        System.Threading.Tasks.Task<string[]> getBloodTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/GetDonorsByCompBlood", ReplyAction="http://tempuri.org/IServiceBloodCrowd/GetDonorsByCompBloodResponse")]
        WindowsFormsApp1.ServiceReference1.Donor[] GetDonorsByCompBlood(string bloodType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/GetDonorsByCompBlood", ReplyAction="http://tempuri.org/IServiceBloodCrowd/GetDonorsByCompBloodResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Donor[]> GetDonorsByCompBloodAsync(string bloodType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/GetDonorsByAge", ReplyAction="http://tempuri.org/IServiceBloodCrowd/GetDonorsByAgeResponse")]
        WindowsFormsApp1.ServiceReference1.Donor[] GetDonorsByAge(int minAge, int maxAge);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/GetDonorsByAge", ReplyAction="http://tempuri.org/IServiceBloodCrowd/GetDonorsByAgeResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Donor[]> GetDonorsByAgeAsync(int minAge, int maxAge);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/GetDonorsByIMC", ReplyAction="http://tempuri.org/IServiceBloodCrowd/GetDonorsByIMCResponse")]
        WindowsFormsApp1.ServiceReference1.Donor[] GetDonorsByIMC(double minIMC, double maxIMC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/GetDonorsByIMC", ReplyAction="http://tempuri.org/IServiceBloodCrowd/GetDonorsByIMCResponse")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Donor[]> GetDonorsByIMCAsync(double minIMC, double maxIMC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/addDonor", ReplyAction="http://tempuri.org/IServiceBloodCrowd/addDonorResponse")]
        bool addDonor(WindowsFormsApp1.ServiceReference1.Donor newDonor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/addDonor", ReplyAction="http://tempuri.org/IServiceBloodCrowd/addDonorResponse")]
        System.Threading.Tasks.Task<bool> addDonorAsync(WindowsFormsApp1.ServiceReference1.Donor newDonor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/ExportToXml", ReplyAction="http://tempuri.org/IServiceBloodCrowd/ExportToXmlResponse")]
        bool ExportToXml(string[] list_guid, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/ExportToXml", ReplyAction="http://tempuri.org/IServiceBloodCrowd/ExportToXmlResponse")]
        System.Threading.Tasks.Task<bool> ExportToXmlAsync(string[] list_guid, string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/CalculateIMC", ReplyAction="http://tempuri.org/IServiceBloodCrowd/CalculateIMCResponse")]
        double CalculateIMC(double kilograms, int centimeters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/CalculateIMC", ReplyAction="http://tempuri.org/IServiceBloodCrowd/CalculateIMCResponse")]
        System.Threading.Tasks.Task<double> CalculateIMCAsync(double kilograms, int centimeters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/CalculateAge", ReplyAction="http://tempuri.org/IServiceBloodCrowd/CalculateAgeResponse")]
        int CalculateAge(System.DateTime birthDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/CalculateAge", ReplyAction="http://tempuri.org/IServiceBloodCrowd/CalculateAgeResponse")]
        System.Threading.Tasks.Task<int> CalculateAgeAsync(System.DateTime birthDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/RemoveDonor", ReplyAction="http://tempuri.org/IServiceBloodCrowd/RemoveDonorResponse")]
        bool RemoveDonor(string[] guids);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBloodCrowd/RemoveDonor", ReplyAction="http://tempuri.org/IServiceBloodCrowd/RemoveDonorResponse")]
        System.Threading.Tasks.Task<bool> RemoveDonorAsync(string[] guids);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceBloodCrowdChannel : WindowsFormsApp1.ServiceReference1.IServiceBloodCrowd, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceBloodCrowdClient : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference1.IServiceBloodCrowd>, WindowsFormsApp1.ServiceReference1.IServiceBloodCrowd {
        
        public ServiceBloodCrowdClient() {
        }
        
        public ServiceBloodCrowdClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceBloodCrowdClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBloodCrowdClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBloodCrowdClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WindowsFormsApp1.ServiceReference1.Donor[] GetDonors() {
            return base.Channel.GetDonors();
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Donor[]> GetDonorsAsync() {
            return base.Channel.GetDonorsAsync();
        }
        
        public WindowsFormsApp1.ServiceReference1.Donor[] GetDonorsByName(string name) {
            return base.Channel.GetDonorsByName(name);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Donor[]> GetDonorsByNameAsync(string name) {
            return base.Channel.GetDonorsByNameAsync(name);
        }
        
        public WindowsFormsApp1.ServiceReference1.Donor[] GetDonorsByBloodType(string sh_blood) {
            return base.Channel.GetDonorsByBloodType(sh_blood);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Donor[]> GetDonorsByBloodTypeAsync(string sh_blood) {
            return base.Channel.GetDonorsByBloodTypeAsync(sh_blood);
        }
        
        public string[] getBloodTypes() {
            return base.Channel.getBloodTypes();
        }
        
        public System.Threading.Tasks.Task<string[]> getBloodTypesAsync() {
            return base.Channel.getBloodTypesAsync();
        }
        
        public WindowsFormsApp1.ServiceReference1.Donor[] GetDonorsByCompBlood(string bloodType) {
            return base.Channel.GetDonorsByCompBlood(bloodType);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Donor[]> GetDonorsByCompBloodAsync(string bloodType) {
            return base.Channel.GetDonorsByCompBloodAsync(bloodType);
        }
        
        public WindowsFormsApp1.ServiceReference1.Donor[] GetDonorsByAge(int minAge, int maxAge) {
            return base.Channel.GetDonorsByAge(minAge, maxAge);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Donor[]> GetDonorsByAgeAsync(int minAge, int maxAge) {
            return base.Channel.GetDonorsByAgeAsync(minAge, maxAge);
        }
        
        public WindowsFormsApp1.ServiceReference1.Donor[] GetDonorsByIMC(double minIMC, double maxIMC) {
            return base.Channel.GetDonorsByIMC(minIMC, maxIMC);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.Donor[]> GetDonorsByIMCAsync(double minIMC, double maxIMC) {
            return base.Channel.GetDonorsByIMCAsync(minIMC, maxIMC);
        }
        
        public bool addDonor(WindowsFormsApp1.ServiceReference1.Donor newDonor) {
            return base.Channel.addDonor(newDonor);
        }
        
        public System.Threading.Tasks.Task<bool> addDonorAsync(WindowsFormsApp1.ServiceReference1.Donor newDonor) {
            return base.Channel.addDonorAsync(newDonor);
        }
        
        public bool ExportToXml(string[] list_guid, string fileName) {
            return base.Channel.ExportToXml(list_guid, fileName);
        }
        
        public System.Threading.Tasks.Task<bool> ExportToXmlAsync(string[] list_guid, string fileName) {
            return base.Channel.ExportToXmlAsync(list_guid, fileName);
        }
        
        public double CalculateIMC(double kilograms, int centimeters) {
            return base.Channel.CalculateIMC(kilograms, centimeters);
        }
        
        public System.Threading.Tasks.Task<double> CalculateIMCAsync(double kilograms, int centimeters) {
            return base.Channel.CalculateIMCAsync(kilograms, centimeters);
        }
        
        public int CalculateAge(System.DateTime birthDate) {
            return base.Channel.CalculateAge(birthDate);
        }
        
        public System.Threading.Tasks.Task<int> CalculateAgeAsync(System.DateTime birthDate) {
            return base.Channel.CalculateAgeAsync(birthDate);
        }
        
        public bool RemoveDonor(string[] guids) {
            return base.Channel.RemoveDonor(guids);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveDonorAsync(string[] guids) {
            return base.Channel.RemoveDonorAsync(guids);
        }
    }
}
