package wondi.example.ToDoList.Service;

import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.mockito.Mockito;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.mock.mockito.MockBean;
import org.springframework.test.context.junit4.SpringRunner;
import wondi.example.ToDoList.Model.Department;
import wondi.example.ToDoList.Repository.DepartmentRepository;

import java.util.ArrayList;
import java.util.List;


import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.Assert.assertFalse;

@RunWith(SpringRunner.class)
@SpringBootTest
class DepartmentServiceTest {

    @Autowired
    private DepartmentService departmentService;

    @MockBean
    private DepartmentRepository departmentRepository;


    @Test
    void testListAllDepartment() {

        Department department1 = new Department();
        department1.setName("ICT");
        department1.setLocation("Eindhoven");

        Department department2 = new Department();
        department2.setName("Management");
        department2.setLocation("Amsterdam");

        List<Department>  departmentList = new ArrayList<>();
        departmentList.add(department1);
        departmentList.add(department2);

        Mockito.when(departmentRepository.findAll()).thenReturn(departmentList);
        assertThat(departmentService.listAllDepartment()).isEqualTo(departmentList);

    }

    @Test
    void testUpdateDepartmentById() {
        Department department = new Department();
        department.setId(1);
        department.setName("ICT");
        department.setLocation("Amsterdam");

        Mockito.when(departmentRepository.findById(1)).thenReturn(java.util.Optional.of(department));
        assertThat(departmentService.updateDepartmentById(1)).isEqualTo(department);
    }

    @Test
    void testDeleteDepartmentById() {

        Department department = new Department();
        department.setId(1);
        department.setName("Logistics");
        department.setLocation("Rotterdam");

        Mockito.when(departmentRepository.findById(1)).thenReturn(java.util.Optional.of(department));
        Mockito.when(departmentRepository.existsById(department.getId())).thenReturn(false);
        assertFalse(departmentRepository.existsById(department.getId()));
    }

    @Test
    void testSaveDepartment() {
        Department department = new Department();
        department.setId(1);
        department.setName("Finance");
        department.setLocation("Utrecht");

        Mockito.when(departmentRepository.save(department)).thenReturn(department);
        assertThat(departmentService.saveDepartment(department)).isEqualTo(department);
    }
}
