import { CoreModule } from './core/core.module';
import { MainNavComponent } from './main-nav/main-nav.component';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatGridListModule } from '@angular/material/grid-list';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import { EmployeesComponent } from './employees/employees.component';
import { TasksComponent } from './tasks/tasks.component';
import { DepartmentsComponent } from './departments/departments.component';
import { AppRoutingModule } from './app-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSidenavModule } from '@angular/material/sidenav';
import {MatListModule} from '@angular/material/list';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort'; 
import {MatCardModule} from '@angular/material/card';
import {MatInputModule} from '@angular/material/input';
import {MatDatepickerModule} from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import {MatDialogModule} from '@angular/material/dialog';
import {MatSlideToggleModule} from '@angular/material/slide-toggle';
import { TaskDialogBoxComponent } from './task-dialog-box/task-dialog-box.component';
import { EmployeeDialogBoxComponent } from './employee-dialog-box/employee-dialog-box.component';
import { DepartmentDialogBoxComponent } from './department-dialog-box/department-dialog-box.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeesComponent,
    TasksComponent,
    DepartmentsComponent,
    DashboardComponent,
    MainNavComponent,
    TaskDialogBoxComponent,
    EmployeeDialogBoxComponent,
    DepartmentDialogBoxComponent
  ],
  imports: [
    CoreModule,
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatSidenavModule,    
    MatListModule, LayoutModule, MatToolbarModule, MatButtonModule, MatIconModule, MatTableModule, 
    MatPaginatorModule, MatSortModule, MatGridListModule, MatCardModule, MatInputModule, MatFormFieldModule,
    MatDatepickerModule,MatNativeDateModule, MatDialogModule, MatSlideToggleModule,
  ],
  entryComponents: [
    TaskDialogBoxComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
