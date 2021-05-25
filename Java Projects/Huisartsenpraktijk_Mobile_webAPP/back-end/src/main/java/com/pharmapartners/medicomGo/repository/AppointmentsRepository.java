package com.pharmapartners.medicomGo.repository;

import com.pharmapartners.medicomGo.model.Appointments;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.sql.Date;
import java.util.List;

@Repository
public interface AppointmentsRepository extends JpaRepository<Appointments,Integer> {
    List<Appointments>findAllByPatientID(int patientID);
    List<Appointments>findAppointmentsByAppointmentDate(Date date);
}
