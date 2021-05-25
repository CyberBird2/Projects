package com.pharmapartners.medicomGo.model;

import javax.persistence.*;
import java.util.Objects;

@Entity
@Table(name="previousdiseases")
public class Diseases {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int diseaseID;

    @Column(name="patientID")
    private int patientID;

    private String disease;

    public Diseases(){}
    public Diseases(int patientID,String disease){
        this.patientID=patientID;
        this.disease=disease;
    }

    public int getPatientID() {
        return patientID;
    }

    public int getDiseaseID() {
        return diseaseID;
    }

    public String getDisease() {
        return disease;
    }

    @Override
    public String toString() {
        return "Diseases{" +
                "diseaseID=" + diseaseID +
                ", patientID=" + patientID +
                ", disease='" + disease + '\'' +
                '}';
    }

    public void setPatientID(int patientID) {
        this.patientID = patientID;
    }

    public void setDisease(String disease) {
        this.disease = disease;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Diseases diseases = (Diseases) o;
        return getDiseaseID() == diseases.getDiseaseID() &&
                getPatientID() == diseases.getPatientID() &&
                Objects.equals(getDisease(), diseases.getDisease());
    }

    @Override
    public int hashCode() {
        return Objects.hash(getDiseaseID(), getPatientID(), getDisease());
    }
}
