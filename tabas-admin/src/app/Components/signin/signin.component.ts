import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from 'src/app/Model/employee';
import { EmployeeService } from 'src/app/Service/employee.service';
import { LoginComponent } from '../login/login.component';

@Component({
  selector: 'app-signin',
  templateUrl: './signin.component.html',
  styleUrls: ['./signin.component.css']
})
export class SigninComponent implements OnInit {
  newEmployee:Employee = new Employee
  constructor(private service:EmployeeService, private router:Router) { }

  ngOnInit(): void {
  }

  addEmployee(newEmployee:Employee){
    this.service.insertEmployee(newEmployee).subscribe(()=>{
      this.router.navigate([`${'Mainmenu'}`])
    },()=>alert("No se pudo registrar su usuario, porfavor intente de nuevo!"))
  }
}
