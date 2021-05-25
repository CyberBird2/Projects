package com.pharmapartners.medicomGo.controller;

import com.pharmapartners.medicomGo.model.Vaccine;
import com.pharmapartners.medicomGo.repository.VaccineRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("vaccine")
public class VaccineController {
    @Autowired
    VaccineRepository vaccineRepository;

    @CrossOrigin
    @GetMapping("/all/{id}")
    public List<Vaccine> getAllVaccinesForPatientWithID(@PathVariable String id){
        int patientID=Integer.parseInt(id);
        return vaccineRepository.findAllByPatientID(patientID);
    }
}
