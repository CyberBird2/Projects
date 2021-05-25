import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {RoleListComponent} from './Role/role-list/role-list.component';
import {AddRoleComponent} from './Role/add-role/add-role.component';
import {NavMainComponent} from './nav-main/nav-main.component';
import {AddTaskComponent} from './task/add-task/add-task.component';
import {TaskListComponent} from './task/task-list/task-list.component';
import {EmployeeListComponent} from './employee/employee-list/employee-list.component';
import {AddEmployeeComponent} from './employee/add-employee/add-employee.component';
import {DepartmentListComponent} from './department/department-list/department-list.component';
import {AddDepartmentComponent} from './department/add-department/add-department.component';
import {LoginComponent} from './login/login.component';
import {LogoutComponent} from './logout/logout.component';
import {AuthGaurdService} from './Service/auth-gaurd.service';
import {NotificationsComponent} from './websocket/notifications..component';



const routes: Routes = [

  { path: '' , redirectTo: '/departments', pathMatch: 'full'},
  { path: 'departments', component: DepartmentListComponent ,  canActivate: [AuthGaurdService]},
  { path: 'AddDepartment', component: AddDepartmentComponent,  canActivate: [AuthGaurdService]},
  { path: 'roles', component: RoleListComponent,  canActivate: [AuthGaurdService]},
  { path: 'addRole', component: AddRoleComponent,  canActivate: [AuthGaurdService]},
  { path: 'tasks', component: TaskListComponent,   canActivate: [AuthGaurdService]},
  { path: 'addTask', component: AddTaskComponent,  canActivate: [AuthGaurdService]},
  { path: 'employees', component: EmployeeListComponent,  canActivate: [AuthGaurdService]},
  { path: 'addEmployee', component: AddEmployeeComponent,  canActivate: [AuthGaurdService]},
  { path: 'sidebar', component: NavMainComponent, canActivate: [AuthGaurdService]},
  {path: 'notifications', component: NotificationsComponent, canActivate: [AuthGaurdService]},
  { path: 'login', component: LoginComponent},
  { path: 'logout', component: LogoutComponent},
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes,  {
    onSameUrlNavigation: 'reload'
  })],
  exports: [RouterModule]
})

export class AppRoutingModule { }
