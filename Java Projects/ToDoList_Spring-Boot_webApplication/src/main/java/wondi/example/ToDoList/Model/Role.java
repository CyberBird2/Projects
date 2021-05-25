
package wondi.example.ToDoList.Model;
import javax.persistence.*;
import java.util.HashSet;
import java.util.Set;


@Entity
public class Role {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private   int id;
    private  String name;


    public Role(String name) {
        this.name = name;
    }
    public Role(int i, String name) {

    }
    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "departmentId")
    private  Department department;

    @OneToMany(mappedBy = "role", cascade = CascadeType.ALL)
    private Set<Employee> employees = new HashSet<>();

    public Role() {

    }


    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Set<Employee> getEmployees() {
        return employees;
    }

    public void setEmployees(Set<Employee> employees) {
        this.employees = employees;

        for(Employee e : employees){
            e.setRole(this);
        }
    }

    public Department getDepartment() {
        return department;
    }

    public void setDepartment(Department department) {
        this.department = department;
    }


    @Override
    public  String toString(){
        return "Role {" +
                "name=" + name +
                '}';
    }
}
