import { Employees } from './../Mock-employees';
import { Component, OnInit, Optional, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Employee } from '../employee';


@Component({
  selector: 'app-employee-dialog-box',
  templateUrl: './employee-dialog-box.component.html',
  styleUrls: ['./employee-dialog-box.component.css']
})
export class EmployeeDialogBoxComponent implements OnInit {

  action:string;
  local_data:any;
  constructor(
    public dialogRef: MatDialogRef<EmployeeDialogBoxComponent>,
    //@Optional() is used to prevent error if no data is passed
    @Optional() @Inject(MAT_DIALOG_DATA) public data: Employee) {
    console.log(data);
    this.local_data = {...data};
    this.action = this.local_data.action;
  }
  ngOnInit(): void {
  }
  doAction(){
    this.dialogRef.close({event:this.action,data:this.local_data});
  }
 
  closeDialog(){
    this.dialogRef.close({event:'Cancel'});
  }

}
