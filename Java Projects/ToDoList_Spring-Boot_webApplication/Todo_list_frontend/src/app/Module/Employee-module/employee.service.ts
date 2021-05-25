import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  private employeeUrl: string;
  constructor(private http: HttpClient) {
    this.employeeUrl = 'http://localhost:8081/employees';
  }

  // Get all employee
  public getAll(): Observable<any> {
    return this.http.get(this.employeeUrl);
  }
  // Get employee by id
  public get(id): Observable<any> {
    return this.http.get(`${this.employeeUrl}/${id}`);
  }
  // Create employee
  public create(data): Observable<any> {
    return this.http.post(this.employeeUrl, data);
  }
  // update employee
  public update(id, data): Observable<any> {
    return this.http.put(`${this.employeeUrl}/${id}`, data);
  }
  // delete employee by id
  public delete(id): Observable<any> {
    return this.http.delete(`${this.employeeUrl}/${id}`);
  }

}
