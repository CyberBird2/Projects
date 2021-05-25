import { Employees } from './../Mock-employees';
import { EmployeeDialogBoxComponent } from './../employee-dialog-box/employee-dialog-box.component';
import { DEPARTMENT } from './../mock-departments';
import { EmployeeService } from './../employee.service';

import { Component, OnInit, ViewChild } from '@angular/core';
import { Employee } from '../employee';
import { MatTable, MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';


@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {
  @ViewChild(MatTable,{static:true}) table: MatTable<any>;
  employees = Employees;
  dataSource = new MatTableDataSource<Employee>(this.employees);
  displayedColumns : string[] = ['ID','FirstName', 'LastName', 'Gender', 'dob','Department','action'];

  
  constructor(private employeeService:EmployeeService, public dialog: MatDialog) { }

  
  ngOnInit(): void {
    this.getEmployees();
  }

  
getEmployees():void{
  this.employeeService.getEmployees().subscribe(employees => this.employees =employees);
}

applyFilter(filterValue: string){
  this.dataSource.filter = filterValue.trim().toLowerCase();    
}

addEmployee(gender:string, firstName:string, lastName:string, dob:Date ): void{
  if(!gender && !firstName && !lastName && !dob){return;}
  let newEmployee: Employee = new Employee(this.employeeService.generateId(this.employees), gender, firstName, lastName, dob,DEPARTMENT[1]);
  this.employees.push(newEmployee);
  this.getEmployees();
  
}

deleteEmployee(Employee: Employee): void{
  this.employees.splice(this.employees.indexOf(Employee),1);
  this.getEmployees();
}
openDialog(action,obj) {
  obj.action = action;
  const dialogRef = this.dialog.open(EmployeeDialogBoxComponent, {
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

addRowData(row_obj){
  var d = new Date();
  let newEmployee: Employee = new Employee(this.employeeService.generateId(this.employees), row_obj.gender, row_obj.first_name,row_obj.last_name,row_obj.dob,DEPARTMENT[row_obj.DepartmentNr]);
  this.employees.push(newEmployee); 
  this.table.renderRows();
  
}
updateRowData(row_obj){
  this.employees = this.employees.filter((value,key)=>{
    if(value.id == row_obj.id){
      value.first_name = row_obj.first_name;
      value.last_name = row_obj.last_name;
      value.gender = row_obj.gender;
      value.dob = row_obj.dob;
      value.EmployeeDepartment = DEPARTMENT[row_obj.DepartmentNr];
    }
    return true;
  });
}
deleteRowData(row_obj){
  for (var i=0; i<this.employees.length;i++) {
    if (this.employees[i].id == row_obj.id) {
      this.employees.splice(i,1); // removes the matched element        
    }
  }
  this.table.renderRows();
}

}
