package wondi.example.ToDoList.Model;

import org.junit.Assert;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class RoleTest {

    @Test
    void TestSetDepartment() {
        Department department = new Department();
        Role role = new Role(1, "Manager");
        role.setDepartment(department);

        Assert.assertEquals(department, role.getDepartment());
    }

    @Test
    void testGetName() {
        Role role = new Role();
        role.setName("Accountant");
        Assert.assertEquals("Accountant", role.getName());
    }
}
