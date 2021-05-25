import { Employee } from './employee';
import { Employees } from './Mock-employees';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  constructor() { }
  
  getEmployees(): Observable<Employee[]>{
    return of(Employees);
  }

  generateId(employees: Employee[]): number{
    return employees.length > 0 ? 
    Math.max(...employees.map(employees => employees.id)) + 1 : 11;
  }

}