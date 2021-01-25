import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { EmployeeComponent } from './employee/employee.component';
import { AddEmployeeComponent } from './employee/addEmployee.component';
import { EmployeeService } from './employee/employee.service';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    EmployeeComponent,
    AddEmployeeComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'home', component: HomeComponent },
      { path: 'employee', component: EmployeeComponent },
      { path: 'register-employee', component: AddEmployeeComponent },
      { path: 'employee/edit/:id', component: AddEmployeeComponent },
      { path: '**', redirectTo: 'home' }  
    ])
  ],
  providers: [ EmployeeService ],
  bootstrap: [AppComponent]
})
export class AppModule { }
