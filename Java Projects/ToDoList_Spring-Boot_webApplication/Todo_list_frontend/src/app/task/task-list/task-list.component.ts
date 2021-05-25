import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {TaskService} from '../../Module/Task_module/task.service';
import { Task } from 'src/app/Module/Task_module/task';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html',
  styleUrls: ['./task-list.component.css']
})
export class TaskListComponent implements OnInit {
  get searchTerm(): string {
    return this.searchText;
  }
  set searchTerm(value) {
    this.searchText = value;
    this.filterTask = this.filteredTask(value);
  }
  tasks: any;
  currentTask = null;
  searchText: string;
  selectedTask: Task;
  filterTask: Task[];
  name = '';
  message = '';
  constructor(private taskService: TaskService,  private route: ActivatedRoute,
              private router: Router) { }

  ngOnInit(): void {
    this.retrieveTasks();
    this.message = '';
    this.getTask(this.route.snapshot.paramMap.get('id'));
  }

  filteredTask(searchString: string) {
    return  this.tasks.filter(task =>
      task.name.toLowerCase().indexOf(searchString.toLowerCase()) !== -1);
  }

  retrieveTasks(): void {
    this.taskService.getAll()
      .subscribe(
        data => {
          this.tasks = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }
  getTask(id): void {
    this.taskService.get(id)
      .subscribe(
        data => {
          this.currentTask = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }

  updateTask(): void {
    this.taskService.update(this.currentTask.id, this.currentTask)
      .subscribe(() => this.retrieveTasks());
    this.message = 'The task was updated successfully';
  }
  deleteTask(): void {
    this.taskService.delete(this.currentTask.id)
      .subscribe(() => this.retrieveTasks());
    this.message = 'The task was deleted successfully';
  }

}
