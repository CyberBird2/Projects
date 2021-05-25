import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Router, ParamMap, convertToParamMap} from '@angular/router';
import {Employee} from '../../Module/Employee-module/employee';
import {EmployeeService} from '../../Module/Employee-module/employee.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  get searchTerm(): string {
    return this.searchText;
  }
  set searchTerm(value) {
    this.searchText = value;
    this.filterEmployee = this.filteredEmployee(value);
  }
  employees: any;
  currentEmployee = null;
  searchText: string;
  selectedEmployee: Employee;
  filterEmployee: Employee[];
  name = '';
  message = '';

  constructor(private employeeService: EmployeeService, private route: ActivatedRoute,
              private router: Router) {}

  ngOnInit(): void {
    this.retrieveEmployees();
    this.getEmployee(this.route.snapshot.paramMap.get('id'));
    this.message = '';
  }
// filter employee by name
  filteredEmployee(searchString: string) {
    return  this.employees.filter(task =>
      task.name.toLowerCase().indexOf(searchString.toLowerCase()) !== -1);
  }

  // Get all employees
  retrieveEmployees(): void {
    this.employeeService.getAll()
      .subscribe(
        data => {
          this.employees = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }
  // Get employee by Id
  getEmployee(id): void {
    this.employeeService.get(id)
      .subscribe(
        data => {
          this.currentEmployee = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }

// update employee by id
  updateEmployee(): void {
    this.employeeService.update(this.currentEmployee.id, this.currentEmployee)
      .subscribe(() => this.retrieveEmployees());
    this.message = 'The department was updated successfully';
  }

  // delete employee by ID
  deleteEmployee(): void {
    this.employeeService.delete(this.currentEmployee.id)
      .subscribe( () => this.retrieveEmployees());
    this.message = 'The department was deleted successfully';
  }
}
