package com.pharmapartners.medicomGo.model;

import javax.persistence.*;
import java.util.Objects;

@Entity
@Table(name="notes")
public class Note {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int notesID;

    private String notesContent;

    @Column(name="patientID")
    private int patientID;

    public Note(){}
    public Note(int patientID,String notesContent){
        this.patientID=patientID;
        this.notesContent=notesContent;
    }
    public int getNotesID() {
        return notesID;
    }

    public int getPatientID() {
        return patientID;
    }

    public String getNotesContent() {
        return notesContent;
    }

    public void setNotesContent(String notesContent) {
        this.notesContent = notesContent;
    }

    public void setPatientID(int patientID) {
        this.patientID = patientID;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Note note = (Note) o;
        return getNotesID() == note.getNotesID() &&
                getPatientID() == note.getPatientID() &&
                Objects.equals(getNotesContent(), note.getNotesContent());
    }

    @Override
    public int hashCode() {
        return Objects.hash(getNotesID(), getNotesContent(), getPatientID());
    }

    @Override
    public String toString() {
        return "Note{" +
                "notesID=" + notesID +
                ", notesContent='" + notesContent + '\'' +
                ", patientID=" + patientID +
                '}';
    }
}
