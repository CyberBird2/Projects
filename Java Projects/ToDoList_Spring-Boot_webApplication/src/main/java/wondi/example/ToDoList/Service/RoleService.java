package wondi.example.ToDoList.Service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import wondi.example.ToDoList.Model.Role;
import wondi.example.ToDoList.Repository.RoleRepository;

import javax.transaction.Transactional;
import java.util.List;
import java.util.Optional;

@Service
public class RoleService {
    @Autowired
    private RoleRepository roleRepository;

     // get all roles
    public List<Role> listAllRoles() {
        return roleRepository.findAll();
    }
     // add role
    public Role saveRole(Role role) {
       return roleRepository.save(role);
    }

    // update role by id
    public Role UpdateRoleByID(Integer id) {
        return roleRepository.findById(id).orElse(null);
    }

     // delete role by id
    public void deleteRoleByID(Integer id) {
        roleRepository.deleteById(id);
    }
}
