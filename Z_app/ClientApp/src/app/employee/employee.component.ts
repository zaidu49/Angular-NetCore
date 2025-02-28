import { Component, Inject } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { HttpClient } from '@angular/common/http';
import { Router, ActivatedRoute } from '@angular/router';
import { EmployeeService } from './employee.service';

@Component({
  templateUrl: './employee.component.html'
})

export class EmployeeComponent {
  public empList: EmployeeData[];

  constructor(public http: HttpClient, private _router: Router, private _employeeService: EmployeeService) {
    this.getEmployees();
  }

  getEmployees() {
    this._employeeService.getEmployees().subscribe(
      data => this.empList = data
      
    )
  }

  delete(employeeID) {
    var ans = confirm("Do you want to delete customer with Id: " + employeeID);
    if (ans) {
      this._employeeService.deleteEmployee(employeeID).subscribe((data) => {
        this.getEmployees();
      }, error => console.error(error))
    }
  }
}

interface EmployeeData {
  employeeId: number;
  name: string;
  gender: string;
  city: string;
  department: string;

}
