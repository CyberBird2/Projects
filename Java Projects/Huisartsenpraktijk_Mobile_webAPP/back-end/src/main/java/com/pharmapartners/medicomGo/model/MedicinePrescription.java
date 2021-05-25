package com.pharmapartners.medicomGo.model;

import javax.persistence.*;
import java.util.Objects;

@Entity
@Table(name="medicineprescription")
public class MedicinePrescription {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int prescriptionID;

    private int patientID;

    private String prescription;

    public int getPrescriptionID() {
        return prescriptionID;
    }
    public int getPatientID() {
        return patientID;
    }

    public String getPrescription() {
        return prescription;
    }

    public void setPrescription(String prescription) {
        this.prescription = prescription;
    }

    public void setPatientID(int patientID) {
        this.patientID = patientID;
    }

    public MedicinePrescription(){}

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        MedicinePrescription that = (MedicinePrescription) o;
        return getPrescriptionID() == that.getPrescriptionID() &&
                getPatientID() == that.getPatientID() &&
                Objects.equals(getPrescription(), that.getPrescription());
    }

    @Override
    public int hashCode() {
        return Objects.hash(getPrescriptionID(), getPatientID(), getPrescription());
    }

    @Override
    public String toString() {
        return "MedicinePrescription{" +
                "prescriptionID=" + prescriptionID +
                ", patientID=" + patientID +
                ", prescription='" + prescription + '\'' +
                '}';
    }
}
