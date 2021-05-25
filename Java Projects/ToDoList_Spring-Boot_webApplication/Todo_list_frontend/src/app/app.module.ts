import { NavMainComponent } from './nav-main/nav-main.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ChartsModule } from 'ng2-charts';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSidenavModule} from '@angular/material/sidenav';
import { MatTabsModule} from '@angular/material/tabs';
import { MatToolbarModule} from '@angular/material/toolbar';
import { MatIconModule} from '@angular/material/icon';
import { MatListModule} from '@angular/material/list';
import { MatCardModule} from '@angular/material/card';
import { LayoutModule } from '@angular/cdk/layout';
import { MatButtonModule } from '@angular/material/button';
import {HTTP_INTERCEPTORS, HttpClientModule} from '@angular/common/http';
import { RoleListComponent } from './Role/role-list/role-list.component';
import { AddRoleComponent} from './Role/add-role/add-role.component';
import { AddTaskComponent } from './task/add-task/add-task.component';
import { TaskListComponent } from './task/task-list/task-list.component';
import { AddEmployeeComponent } from './employee/add-employee/add-employee.component';
import { EmployeeListComponent } from './employee/employee-list/employee-list.component';
import { AddDepartmentComponent } from './department/add-department/add-department.component';
import { DepartmentListComponent } from './department/department-list/department-list.component';
import { LoginComponent } from './login/login.component';
import { LogoutComponent } from './logout/logout.component';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import {BasicAuthInterceptorService} from './Service/basic-auth-interceptor.service';
import {NotificationsComponent} from './websocket/notifications..component';



@NgModule({
  declarations: [
    AppComponent,
    NavMainComponent,
    AddRoleComponent,
    RoleListComponent,
    AddTaskComponent,
    TaskListComponent,
    AddEmployeeComponent,
    EmployeeListComponent,
    AddDepartmentComponent,
    DepartmentListComponent,
    LoginComponent,
    LogoutComponent,
    NotificationsComponent,

  ],
  imports: [
    BrowserModule,
    ChartsModule,
    AppRoutingModule,
    FormsModule,
    Ng2SearchPipeModule,
    BrowserAnimationsModule,
    LayoutModule,
    MatTabsModule,
    MatToolbarModule,
    MatIconModule,
    MatSidenavModule,
    MatListModule,
    MatCardModule,
    MatButtonModule,
    HttpClientModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatProgressSpinnerModule

  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: BasicAuthInterceptorService,
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
