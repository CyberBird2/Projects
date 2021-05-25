package com.pharmapartners.medicomGo.repository;

import com.pharmapartners.medicomGo.model.Diseases;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface DiseaseRepository extends JpaRepository<Diseases,Integer> {
    List<Diseases> findAllByPatientID(int patientID);
}
