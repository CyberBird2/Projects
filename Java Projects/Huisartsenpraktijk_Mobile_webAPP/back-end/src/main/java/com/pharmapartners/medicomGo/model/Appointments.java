package com.pharmapartners.medicomGo.model;

import javax.persistence.*;
import java.sql.Date;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.util.Objects;

@Entity
public class Appointments {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int appointmentID;

    @Column(name="patientID")
    private int patientID;

    @Column(name="appointmentDate")
    private LocalDateTime appointmentDate;

    @Column(name="notesID")
    private int notesID;

    public Appointments(){}

    public int getPatientID() {
        return patientID;
    }

    public int getAppointmentID() {
        return appointmentID;
    }

    public int getNotesID() {
        return notesID;
    }

    public LocalDateTime getAppointmentDate() {
        return appointmentDate;
    }

    public void setAppointmentDate(LocalDateTime appointmentDate) {
        this.appointmentDate = appointmentDate;
    }

    public void setNotesID(int notesID) {
        this.notesID = notesID;
    }

    public void setPatientID(int patientID) {
        this.patientID = patientID;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Appointments that = (Appointments) o;
        return getAppointmentID() == that.getAppointmentID() &&
                getPatientID() == that.getPatientID() &&
                getNotesID() == that.getNotesID() &&
                Objects.equals(getAppointmentDate(), that.getAppointmentDate());
    }

    @Override
    public int hashCode() {
        return Objects.hash(getAppointmentID(), getPatientID(), getAppointmentDate(), getNotesID());
    }

    @Override
    public String toString() {
        return "Appointments{" +
                "appointmentID=" + appointmentID +
                ", patientID=" + patientID +
                ", appointmentDate=" + appointmentDate +
                ", notesID=" + notesID +
                '}';
    }
}
