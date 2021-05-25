import { Component, OnInit } from '@angular/core';
import {TaskService} from '../../Module/Task_module/task.service';

@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.css']
})
export class AddTaskComponent implements OnInit {
task = {
  name: '',
  description: '',
  deadline: ''
};
 submitted = false;
  constructor(private taskService: TaskService) { }

  ngOnInit(): void {
  }
// save task
  saveTask(): void {
    const data = {
      name: this.task.name,
      description: this.task.description,
      deadline: this.task.deadline
    };

    this.taskService.create(data)
      .subscribe(
        response => {
          console.log(response);
          this.submitted = true;
        },
        error => {
          console.log(error);
        });
  }

// new task
  newTask(): void {
    this.submitted = false;
    this.task = {
      name: '',
      description: '',
      deadline: ''
    };
  }

}
