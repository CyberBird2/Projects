import { Department } from './../department';
import { Component, OnInit, Optional, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-department-dialog-box',
  templateUrl: './department-dialog-box.component.html',
  styleUrls: ['./department-dialog-box.component.css']
})
export class DepartmentDialogBoxComponent implements OnInit {

  action:string;
  local_data:any;
  constructor(
    public dialogRef: MatDialogRef<DepartmentDialogBoxComponent>,
    //@Optional() is used to prevent error if no data is passed
    @Optional() @Inject(MAT_DIALOG_DATA) public data: Department) {
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
