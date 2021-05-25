import { Component, OnInit, Optional, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Task } from '../task';



@Component({
  selector: 'app-task-dialog-box',
  templateUrl: './task-dialog-box.component.html',
  styleUrls: ['./task-dialog-box.component.css']
})
export class TaskDialogBoxComponent implements OnInit {

  action:string;
  local_data:any;
 
  constructor(
    public dialogRef: MatDialogRef<TaskDialogBoxComponent>,
    //@Optional() is used to prevent error if no data is passed
    @Optional() @Inject(MAT_DIALOG_DATA) public data: Task) {
    console.log(data);
    this.local_data = {...data};
    this.action = this.local_data.action;
  }
  ngOnInit(): void {
    throw new Error("Method not implemented.");
  }
 
  doAction(){
    this.dialogRef.close({event:this.action,data:this.local_data});
  }
 
  closeDialog(){
    this.dialogRef.close({event:'Cancel'});
  }
}
