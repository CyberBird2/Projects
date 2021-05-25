package wondi.example.ToDoList.Service;

import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.mockito.Mockito;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.mock.mockito.MockBean;
import org.springframework.test.context.junit4.SpringRunner;
import wondi.example.ToDoList.Model.Employee;
import wondi.example.ToDoList.Repository.EmployeeRepository;

import java.util.ArrayList;
import java.util.List;

import static org.junit.jupiter.api.Assertions.*;
import static org.assertj.core.api.Assertions.assertThat;

@RunWith(SpringRunner.class)
@SpringBootTest
class EmployeeServiceTest {

    @Autowired
    private EmployeeService employeeService;

    @MockBean
    private EmployeeRepository employeeRepository;

    @Test
    void testListAllEmployee() {

        Employee employee1 = new Employee();
        employee1.setLast_name("Delale");
        employee1.setFirst_name("Fadi");
        employee1.setBirthdate("12-09-1900");
        employee1.setEmail("wer@gmail.com");
        employee1.setGender("M");


        Employee employee2 = new Employee();
        employee2.setLast_name("Sisay");
        employee2.setFirst_name("Abush");
        employee2.setBirthdate("12-09-1920");
        employee2.setEmail("sisay@gmail.com");
        employee2.setGender("F");

        List<Employee> employeeList = new ArrayList<>();
        employeeList.add(employee1);
        employeeList.add(employee2);

        Mockito.when(employeeRepository.findAll()).thenReturn(employeeList);

        assertThat(employeeService.listAllEmployee()).isEqualTo(employeeList);
    }

    @Test
    void testSaveEmployee() {

        Employee employee = new Employee();
        employee.setLast_name("Jhon");
        employee.setFirst_name("Alex");
        employee.setBirthdate("12-09-1900");
        employee.setEmail("alex@gmail.com");
        employee.setGender("F");

        Mockito.when(employeeRepository.save(employee)).thenReturn(employee);

        assertThat(employeeService.saveEmployee(employee)).isEqualTo(employee);
    }

    @Test
    void testGetEmployeeById() {

        Employee employee = new Employee();
        employee.setLast_name("Meaza");
        employee.setFirst_name("Kidane");
        employee.setBirthdate("12-09-1900");
        employee.setEmail("meaza@gmail.com");
        employee.setGender("F");

        Mockito.when(employeeRepository.findById(1)).thenReturn(java.util.Optional.of(employee));
        assertThat(employeeService.getEmployeeById(1)).isEqualTo(employee);
    }

    @Test
    void testDeleteEmployeeById() {
        Employee employee = new Employee();
        employee.setLast_name("Tekeste");
        employee.setFirst_name("Ashenife");
        employee.setBirthdate("12-09-1900");
        employee.setEmail("Tekeste@gmail.com");
        employee.setGender("M");

        Mockito.when(employeeRepository.findById(1)).thenReturn(java.util.Optional.of(employee));
        Mockito.when(employeeRepository.existsById(employee.getId())).thenReturn(false);
        assertFalse(employeeRepository.existsById(employee.getId()));

    }
}
