package wondi.example.ToDoList.Model;

import javax.persistence.*;
import java.util.HashSet;
import java.util.Set;


 @Entity
public class Employee {
     @Id
     @GeneratedValue(strategy = GenerationType.AUTO)
     private  int id;

     private String first_name;
     private String last_name;
     private String  gender;
     private String  birthdate;
     private String  email;

     public Employee() {
     }

     public Employee(int id, String first_name, String last_name, String gender, String birthdate, String email) {
         this.id = id;
         this.first_name = first_name;
         this.last_name = last_name;
         this.gender = gender;
         this.birthdate = birthdate;
         this.email = email;

     }

     // many to one relationship with department

     @ManyToOne(fetch = FetchType.LAZY)
     @JoinColumn(name= "departmentId")
     private Department department;

     // many to one relationship with role

     @ManyToOne(fetch = FetchType.LAZY)
     @JoinColumn(name = "roleId")
     private Role role;

     // one to many relationship with task
     @OneToMany(mappedBy = "employee", cascade = CascadeType.ALL)
     private Set<Task> tasks = new HashSet<>();



     public int getId() {
         return id;
     }

     public void setId(int id) {
         this.id = id;
     }

     public String getFirst_name() {
         return first_name;
     }

     public void setFirst_name(String firstName) {
         this.first_name = firstName;
     }

     public String getLast_name() {
         return last_name;
     }

     public void setLast_name(String lastName) {
         this.last_name = lastName;
     }

     public String getGender() {
         return gender;
     }

     public void setGender(String gender) {
         this.gender = gender;
     }

     public String getBirthdate() {
         return birthdate;
     }

     public void setBirthdate(String birthdate) {
         this.birthdate = birthdate;
     }

     public String getEmail() {
         return email;
     }

     public void setEmail(String email) {
         this.email = email;
     }


     public Role getRole() {
         return role;
     }

     public void setRole(Role role) {
         this.role = role;
     }

     public Department getDepartment() {
         return department;
     }

     public void setDepartment(Department department) {
         this.department = department;
     }

     public Set<Task> getTasks() {
         return tasks;
     }

     public void setTasks(Set<Task> tasks) {
         this.tasks = tasks;
         for (Task t : tasks) {
             t.setEmployee(this);
         }
     }

     // to print a class content
     @Override
     public  String toString(){
         return "Employee {" +
                 "first_name=" + first_name +
                 ", last_name'"+ last_name +
                 ", gender='" + gender +
                 ", email= '" + email +
                 ", birthdate= '" + birthdate +
                 '}';
     }

 }
