import { DEPARTMENT } from './../mock-departments';
import { DepartmentDialogBoxComponent } from './../department-dialog-box/department-dialog-box.component';
import { Employees } from './../Mock-employees';
import { Department } from './../department';
import { Component, OnInit, ViewChild } from '@angular/core';
import { DepartmentService } from '../department.service';
import { MatTable, MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';


@Component({
  selector: 'app-departments',
  templateUrl: './departments.component.html',
  styleUrls: ['./departments.component.css']
})
export class DepartmentsComponent implements OnInit {

  @ViewChild(MatTable,{static:true}) table: MatTable<any>;
  departments = DEPARTMENT;
  dataSource = new MatTableDataSource<Department>(this.departments);
   
  displayedColumns : string[] = ['ID','Name','Building','Employees','action']


  constructor(private departmentService: DepartmentService,public dialog: MatDialog){ }

  ngOnInit(): void {
    this.getDepartments();
  }
  applyFilter(filterValue: string){
    this.dataSource.filter = filterValue.trim().toLowerCase();    
  }
  
 
  getDepartments(): void{
    this.departmentService.getDepartments()
        .subscribe(departments => this.departments = departments);
  }
  addDepartment(name: string, building: string, empListID: string): void {
    name = name.trim();
    
    if (!name) { return; }
    let newDepartment: Department = new Department(this.departmentService. generateId(this.departments), name, building, empListID.split(',').map(Number));
    this.departments.push(newDepartment);
  }
  delete(department: Department): void{
    this.departments.splice(this.departments.indexOf(department),1);
  }

  getDepEmp(selectedDepartment : Department) : string{
    let emptemp = "";
    for (let index = 0; index < selectedDepartment.DepartmentEmployees.length; index++) { 
      if(index ==  selectedDepartment.DepartmentEmployees.length-1){
        emptemp += Employees[selectedDepartment.DepartmentEmployees[index]].first_name; 
      }
      else{
        emptemp += Employees[selectedDepartment.DepartmentEmployees[index]].first_name + ", ";  
      }
              
    }    
    return emptemp;
  }
  openDialog(action,obj) {
    obj.action = action;
    const dialogRef = this.dialog.open(DepartmentDialogBoxComponent, {
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
    let newDepartment: Department = new Department(this.departmentService.generateId(this.departments), row_obj.name,
     row_obj.building,row_obj.empListID.split(',').map(Number));
    this.departments.push(newDepartment); 
    this.table.renderRows();
    
  }
  updateRowData(row_obj){
    this.departments = this.departments.filter((value,key)=>{
      if(value.id == row_obj.id){
        value.name = row_obj.name;
        value.building = row_obj.building;
        value.DepartmentEmployees= row_obj.empListID.split(',').map(Number);
        console.log(row_obj.empListID.split(',').map(Number));
        
      }
      return true;
    });
  }
  deleteRowData(row_obj){
    for (var i=0; i<this.departments.length;i++) {
      if (this.departments[i].id == row_obj.id) {
        this.departments.splice(i,1); // removes the matched element        
      }
    }
    this.table.renderRows();
  }
  


}
