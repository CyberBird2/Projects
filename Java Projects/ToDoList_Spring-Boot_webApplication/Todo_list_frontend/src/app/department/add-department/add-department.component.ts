import { Component, OnInit } from '@angular/core';
import {DepartmentService} from '../../Module/Department-module/department.service';

@Component({
  selector: 'app-add-department',
  templateUrl: './add-department.component.html',
  styleUrls: ['./add-department.component.css']
})
export class AddDepartmentComponent implements OnInit {

  department = {
    name: '',
    location: ''
  };
  constructor(private departmentService: DepartmentService) { }
    submitted = false;
  ngOnInit(): void {
  }
  // save department
  saveDepartment(): void {
    const data = {
      name: this.department.name,
      location: this.department.location
    };

    this.departmentService.create(data)
      .subscribe(
        response => {
          console.log(response);
          this.submitted = true;
        },
        error => {
          console.log(error);
        });
  }
// new department
  newDepartment(): void {
    this.submitted = false;
    this.department = {
      name: '',
      location: ''
    };
  }
  }
