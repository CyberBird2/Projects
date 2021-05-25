package com.pharmapartners.medicomGo.repository;

import com.pharmapartners.medicomGo.model.Patient;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface PatientRepository extends JpaRepository<Patient, Integer> {

    Patient findByPatientID(int patientID);
    List<Patient>findByFirstNameContainingOrLastNameContaining(String nameContains,String nameContains2);
}
