package wondi.example.ToDoList.Repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import wondi.example.ToDoList.Model.Role;

@Repository
public interface RoleRepository extends JpaRepository <Role, Integer> {



}
