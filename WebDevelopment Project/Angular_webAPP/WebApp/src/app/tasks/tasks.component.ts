import { DEPARTMENT} from './../mock-departments';
import { Employees } from './../Mock-employees';
import { TaskService } from './../task.service';
import { TASKS } from './../mock-tasks';
import { Component, OnInit, ViewChild } from '@angular/core';
import { Task } from '../task';
import { MatTableDataSource, MatTable } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import { TaskDialogBoxComponent } from '../task-dialog-box/task-dialog-box.component';


@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss']
})
export class TasksComponent implements OnInit {
  @ViewChild(MatTable,{static:true}) table: MatTable<any>;
  
  Tasks = TASKS;
  dataSource = new MatTableDataSource<Task>(this.Tasks);
  

  displayedColumns : string[] = ['ID','ToDo', 'Deadline', 'Department', 'Employees', 'action']

  constructor(private TaskService:TaskService, public dialog: MatDialog) { }

  ngOnInit(): void {
  }
  
 getTasks():void{
   this.TaskService.getTasks().subscribe(Tasks => this.Tasks = Tasks );
 }
    

  getEmp(selectedTask : Task) : string{
    let emptemp = "";
    for (let index = 0; index < selectedTask.TaskEmployeesIDs.length; index++) { 
      if(index ==  selectedTask.TaskEmployeesIDs.length-1){
        emptemp += Employees[selectedTask.TaskEmployeesIDs[index]].first_name; 
      }
      else{
        emptemp += Employees[selectedTask.TaskEmployeesIDs[index]].first_name + ", ";  
      }
      
        
    }    
    return emptemp;
  }

  openDialog(action,obj) {
    obj.action = action;
    const dialogRef = this.dialog.open(TaskDialogBoxComponent, {
      width: '250px',
      data:obj
    });
    dialogRef.afterClosed().subscribe(result => {
      if(result.event == 'Add'){
        this.addRowData(result.data);
      }else if(result.event == 'Update'){
        this.updateRowData(result.data);
      }else if(result.event == 'Delete'){
        this.deleteRowData(result.data);
      }
    });
  }

  applyFilter(filterValue: string){
    this.dataSource.filter = filterValue.trim().toLowerCase();    
  }

  addRowData(row_obj){
    var d = new Date();
    let newTask: Task = new Task(this.TaskService.generateId(this.Tasks), row_obj.title,  DEPARTMENT[row_obj.DepartmentNr], row_obj.EmpNR.split(',').map(Number), row_obj.Deadline);
    this.Tasks.push(newTask); 
    this.table.renderRows();
    
  }
  updateRowData(row_obj){
    this.Tasks = this.Tasks.filter((value,key)=>{
      if(value.task_id == row_obj.task_id){
        value.title = row_obj.title;        
      }
      return true;
    });
  }
  
  deleteRowData(row_obj){
    for (var i=0; i<this.Tasks.length;i++) {
      if (this.Tasks[i].task_id == row_obj.task_id) {
        this.Tasks.splice(i,1); // removes the matched element        
      }
    }
    this.table.renderRows();
  }
 
 
}
  


