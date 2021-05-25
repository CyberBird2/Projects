package com.pharmapartners.medicomGo.repository;

import com.pharmapartners.medicomGo.model.Allergies;
import com.pharmapartners.medicomGo.model.Patient;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface AllergiesRepository extends JpaRepository<Allergies,Integer> {

    List<Allergies>findAllByPatientID(int patientID);
}
