package com.pharmapartners.medicomGo.controller;

import com.pharmapartners.medicomGo.model.MedicinePrescription;
import com.pharmapartners.medicomGo.repository.MedicinePrescriptionRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("prescription")
public class MedicinePrescriptionController {
    @Autowired
    MedicinePrescriptionRepository medicinePrescriptionRepository;

    @CrossOrigin
    @GetMapping("/all/{id}")
    public List<MedicinePrescription> findMedicinePrescriptionsForPatientWithID(@PathVariable String id){
        int patientId = Integer.parseInt(id);
        return medicinePrescriptionRepository.findAllByPatientID(patientId);
    }
    @CrossOrigin
    @GetMapping("/{id}")
    public MedicinePrescription findMedicinePrescriptionWithID(@PathVariable String id){
        int patientId = Integer.parseInt(id);
        return medicinePrescriptionRepository.findByPrescriptionID(patientId);
    }
}
