package com.pharmapartners.medicomGo.model;

import javax.persistence.*;
import java.util.Objects;

@Entity
@Table(name="allergies")
public class Allergies {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int allergyID;


    private int patientID;
    private String allergyName;
    private String allergyDescription;

    public Allergies(){}

    public int getAllergyID() {
        return allergyID;
    }

    public String getAllergyDescription() {
        return allergyDescription;
    }

    public int getPatientID() {
        return patientID;
    }

    public String getAllergyName() {
        return allergyName;
    }
    public void setAllergyName(String allergyName) {
        this.allergyName = allergyName;
    }

    public void setAllergyDescription(String allergyDescription) {
        this.allergyDescription = allergyDescription;
    }


    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Allergies allergies = (Allergies) o;
        return getAllergyID() == allergies.getAllergyID();
    }

    @Override
    public int hashCode() {
        return Objects.hash(getAllergyID());
    }

    @Override
    public String toString() {
        return "Allergies{" +
                "allergyID=" + allergyID +
                ", allergyName='" + allergyName + '\'' +
                ", allergyDescription='" + allergyDescription + '\'' +
                '}';
    }
}
