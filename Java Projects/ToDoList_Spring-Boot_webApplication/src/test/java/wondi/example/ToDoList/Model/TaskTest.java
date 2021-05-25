package wondi.example.ToDoList.Model;

import org.junit.Assert;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class TaskTest {

    @Test
    void testGetDeadline() {
        Task task = new Task();
        task.setDeadline("test");
        Assert.assertEquals("test", task.getDeadline());

    }


    @Test
    void testGetDescription() {
        Task task = new Task();
        task.setDescription("Assign employee");
        Assert.assertEquals("Assign employee", task.getDescription());
    }


    @Test
    void testGetName() {
        Task task = new Task();
        task.setName("Web development");
        Assert.assertEquals("Web development", task.getName());
    }
}
