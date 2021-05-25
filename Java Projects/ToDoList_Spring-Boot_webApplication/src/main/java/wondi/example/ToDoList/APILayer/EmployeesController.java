package wondi.example.ToDoList.APILayer;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import wondi.example.ToDoList.Model.Employee;

import wondi.example.ToDoList.Service.DepartmentService;
import wondi.example.ToDoList.Service.EmployeeService;
import wondi.example.ToDoList.Service.RoleService;
import wondi.example.ToDoList.Service.TaskService;

import java.util.List;
import java.util.NoSuchElementException;

@RestController
@CrossOrigin(origins = "http://localhost:4200")
public class EmployeesController {


    EmployeeService employeeService;
    DepartmentService departmentService;
    RoleService roleService;
    TaskService taskService;

    @Autowired
    public EmployeesController(EmployeeService employeeService, DepartmentService departmentService, RoleService roleService, TaskService taskService) {
        this.employeeService = employeeService;
        this.departmentService = departmentService;
        this.roleService = roleService;
        this.taskService = taskService;
    }

    // GET = get all employees
    @GetMapping("/employees")
    public List<Employee> list() {
        return employeeService.listAllEmployee();

    }

    // GET = get all employee by id
    @GetMapping("/employees/{id}")
    public ResponseEntity<Employee> get(@PathVariable Integer id) {
        try {
            Employee employee = employeeService.getEmployeeById(id);

            return new ResponseEntity<>(employee, HttpStatus.OK);


        } catch (NoSuchElementException e) {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }
    // POSt = add employee
    @PostMapping("/employees")
    public void add(@RequestBody Employee employee) {
        employeeService.saveEmployee(employee);

    }
    // PUT = update employee
    @PutMapping("/employees/{id}")
    public ResponseEntity<Employee> update(@RequestBody Employee employee, @PathVariable Integer id) {
        try {
            employeeService.getEmployeeById(id);
            employee.setId(id);
            employeeService.saveEmployee(employee);

            return new ResponseEntity<>(HttpStatus.OK);
        } catch (NoSuchElementException e) {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }
    // Delete employee by Id
    @DeleteMapping("/employees/{id}")
    public void delete(@PathVariable Integer id) {
        employeeService.deleteEmployeeById(id);

    }


}
