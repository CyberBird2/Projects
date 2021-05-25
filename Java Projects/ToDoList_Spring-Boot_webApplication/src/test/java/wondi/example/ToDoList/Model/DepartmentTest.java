package wondi.example.ToDoList.Model;

import org.junit.Assert;
import org.junit.jupiter.api.Test;

import java.util.Set;

class DepartmentTest {

    @Test
    void  testGetName() {

        Department department = new Department();
        department.setName("testing");
        Assert.assertEquals("testing", department.getName());

    }

    @Test
    void testGetLocation() {

        Department department = new Department();
        department.setLocation("Eindhoven");
        Assert.assertEquals("Eindhoven", department.getLocation());

    }


}
