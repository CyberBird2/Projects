package wondi.example.ToDoList.Model;

import org.junit.Assert;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class EmployeeTest {



    @Test
    void testGetFirst_name() {
        Employee employee = new Employee();
        employee.setFirst_name("Alex");
        Assert.assertEquals("Alex", employee.getFirst_name());
    }


    @Test
    void testLast_name() {
        Employee employee = new Employee();
        employee.setLast_name("check");
        Assert.assertEquals("check", employee.getLast_name());

    }

    @Test
    void testGetGender() {
        Employee employee = new Employee();
        employee.setGender("M");
        Assert.assertEquals("M", employee.getGender());
    }

    @Test
    void testGetBirthdate() {
        Employee employee = new Employee();
        employee.setBirthdate("12-05-1990");
        Assert.assertEquals("12-05-1990", employee.getBirthdate());
    }

    @Test
    void getEmail() {
        Employee employee = new Employee();
        employee.setEmail("alex@gmail.com");
        Assert.assertEquals("alex@gmail.com", employee.getEmail());
    }
}
