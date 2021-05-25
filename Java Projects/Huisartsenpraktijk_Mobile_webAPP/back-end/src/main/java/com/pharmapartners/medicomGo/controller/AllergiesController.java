package com.pharmapartners.medicomGo.controller;

import com.pharmapartners.medicomGo.model.Allergies;
import com.pharmapartners.medicomGo.repository.AllergiesRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("allergies")
public class AllergiesController {
    @Autowired
    AllergiesRepository allergiesRepository;

    @CrossOrigin
    @GetMapping("/{id}")
    public List<Allergies> findAllergiesForPatientWithID(@PathVariable String id){
        int patientId = Integer.parseInt(id);
        return allergiesRepository.findAllByPatientID(patientId);
    }
}
