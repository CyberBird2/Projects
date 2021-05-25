package com.pharmapartners.medicomGo.model;

import javax.persistence.*;
import java.time.LocalDate;
import java.util.Objects;

@Entity
public class Vaccine {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int vaccineID;
    @Column(name="patientID")
    private int patientID;

    private String vaccineName;
    private String vaccineDescription;
    private LocalDate initialDate;
    private LocalDate expiryDate;

    public Vaccine(){}
    public Vaccine(int patientID,String vaccineName,String vaccineDescription,LocalDate initialDate,LocalDate expiryDate){
        this.patientID=patientID;
        this.vaccineDescription=vaccineDescription;
        this.vaccineName=vaccineName;
        this.initialDate=initialDate;
        this.expiryDate=expiryDate;
    }

    public int getPatientID() {
        return patientID;
    }

    public int getVaccineID() {
        return vaccineID;
    }

    public String getVaccineDescription() {
        return vaccineDescription;
    }

    public String getVaccineName() {
        return vaccineName;
    }

    public LocalDate getInitialDate() {
        return initialDate;
    }

    public LocalDate getExpiryDate() {
        return expiryDate;
    }

    public void setVaccineID(int vaccineID) {
        this.vaccineID = vaccineID;
    }

    public void setVaccineName(String vaccineName) {
        this.vaccineName = vaccineName;
    }

    public void setVaccineDescription(String vaccineDescription) {
        this.vaccineDescription = vaccineDescription;
    }

    public void setExpiryDate(LocalDate expiryDate) {
        this.expiryDate = expiryDate;
    }

    public void setInitialDate(LocalDate initialDate) {
        this.initialDate = initialDate;
    }

    public void setPatientID(int patientID) {
        this.patientID = patientID;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Vaccine vaccine = (Vaccine) o;
        return vaccineID == vaccine.vaccineID &&
                getPatientID() == vaccine.getPatientID() &&
                Objects.equals(vaccineName, vaccine.vaccineName) &&
                Objects.equals(vaccineDescription, vaccine.vaccineDescription) &&
                Objects.equals(initialDate, vaccine.initialDate) &&
                Objects.equals(expiryDate, vaccine.expiryDate);
    }

    @Override
    public int hashCode() {
        return Objects.hash(vaccineID, getPatientID(), vaccineName, vaccineDescription, initialDate, expiryDate);
    }

    @Override
    public String toString() {
        return "Vaccine{" +
                "vaccineID=" + vaccineID +
                ", patientID=" + patientID +
                ", vaccineName='" + vaccineName + '\'' +
                ", vaccineDescription='" + vaccineDescription + '\'' +
                ", initialDate=" + initialDate +
                ", expiryDate=" + expiryDate +
                '}';
    }
}
