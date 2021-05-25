package com.pharmapartners.medicomGo.model;

import javax.persistence.*;

import java.sql.Date;
import java.util.Objects;

@Entity
@Table(name = "labresults")
public class LabResults {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int labResultID;
    private int patientID;
    private String resultDescription;
    private String labName;
    private Date dateTaken;
    private Date dateReady;

    public LabResults(){}
    public LabResults(int patientID,String resultDescription,String labName,Date dateTaken,Date dateReady){
        this.patientID=patientID;
        this.resultDescription=resultDescription;
        this.labName=labName;
        this.dateTaken=dateTaken;
        this.dateReady=dateReady;
    }
    public int getLabResultID() {
        return labResultID;
    }

    public int getPatientID() {
        return patientID;
    }

    public String getResultDescription() {
        return resultDescription;
    }

    public String getLabName() {
        return labName;
    }

    public Date getDateReady() {
        return dateReady;
    }

    public Date getDateTaken() {
        return dateTaken;
    }

    public void setPatientID(int patientID) {
        this.patientID = patientID;
    }

    public void setResultDescription(String resultDescription) {
        this.resultDescription = resultDescription;
    }

    public void setLabName(String labName) {
        this.labName = labName;
    }

    public void setDateReady(Date dateReady) {
        this.dateReady = dateReady;
    }

    public void setDateTaken(Date dateTaken) {
        this.dateTaken = dateTaken;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        LabResults that = (LabResults) o;
        return getLabResultID() == that.getLabResultID() &&
                getPatientID() == that.getPatientID() &&
                Objects.equals(getResultDescription(), that.getResultDescription()) &&
                Objects.equals(getLabName(), that.getLabName()) &&
                Objects.equals(getDateTaken(), that.getDateTaken()) &&
                Objects.equals(getDateReady(), that.getDateReady());
    }

    @Override
    public int hashCode() {
        return Objects.hash(getLabResultID(), getPatientID(), getResultDescription(), getLabName(), getDateTaken(), getDateReady());
    }

    @Override
    public String toString() {
        return "LabResults{" +
                "labResultID=" + labResultID +
                ", patientID=" + patientID +
                ", resultDescription='" + resultDescription + '\'' +
                ", labName='" + labName + '\'' +
                ", dateTaken=" + dateTaken +
                ", dateReady=" + dateReady +
                '}';
    }
}
