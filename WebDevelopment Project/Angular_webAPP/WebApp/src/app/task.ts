 import { Department } from './department';


export class Task {
    task_id: number;
    title: string;
    deadline: Date;  
    TaskDepartment: Department;
    TaskEmployeesIDs: number[];
    
    
    constructor( task_id: number, title: string, TaskDepartment: Department, TaskEmployeesIDs: number[], deadline: Date ){
        this.task_id = task_id;
        this.title = title;
        this.deadline = deadline;
        this.TaskDepartment = TaskDepartment;
        this.TaskEmployeesIDs = TaskEmployeesIDs;
    }   

      

}
