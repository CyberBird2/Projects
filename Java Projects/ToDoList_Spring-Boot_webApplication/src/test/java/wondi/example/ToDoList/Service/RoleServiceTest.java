package wondi.example.ToDoList.Service;

import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.mockito.Mockito;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.mock.mockito.MockBean;
import org.springframework.test.context.junit4.SpringRunner;
import wondi.example.ToDoList.Model.Role;
import wondi.example.ToDoList.Repository.RoleRepository;
import static org.assertj.core.api.Assertions.assertThat;
import java.util.ArrayList;
import java.util.List;
import static org.junit.Assert.assertFalse;


@RunWith(SpringRunner.class)
@SpringBootTest
class RoleServiceTest {

    @Autowired
    private RoleService roleService;

    @MockBean
    private RoleRepository roleRepository;

    @Test
    void listAllRoles() {

        Role role1 = new Role();
        role1.setName("Accountant");

        Role role2 = new Role();
        role2.setName("Manager");

        List<Role> roleList = new ArrayList<>();
        roleList.add(role1);
        roleList.add(role2);
        Mockito.when(roleRepository.findAll()).thenReturn(roleList);

        assertThat(roleService.listAllRoles()).isEqualTo(roleList);
    }

    @Test
    void testSaveRole() {

        Role role = new Role();
        role.setName("Accountant");

        Mockito.when(roleRepository.save(role)).thenReturn(role);
        assertThat(roleService.saveRole(role)).isEqualTo(role);
    }

    @Test
    void testUpdateRoleById() {

        Role role = new Role();
        role.setName("Manager");

        Mockito.when(roleRepository.findById(1)).thenReturn(java.util.Optional.of(role));
        assertThat(roleService.UpdateRoleByID(1)).isEqualTo(role);
    }

    @Test
    void testDeleteRoleByID() {

        Role role = new Role();
        role.setName("Driver");

        Mockito.when(roleRepository.findById(1)).thenReturn(java.util.Optional.of(role));
        Mockito.when(roleRepository.existsById(role.getId())).thenReturn(false);
        assertFalse(roleRepository.existsById(role.getId()));
    }
}
