import { Component, OnInit } from '@angular/core';
import {RoleService} from '../../Module/Role-module/role.service';


@Component({
  selector: 'app-add-role',
  templateUrl: './add-role.component.html',
  styleUrls: ['./add-role.component.css']
})
export class AddRoleComponent implements OnInit {
  currentRole = null;
  role = {
    name: ''
  };
  submitted = false;

  constructor( private roleService: RoleService) { }

  ngOnInit(): void {
  }

// Save role
  saveRole(): void {
    const data = {
      name: this.role.name
    };

    this.roleService.create(data)
      .subscribe(
        response => {
          console.log(response);
          this.submitted = true;
        },
        error => {
          console.log(error);
        });
  }

// new role
  newRole(): void {
    this.submitted = false;
    this.role = {
      name: ''
    };
  }


}
