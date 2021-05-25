package wondi.example.ToDoList.APILayer;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import wondi.example.ToDoList.Model.Role;
import wondi.example.ToDoList.Service.DepartmentService;
import wondi.example.ToDoList.Service.EmployeeService;
import wondi.example.ToDoList.Service.RoleService;

import java.util.List;
import java.util.NoSuchElementException;

@RestController
@CrossOrigin(origins = "http://localhost:4200")
public class RoleController {


    RoleService roleService;
    EmployeeService employeeService;
    DepartmentService departmentService;

    @Autowired
    public RoleController(RoleService roleService, EmployeeService employeeService, DepartmentService departmentService) {
        this.roleService = roleService;
        this.employeeService = employeeService;
        this.departmentService = departmentService;
    }

    // GET = get all roles
    @GetMapping(value = "/roles")
    public List<Role> list() {
        return roleService.listAllRoles();
    }

    // GET = get all role by id
    @GetMapping(value = "/roles/{id}")
    public ResponseEntity<Role> get(@PathVariable Integer id) {
        try {
            Role role = roleService.UpdateRoleByID(id);
            return new ResponseEntity<>(role, HttpStatus.OK);


        } catch (NoSuchElementException e) {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }
    // POSt = add roles
    @PostMapping(value = "/roles")
    public void add(@RequestBody Role role) {
        roleService.saveRole(role);

    }
    // PUT = update roles
    @PutMapping(value = "/roles/{id}")
    public ResponseEntity<Role> update(@RequestBody Role role, @PathVariable Integer id) {
        try {
            roleService.UpdateRoleByID(id);
            role.setId(id);
            roleService.saveRole(role);
            return new ResponseEntity<>(HttpStatus.OK);
        } catch (NoSuchElementException e) {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }
    @DeleteMapping(value = "/roles/{id}")
    public void delete(@PathVariable Integer id) {
        roleService.deleteRoleByID(id);

    }

}
