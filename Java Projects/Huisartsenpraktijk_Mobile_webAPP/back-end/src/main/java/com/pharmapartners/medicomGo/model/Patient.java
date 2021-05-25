package com.pharmapartners.medicomGo.model;

import javax.persistence.*;
import java.util.List;
import java.util.Objects;

@Entity
public class Patient {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int patientID;

    private String  firstName;
    private String lastName;
    private int age;
    private String address;
    private String contact;
    private String emergencyContact;

    public Patient(){}
    public Patient(String firstName,String lastName,int age,String address, String contact, String emergencyContact){
        this.firstName=firstName;
        this.lastName=lastName;
        this.age=age;
        this.address=address;
        this.contact=contact;
        this.emergencyContact=emergencyContact;
    }

    public int getPatientID() {
        return patientID;
    }

    public int getAge() {
        return age;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public String getAddress() {
        return address;
    }

    public String getContact() {
        return contact;
    }

    public String getEmergencyContact() {
        return emergencyContact;
    }


    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public void setContact(String contact) {
        this.contact = contact;
    }

    public void setEmergencyContact(String emergencyContact) {
        this.emergencyContact = emergencyContact;
    }

    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Patient patient = (Patient) o;
        return Objects.equals(patientID, patient.patientID);
    }
    public int hashCode() {
        return Objects.hash(patientID);
    }

    @Override
    public String toString() {
        return "Patient{" +
                "patientID=" + patientID +
                ", firstName='" + firstName + '\'' +
                ", lastName='" + lastName + '\'' +
                ", age=" + age +
                ", address='" + address + '\'' +
                ", contact='" + contact + '\'' +
                ", emergencyContact='" + emergencyContact + '\'' +
                '}';
    }
}
