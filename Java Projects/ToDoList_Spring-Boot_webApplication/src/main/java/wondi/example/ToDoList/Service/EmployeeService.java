package wondi.example.ToDoList.Service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import wondi.example.ToDoList.Model.Employee;
import wondi.example.ToDoList.Repository.EmployeeRepository;

import javax.transaction.Transactional;
import java.util.List;

@Service
public class EmployeeService {

    @Autowired
    // declare employee repository
    private EmployeeRepository employeeRepository;

    // Get all employees
    public  List<Employee> listAllEmployee()
    {
        return employeeRepository.findAll();
    }

    // add employee
    public Employee saveEmployee(Employee employee) {
        return  employeeRepository.save(employee);
    }
    // update employee by id
    public Employee getEmployeeById(Integer id) {
        return employeeRepository.findById(id).orElseThrow();
    }

    // Delete employee by Id
    public void deleteEmployeeById(Integer id) {
        employeeRepository.deleteById(id);
    }


}
