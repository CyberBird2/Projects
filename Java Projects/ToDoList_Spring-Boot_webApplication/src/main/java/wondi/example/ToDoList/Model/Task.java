package wondi.example.ToDoList.Model;

import javax.persistence.*;


@Entity
public class Task {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private  int id;

    private  String  name;
    private  String  description;
    private  String  deadline;

    public Task(String name, String description, String deadline) {
        this.name = name;
        this.description = description;
        this.deadline = deadline;
    }

    public Task() {
    }

   @ManyToOne(fetch = FetchType.LAZY)
   @JoinColumn(name = "employeeId")
    private Employee employee;


    public Employee getEmployee() {
        return employee;
    }

    public void setEmployee(Employee employee) {
        this.employee = employee;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getDeadline() {
        return deadline;
    }

    public void setDeadline(String deadline) {
        this.deadline = deadline;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
    @Override
    public  String toString(){
        return "Task {" +
                "name=" +  name +
                ", description'"+ description +
                ", deadline'"+ deadline +

                '}';
    }

}
