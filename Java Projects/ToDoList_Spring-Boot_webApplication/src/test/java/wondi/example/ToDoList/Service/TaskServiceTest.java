package wondi.example.ToDoList.Service;

import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.mockito.Mockito;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.mock.mockito.MockBean;
import org.springframework.test.context.junit4.SpringRunner;
import wondi.example.ToDoList.Model.Task;
import wondi.example.ToDoList.Repository.TaskRepository;

import java.util.ArrayList;
import java.util.List;

import static org.assertj.core.api.Assertions.assertThat;
import static org.junit.Assert.assertFalse;

@RunWith(SpringRunner.class)
@SpringBootTest
class TaskServiceTest {

    @Autowired
    private  TaskService taskService;

    @MockBean
    private TaskRepository taskRepository;

    @Test
    void listAllTask() {
        Task task1 = new Task();
        task1.setName("Prepare payroll");
        task1.setDeadline("12-09-2020");
        task1.setDescription("preparing payroll for monthly salary of employee");

        Task task2 = new Task();
        task2.setName("Prepare package");
        task2.setDeadline("12-09-2020");
        task2.setDescription("preparing packages for delivering to the customer");

        List<Task> taskList = new ArrayList<>();
        taskList.add(task1);
        taskList.add(task2);
        Mockito.when(taskRepository.findAll()).thenReturn(taskList);

        assertThat(taskService.listAllTask()).isEqualTo(taskList);
    }

    @Test
    void testSaveTask() {

        Task task = new Task();
        task.setName("Prepare payroll");
        task.setDeadline("12-09-2020");
        task.setDescription("preparing payroll for monthly salary of employee");


        Mockito.when(taskRepository.save(task)).thenReturn(task);
        assertThat(taskService.saveTask(task)).isEqualTo(task);
    }

    @Test
    void testGetTaskById() {

        Task task = new Task();
        task.setName("Assign employees");
        task.setDeadline("12-09-2021");
        task.setDescription("Assign tasks for each employee depend on their department");

        Mockito.when(taskRepository.findById(1)).thenReturn(java.util.Optional.of(task));
        assertThat(taskService.updateTaskById(1)).isEqualTo(task);
    }

    @Test
    void testDeleteTaskById() {

        Task task = new Task();
        task.setName("Add a unit test");
        task.setDeadline("12-09-2021");
        task.setDescription("add a unit test in the backend file");

        Mockito.when(taskRepository.findById(1)).thenReturn(java.util.Optional.of(task));
        Mockito.when(taskRepository.existsById(task.getId())).thenReturn(false);
        assertFalse(taskRepository.existsById(task.getId()));
    }

}
