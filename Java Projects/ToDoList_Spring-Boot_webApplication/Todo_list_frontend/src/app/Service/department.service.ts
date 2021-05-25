import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  private departmentUrl: string;
  constructor(private http: HttpClient) {
    this.departmentUrl = 'http://localhost:8081/departments';
  }
  // Get all department
  public getAll(): Observable<any> {
    return this.http.get(this.departmentUrl);
  }
  // Get department by id
  public getByID(id): Observable<any> {
    return this.http.get(`${this.departmentUrl}/${id}`);
  }
  // Create department
  public create(data): Observable<any> {
    return this.http.post(this.departmentUrl, data);
  }
  // update department by id
  public update(id, data): Observable<any> {
    return this.http.put(`${this.departmentUrl}/${id}`, data);
  }
  // delete department by id
  public delete(id): Observable<any> {
    return this.http.delete(`${this.departmentUrl}/${id}`);
  }
}
