import { Component, OnInit } from '@angular/core';
import {RoleService} from '../../Module/Role-module/role.service';
import {Role} from '../../Module/Role-module/role';
import {ActivatedRoute, Router} from '@angular/router';

@Component({
  selector: 'app-role-list',
  templateUrl: './role-list.component.html',
  styleUrls: ['./role-list.component.css']
})
export class RoleListComponent implements OnInit {

  get searchTerm(): string {
    return this.searchText;
  }
  set searchTerm(value) {
    this.searchText = value;
    this.filterRole = this.filteredRole(value);
  }
  roles: any;
  currentRole = null;
  searchText: string;
  selectedRole: Role;
  filterRole: Role[];
  name = '';
  message = '';

  constructor(private roleService: RoleService, private route: ActivatedRoute,
              private router: Router) {}

  ngOnInit(): void {

    this.retrieveRoles();
    this.message = '';
    this.getRole(this.route.snapshot.paramMap.get('id'));
  }

  filteredRole(searchString: string) {
    return  this.roles.filter(task =>
      task.name.toLowerCase().indexOf(searchString.toLowerCase()) !== -1);
  }

  retrieveRoles(): void {
    this.roleService.getAll()
      .subscribe(
        data => {
          this.roles = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }
  onSelect(role: Role): void {
    this.selectedRole = role;
  }
  getRole(id): void {
    this.roleService.get(id)
      .subscribe(
        data => {
          this.currentRole = data;
          console.log(data);
        },
        error => {
          console.log(error);
        });
  }

  updateRole(): void {
    this.roleService.update(this.currentRole.id, this.currentRole)
      .subscribe(() => this.retrieveRoles());
    this.message = 'The role was updated successfully';
  }
  deleteRole(): void {
    this.roleService.delete(this.currentRole.id)
      .subscribe(() => this.retrieveRoles());
    this.message = 'The role was deleted successfully';
  }

}
