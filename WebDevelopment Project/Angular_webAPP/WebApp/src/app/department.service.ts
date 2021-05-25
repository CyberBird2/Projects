
import { DEPARTMENT } from './mock-departments';
import { Department } from './department';
import { Injectable } from '@angular/core';
import {Observable, of} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
  constructor() { }
  getDepartments(): Observable<Department[]> {
   
    return of(DEPARTMENT);
  }
  generateId(departments: Department[]): number {
    return departments.length > 0 ? Math.max(...departments.map(department => department.id)) + 1 : 11;
  }
  }