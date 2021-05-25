import { TASKS } from './mock-tasks';
import { Task } from './task';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor() { }

  getTasks(): Observable<Task[]>{
    return of(TASKS);
  }

  generateId(tasks: Task[]): number{
    return tasks.length > 0 ? 
    Math.max(...tasks.map(Task => Task.task_id)) + 1 : 11;
  }

  

}
