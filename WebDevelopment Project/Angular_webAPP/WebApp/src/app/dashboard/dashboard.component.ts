import { MatGridListModule } from '@angular/material/grid-list';
import { Department } from './../department';
import { TaskService } from './../task.service';
import { Task } from './../task';
import { Component, OnInit, NgModule } from '@angular/core';
import { Employee } from '../employee';
import { DepartmentService } from '../department.service';
import { EmployeeService } from '../employee.service';



@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss'],
})
export class DashboardComponent implements OnInit {
  department : Department[];
  selectedDepartment:Department;  
  employees:Employee[];
  selectedEmployee: Employee;
  Tasks: Task[];
  selectedTask: Task;
  displayedColumnsDep : string[] =  ['Name','Building'];
  displayedColumnsEmp : string[] = ['FirstName', 'LastName'];
  displayedColumnsTask : string[] = ['ToDo', 'Deadline'];

  constructor(private departmentService: DepartmentService, private employeeService:EmployeeService, private TaskService:TaskService) { }

  ngOnInit(): void {
    this.getDepartments();
    this.getEmployees();
    this.getTasks();
  }
  getTasks():void{
    this.TaskService.getTasks().subscribe(Tasks => this.Tasks = Tasks );
  }
  getDepartments(): void{
    this.departmentService.getDepartments()
        .subscribe(departments => this.department = departments);
  }
  getEmployees():void{
    this.employeeService.getEmployees().subscribe(employees => this.employees =employees);
  }

  onSelectDep(department: Department) : void {
    this.selectedDepartment = department;
  }

  onSelectTask(task: Task) : void {
    this.selectedTask = task;
  }
  onSelectEmp(employee: Employee): void {
    this.selectedEmployee = employee;
  }

  getDepEmp(selectedDepartment : Department) : string{
    let emptemp = "";
    for (let index = 0; index < selectedDepartment.DepartmentEmployees.length; index++) { 
      if(index != selectedDepartment.DepartmentEmployees.length - 1)  {
        emptemp += this.employees[index].first_name + ", ";
      } 
      else{
        emptemp += this.employees[index].first_name;
      }        
    }    
    return emptemp;
  }

  getEmp(selectedTask : Task) : string{
    let emptemp = "";
    for (let index = 0; index < selectedTask.TaskEmployeesIDs.length; index++) { 
      if(index != selectedTask.TaskEmployeesIDs.length - 1)  {
        emptemp += this.employees[index].first_name + ", ";
      } 
      else{
        emptemp += this.employees[index].first_name;
      }        
    }    
    return emptemp;
  }

  
}
