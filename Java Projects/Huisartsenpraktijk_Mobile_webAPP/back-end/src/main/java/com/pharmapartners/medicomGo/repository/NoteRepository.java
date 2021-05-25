package com.pharmapartners.medicomGo.repository;

import com.pharmapartners.medicomGo.model.Note;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface NoteRepository extends JpaRepository<Note,Integer> {
    List<Note>findAllByPatientID(int patientID);
    Note findByNotesID(int noteID);
}
