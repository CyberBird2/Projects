import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Router} from '@angular/router';
import {DepartmentService} from '../../Module/Department-module/department.service';
import {Department} from '../../Module/Department-module/department';

@Component({
  selector: 'app-department-list',
  templateUrl: './department-list.component.html',
  styleUrls: ['./department-list.component.css']
})
export class DepartmentListComponent implements OnInit {

  get searchTerm(): string {
    return this.searchText;
  }
  set searchTerm(value) {
    this.searchText = value;
    this.filterDepartment = this.filteredDepartment(value);
  }
  departments: any;
  currentDepartment = null;
  searchText: string;
  selectedDepartment: Department;
  filterDepartment: Department[];
  name = '';
  message = '';
  constructor(private departmentService: DepartmentService,  private route: ActivatedRoute,
              private router: Router) { }

  ngOnInit(): void {
    this.retrieveDepartment();
    this.message = '';
    this.getDepartment(this.route.snapshot.paramMap.get('id'));

  }

  filteredDepartment(searchString: string) {
    return  this.departments.filter(task =>
      task.name.toLowerCase().indexOf(searchString.toLowerCase()) !== -1);
  }
  getDepartment(id): void {
    this.departmentService.get(id)
      .subscribe(
        data => {
          this.currentDepartment = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }
  // get all departments
  retrieveDepartment(): void {
    this.departmentService.getAll()
      .subscribe(
        data => {
          this.departments = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }

  updateDepartment(): void {
    this.departmentService.update(this.currentDepartment.id, this.currentDepartment)
      .subscribe(
        () => this.retrieveDepartment());
    this.message = 'The department was updated successfully';
  }
  deleteDepartment(): void {
    this.departmentService.delete(this.currentDepartment.id)
      .subscribe(() => this.retrieveDepartment());
    this.message = 'The department was deleted successfully';
  }

}
