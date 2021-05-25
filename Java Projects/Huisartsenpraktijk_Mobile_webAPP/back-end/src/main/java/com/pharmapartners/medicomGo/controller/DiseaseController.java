package com.pharmapartners.medicomGo.controller;

import com.pharmapartners.medicomGo.model.Diseases;
import com.pharmapartners.medicomGo.repository.DiseaseRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("diseases")
public class DiseaseController {
    @Autowired
    DiseaseRepository diseaseRepository;

    @CrossOrigin
    @GetMapping("/all/{id}")
    public List<Diseases>getAllDiseasesByPatientID(@PathVariable String id){
        int patientID=Integer.parseInt(id);
        return diseaseRepository.findAllByPatientID(patientID);
    }
}
