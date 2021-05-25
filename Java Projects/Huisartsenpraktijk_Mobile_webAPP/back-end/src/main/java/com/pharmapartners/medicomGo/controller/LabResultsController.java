package com.pharmapartners.medicomGo.controller;

import com.pharmapartners.medicomGo.model.LabResults;
import com.pharmapartners.medicomGo.repository.LabResultsRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
@RequestMapping("results")
public class LabResultsController {

    @Autowired
    LabResultsRepository labResultsRepository;

    @CrossOrigin
    @RequestMapping(method = RequestMethod.GET,path="/all")
    public List<LabResults> getAllLabResults(){return labResultsRepository.findAll();}
}
