package wondi.example.ToDoList.Repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import wondi.example.ToDoList.Model.Department;



public interface DepartmentRepository extends JpaRepository <Department, Integer> {

}
