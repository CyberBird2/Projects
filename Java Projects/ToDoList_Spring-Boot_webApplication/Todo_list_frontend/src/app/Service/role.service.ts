import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';


@Injectable({
  providedIn: 'root'
})


export class RoleService {
  private roleUrl: string;

  constructor(private http: HttpClient) {
    this.roleUrl = 'http://localhost:8081/roles'; // it a base url
  }
  // Get all role
  public getAll(): Observable<any> {
    return this.http.get(this.roleUrl);
  }
  // Get role by id
  public get(id): Observable<any> {
    return this.http.get(`${this.roleUrl}/${id}`);
  }
  // Create role
  public create(data): Observable<any> {
    return this.http.post(this.roleUrl, data);
  }
  // update role
  public update(id, data): Observable<any> {
    return this.http.put(`${this.roleUrl}/${id}`, data);
  }
  // delete role by id
  public delete(id): Observable<any> {
    return this.http.delete(`${this.roleUrl}/${id}`);
  }

}
