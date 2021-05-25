package com.pharmapartners.medicomGo.controller;

import com.pharmapartners.medicomGo.model.Appointments;
import com.pharmapartners.medicomGo.repository.AppointmentsRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;


import java.text.ParseException;
import java.text.SimpleDateFormat;

import java.util.List;

@RestController
@RequestMapping("appointments")
public class AppointmentsController {

    @Autowired
    AppointmentsRepository appointmentsRepository;

    @CrossOrigin
    @GetMapping("/all")
    public List<Appointments> getAllAppointments(){
        return appointmentsRepository.findAll();
    }
    @CrossOrigin
    @GetMapping("/patient/{id}")
    public List<Appointments> getAllAppointmentsForSpecificPatient(@PathVariable String id){
        int patientID= Integer.parseInt(id);
        return appointmentsRepository.findAllByPatientID(patientID);
    }



}
