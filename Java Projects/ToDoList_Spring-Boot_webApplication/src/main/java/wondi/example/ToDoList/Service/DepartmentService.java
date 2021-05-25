package wondi.example.ToDoList.Service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Service;
import wondi.example.ToDoList.Model.Department;
import wondi.example.ToDoList.Repository.DepartmentRepository;


import java.util.List;

//@Transactional
@Service
public class DepartmentService {

    @Autowired
    // declare department repository
    private DepartmentRepository departmentRepository;

    //  get all departments
    public List<Department> listAllDepartment()
    {
        return departmentRepository.findAll();
    }
    // add department
    public Department saveDepartment(Department department) {
      return departmentRepository.save(department);
    }

    // update department by id
    public Department updateDepartmentById(Integer id) {

        return departmentRepository.findById(id).orElse(null);
    }

    // Delete department by Id
    public void deleteDepartmentById(Integer id) {
        departmentRepository.deleteById(id);
    }


}
