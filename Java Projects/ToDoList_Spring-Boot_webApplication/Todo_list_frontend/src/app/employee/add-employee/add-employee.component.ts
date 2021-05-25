import { Component, OnInit } from '@angular/core';
import {EmployeeService} from '../../Module/Employee-module/employee.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {

  currentEmployee = null;
  employee = {
    first_name: '',
    last_name: '',
    gender: '',
    birthdate: '',
    email: ''
  };
  submitted = false;

  constructor( private employeeService: EmployeeService) { }

  ngOnInit(): void {
  }
  // Save employee
  saveEmployee(): void {
    const data = {
      first_name: this.employee.first_name,
      last_name: this.employee.last_name,
      gender: this.employee.gender,
      birthdate: this.employee.birthdate,
      email: this.employee.email,
    };

    this.employeeService.create(data)
      .subscribe(
        response => {
          console.log(response);
          this.submitted = true;
        },
        error => {
          console.log(error);
        });
  }

// new employee
  newEmployee(): void {
    this.submitted = false;
    this.employee = {
      first_name: '',
      last_name: '',
      gender: '',
      birthdate: '',
      email: ''
    };
  }

}
