package com.pharmapartners.medicomGo.controller;

import com.pharmapartners.medicomGo.model.MedicinePrescription;
import com.pharmapartners.medicomGo.model.Note;
import com.pharmapartners.medicomGo.repository.NoteRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.persistence.GeneratedValue;
import java.util.List;

@RestController
@RequestMapping("notes")
public class NoteController {
    @Autowired
    NoteRepository noteRepository;

    @CrossOrigin
    @GetMapping("/all/{id}")
    public List<Note> findNotesForPatientWithID(@PathVariable String id){
        int patientId = Integer.parseInt(id);
        return noteRepository.findAllByPatientID(patientId);
    }
    @CrossOrigin
    @GetMapping("/{id}")
    public Note findNoteWithID(@PathVariable String id){
        int noteId = Integer.parseInt(id);
        return  noteRepository.findByNotesID(noteId);
    }

    @CrossOrigin
    @PutMapping("updateNotes/{id}")
    public Note replaceOrAddToNote(@RequestBody Note updatedNote,@PathVariable String id){
        int noteId = Integer.parseInt(id);
        return noteRepository.findById(noteId)
                .map(note -> {
                    note.setNotesContent(updatedNote.getNotesContent());
                    return noteRepository.save(note);
                }).orElseGet(()->{
                   return noteRepository.save(updatedNote);
                });
    }

    @CrossOrigin
    @PostMapping("/addNotes")
    Note newNote(@RequestBody Note newNote) {
        Note note=new Note();
        note.setNotesContent(newNote.getNotesContent());
        note.setPatientID((newNote.getPatientID()));
        return noteRepository.save(note);
    }
}
