import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TaskService {
  private taskUrl: string;
  constructor(private http: HttpClient) {
    this.taskUrl = 'http://localhost:8081/tasks';
  }
  // Get all tasks
  public getAll(): Observable<any> {
    return this.http.get(this.taskUrl);
  }
  // Get task by id
  public get(id): Observable<any> {
    return this.http.get(`${this.taskUrl}/${id}`);
  }
  // Create task
  public create(data): Observable<any> {
    return this.http.post(this.taskUrl, data);
  }
  // update task
  public update(id, data): Observable<any> {
    return this.http.put(`${this.taskUrl}/${id}`, data);
  }
  // delete task by id
  public delete(id): Observable<any> {
    return this.http.delete(`${this.taskUrl}/${id}`);
  }
}
