package wondi.example.ToDoList.Repository;

import org.springframework.data.jpa.repository.JpaRepository;
import wondi.example.ToDoList.Model.UserDao;

public interface UserRepository extends JpaRepository<UserDao, Integer> {
    UserDao findByUsername(String username);
}
