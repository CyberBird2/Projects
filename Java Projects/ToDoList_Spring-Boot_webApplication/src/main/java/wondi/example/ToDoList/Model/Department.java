package wondi.example.ToDoList.Model;
import javax.persistence.*;

import java.util.HashSet;
import java.util.Set;


@Entity
public class Department {


    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private   int id;

    private   String name;
    private   String  location;


      // One to many relationship with role table
    @OneToMany(mappedBy = "department", fetch=FetchType.LAZY, cascade = CascadeType.ALL,targetEntity = Role.class)
    private Set<Role> roles = new HashSet<>();

    public Department() {

    }

    public Department(int i, String s, String eindhoven) {
    }

    public Set<Role> getRoles() {
        return roles;
    }

    public void setRoles(Set<Role> roles) {
        this.roles = roles;
        for (Role r: roles) {
            r.setDepartment(this);

        }
    }

    // one to many relationship with employee
    @OneToMany(mappedBy = "department", fetch=FetchType.LAZY,cascade = CascadeType.ALL, targetEntity = Employee.class )
    private Set<Employee> employees = new HashSet<>();

    public Set<Employee> getEmployees() {
        return employees;
    }
    public void setEmployees(Set<Employee> employees) {
        this.employees = employees;
        for (Employee e : employees) {
            e.setDepartment(this);
        }
    }

    // methods
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void  setName(String name) {
        this.name = name;
    }

    public String getLocation() {
        return location;
    }

    public void setLocation(String location) {
        this.location = location;
    }

    @Override
    public  String toString(){
        return "Department {" +
                "name=" + name +
                ", location'"+ location +
                '}';
    }
}
