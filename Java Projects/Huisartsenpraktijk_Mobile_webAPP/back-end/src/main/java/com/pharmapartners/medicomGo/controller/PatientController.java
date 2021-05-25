package com.pharmapartners.medicomGo.controller;

import com.pharmapartners.medicomGo.model.Patient;
import com.pharmapartners.medicomGo.repository.PatientRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("patients")
public class PatientController {
    @Autowired
    PatientRepository patientRepository;

    @CrossOrigin
    @RequestMapping(method = RequestMethod.GET,path="/all")
    public List<Patient> getAllPatients(){return patientRepository.findAll();}

    @CrossOrigin
    @GetMapping("/{id}")
    public Patient findSpecificPatient(@PathVariable String id){
        int patientId = Integer.parseInt(id);
        return patientRepository.findByPatientID(patientId);
    }

    @CrossOrigin
    @GetMapping("search/{name}")
    public List<Patient> searchForPatient(@PathVariable String name){
        List<Patient> patients = patientRepository.findByFirstNameContainingOrLastNameContaining(name,name);
        if(patients != null || patients.isEmpty()){
            return patients;
        }
        else{
            return null;
        }

    }
}
