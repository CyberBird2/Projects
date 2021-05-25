package wondi.example.ToDoList.APILayer;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import wondi.example.ToDoList.Model.Task;
import wondi.example.ToDoList.Service.EmployeeService;
import wondi.example.ToDoList.Service.TaskService;

import java.util.List;
import java.util.NoSuchElementException;


@RestController
@CrossOrigin(origins = "http://localhost:4200")
public class TaskController {

    TaskService taskService;
    EmployeeService employeeService;

    @Autowired
    public TaskController(TaskService taskService, EmployeeService employeeService) {
        this.taskService = taskService;
        this.employeeService = employeeService;
    }

    // GET = get all tasks
    @GetMapping("/tasks")
    public List<Task> list() {
        return taskService.listAllTask();
    }

    // GET = get all tasks by id
    @GetMapping("/tasks/{id}")
    public ResponseEntity<Task> get(@PathVariable Integer id) {
        try {
            Task task = taskService.updateTaskById(id);
            return new ResponseEntity<>(task, HttpStatus.OK);


        } catch (NoSuchElementException e) {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }
    // POSt = add tasks
    @PostMapping("/tasks")
    public void add(@RequestBody Task task) {
        taskService.saveTask(task);
    }
    // PUT = update tasks
    @PutMapping("/tasks/{id}")
    public ResponseEntity<Task> update(@RequestBody Task task, @PathVariable Integer id) {
        try {
             taskService.updateTaskById(id);
            task.setId(id);
            taskService.saveTask(task);

            return new ResponseEntity<>(HttpStatus.OK);
        } catch (NoSuchElementException e) {
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }
    @DeleteMapping("/tasks/{id}")
    public void delete(@PathVariable Integer id) {
        taskService.deleteTaskById(id);
    }

}
