package pt.ipleiria.celsoteixeira.mobileapplication.model;

import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.JsonSerializer;
import java.io.Serializable;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;




/**
 * Created by celsoTeixeira on 12/19/2017.
 */


public class Donor implements Serializable{
    @SerializedName("Number")
    private int number;
    @SerializedName("Gender")
    private String gender;
    @SerializedName("GivenName")
    private String givenName;
    @SerializedName("Surname")
    private String surname;
    @SerializedName("StreetAddress")
    private String streetAddress;
    @SerializedName("City")
    private String city;
    @SerializedName("StateFull")
    private String stateFull;
    @SerializedName("ZipCode")
    private String zipCode;
    @SerializedName("EmailAddress")
    private String emailAddress;
    @SerializedName("Username")
    private String username;
    @SerializedName("Password")
    private String password;
    @SerializedName("TelephoneNumber")
    private String telephoneNumber;
    @SerializedName("MothersMaiden")
    private String mothersMaiden;
    @SerializedName("Birthday")
    private Date birthday;
    @SerializedName("Age")
    private int age;
    @SerializedName("Occupation")
    private String occupation;
    @SerializedName("Company")
    private String company;
    @SerializedName("Vehicle")
    private String vehicle;
    @SerializedName("BloodType")
    private String bloodType;
    @SerializedName("Kilograms")
    private double kilograms;
    @SerializedName("Centimeters")
    private int centimeters;
    @SerializedName("Guid")
    private String guid;
    @SerializedName("Latitude")
    private double latitude;
    @SerializedName("Longitude")
    private double longitude;
    @SerializedName("Imc")
    private double imc;

    public Donor(int number, String gender, String givenName, String surname, String streetAddress, String city, String stateFull, String zipCode, String emailAddress, String username, String password, String telephoneNumber, String mothersMaiden, Date birthday, int age, String occupation, String company, String vehicle, String bloodType, double kilograms, int centimeters, String guid, double latitude, double longitude, double imc) {
        this.number = number;
        this.gender = gender;
        this.givenName = givenName;
        this.surname = surname;
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateFull = stateFull;
        this.zipCode = zipCode;
        this.emailAddress = emailAddress;
        this.username = username;
        this.password = password;
        this.telephoneNumber = telephoneNumber;
        this.mothersMaiden = mothersMaiden;
        this.birthday = birthday;
        this.age = age;
        this.occupation = occupation;
        this.company = company;
        this.vehicle = vehicle;
        this.bloodType = bloodType;
        this.kilograms = kilograms;
        this.centimeters = centimeters;
        this.guid = guid;
        this.latitude = latitude;
        this.longitude = longitude;
        this.imc = imc;


    }



    public int getNumber() {
        return number;
    }

    public void setNumber(int number) {
        this.number = number;
    }

    public String getGender() {
        return gender;
    }

    public void setGender(String gender) {
        this.gender = gender;
    }

    public String getGivenName() {
        return givenName;
    }

    public void setGivenName(String givenName) {
        this.givenName = givenName;
    }

    public String getSurname() {
        return surname;
    }

    public void setSurname(String surname) {
        this.surname = surname;
    }

    public String getStreetAddress() {
        return streetAddress;
    }

    public void setStreetAddress(String streetAddress) {
        this.streetAddress = streetAddress;
    }

    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public String getStateFull() {
        return stateFull;
    }

    public void setStateFull(String stateFull) {
        this.stateFull = stateFull;
    }

    public String getZipCode() {
        return zipCode;
    }

    public void setZipCode(String zipCode) {
        this.zipCode = zipCode;
    }

    public String getEmailAddress() {
        return emailAddress;
    }

    public void setEmailAddress(String emailAddress) {
        this.emailAddress = emailAddress;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getTelephoneNumber() {
        return telephoneNumber;
    }

    public void setTelephoneNumber(String telephoneNumber) {
        this.telephoneNumber = telephoneNumber;
    }

    public String getMothersMaiden() {
        return mothersMaiden;
    }

    public void setMothersMaiden(String mothersMaiden) {
        this.mothersMaiden = mothersMaiden;
    }

    public Date getBirthday() {

        return birthday;
    }

    public void setBirthday(Date birthday) {
        this.birthday = birthday;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public String getOccupation() {
        return occupation;
    }

    public void setOccupation(String occupation) {
        this.occupation = occupation;
    }

    public String getCompany() {
        return company;
    }

    public void setCompany(String company) {
        this.company = company;
    }

    public String getVehicle() {
        return vehicle;
    }

    public void setVehicle(String vehicle) {
        this.vehicle = vehicle;
    }

    public String getBloodType() {
        return bloodType;
    }

    public void setBloodType(String bloodType) {
        this.bloodType = bloodType;
    }

    public double getKilograms() {
        return kilograms;
    }

    public void setKilograms(double kilograms) {
        this.kilograms = kilograms;
    }

    public int getCentimeters() {
        return centimeters;
    }

    public void setCentimeters(int centimeters) {
        this.centimeters = centimeters;
    }

    public String getGuid() {
        return guid;
    }

    public void setGuid(String guid) {
        this.guid = guid;
    }

    public double getLatitude() {
        return latitude;
    }

    public void setLatitude(double latitude) {
        this.latitude = latitude;
    }

    public double getLongitude() {
        return longitude;
    }

    public void setLongitude(double longitude) {
        this.longitude = longitude;
    }

    public double getImc() {
        return imc;
    }

    public void setImc(double imc) {
        this.imc = imc;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;

        Donor donor = (Donor) o;

        if (number != donor.number) return false;
        if (!emailAddress.equals(donor.emailAddress)) return false;
        return guid.equals(donor.guid);
    }


    @Override
    public int hashCode() {
        int result = number;
        result = 31 * result + emailAddress.hashCode();
        result = 31 * result + guid.hashCode();
        return result;
    }

    @Override
    public String toString() {

        StringBuilder sb = new StringBuilder();
        sb.append("GivenName: ").append(givenName).append(" ").append("BloodType: ").append(bloodType).append(" ").append("IMC: ").append(imc).append("\n");
        return sb.toString();
    }
}

