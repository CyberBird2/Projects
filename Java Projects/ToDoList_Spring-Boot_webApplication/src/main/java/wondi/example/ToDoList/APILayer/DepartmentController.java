package wondi.example.ToDoList.APILayer;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import wondi.example.ToDoList.Model.Department;

import wondi.example.ToDoList.Service.DepartmentService;
import wondi.example.ToDoList.Service.EmployeeService;
import wondi.example.ToDoList.Service.RoleService;


import java.util.List;
import java.util.NoSuchElementException;

@RestController
@CrossOrigin(origins = "http://localhost:4200")
public class DepartmentController {


    DepartmentService departmentService;
    EmployeeService employeeService;
    RoleService  roleService;

    @Autowired
    public DepartmentController(DepartmentService departmentService, EmployeeService employeeService, RoleService roleService) {
        this.departmentService = departmentService;
        this.employeeService = employeeService;
        this.roleService = roleService;
    }

    // GET = get all departments
    @GetMapping(value = "/departments")
    public List<Department> list() {
        return departmentService.listAllDepartment();

    }

    // GET = get all department by id
    @GetMapping("/departments/{id}")

    public ResponseEntity<Department> get(@PathVariable Integer id) {
        try {
            Department department = departmentService.updateDepartmentById(id);

            return new ResponseEntity<>(department, HttpStatus.OK);


        } catch (NoSuchElementException e) {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }
    // POSt = add department
    @PostMapping("/departments")
    public void add(@RequestBody Department department) {
        departmentService.saveDepartment(department);
    }

    // PUT = update department
    @PutMapping("/departments/{id}")
    public ResponseEntity<Department> update(@RequestBody Department department, @PathVariable Integer id) {
        try {
            departmentService.updateDepartmentById(id);
            department.setId(id);
            departmentService.saveDepartment(department);


            return new ResponseEntity<>(HttpStatus.OK);
        } catch (NoSuchElementException e) {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }

    // Delete Department by Id
    @DeleteMapping("/departments/{id}")
    public void delete(@PathVariable Integer id) {
        departmentService.deleteDepartmentById(id);

    }

}
