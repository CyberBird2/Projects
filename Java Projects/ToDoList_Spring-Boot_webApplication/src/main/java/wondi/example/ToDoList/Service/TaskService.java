package wondi.example.ToDoList.Service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import wondi.example.ToDoList.Model.Task;
import wondi.example.ToDoList.Repository.TaskRepository;

import java.util.List;


@Service
public class TaskService {

    @Autowired

    private TaskRepository taskRepository;

      // get all tasks
    public  List<Task> listAllTask()
    {
        return taskRepository.findAll();
    }

     // add task
    public Task saveTask(Task task) {
       return taskRepository.save(task);
    }
      // update task by id
    public Task updateTaskById(Integer id) {
        return taskRepository.findById(id).orElse(null);
    }

      //  delete task by Id
    public void deleteTaskById(Integer id) {
        taskRepository.deleteById(id);
    }


}
