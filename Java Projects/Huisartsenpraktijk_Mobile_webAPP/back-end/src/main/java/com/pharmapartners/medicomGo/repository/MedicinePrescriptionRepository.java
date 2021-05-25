package com.pharmapartners.medicomGo.repository;

import com.pharmapartners.medicomGo.model.MedicinePrescription;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface MedicinePrescriptionRepository extends JpaRepository<MedicinePrescription,Integer> {
    List<MedicinePrescription>findAllByPatientID(int patientID);
    MedicinePrescription findByPrescriptionID(int prescriptionID);
}
