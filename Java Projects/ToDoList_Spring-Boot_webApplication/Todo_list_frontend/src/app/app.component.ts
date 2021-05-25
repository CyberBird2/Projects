
import { Component } from '@angular/core';
import {AuthService} from './Service/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
   title: string;
  isLoggedIn = false;
    constructor( public loginService: AuthService) {
    this.title = 'ToDoList';
  }
  // tslint:disable-next-line:use-lifecycle-interface
  ngOnInit() {}

}
