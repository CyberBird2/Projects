import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PatientPageComponent } from './patient-page/patient-page.component';
import { AccordionModule } from './accordion/accordion.module';

import { RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { PatientComponent } from './patient/patient.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    PatientPageComponent,
    LoginComponent,
    PatientComponent
  ],
  imports: [
    BrowserModule,
    AccordionModule,
    RouterModule.forRoot([
      {path: '', component: LoginComponent},
      {path: 'dashboard', component: DashboardComponent},
      {path: 'patient', component: PatientPageComponent},
      {path: 'patient/{name}', component: PatientPageComponent}
    ]),

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
