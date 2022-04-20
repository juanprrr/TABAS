import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Employee } from '../Model/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  url='https://localhost:7076/api/Employee/'
  constructor(private httpclient:HttpClient) { }

  //GetEmployee
  getEmployee(Id:number):Observable<Employee>{
    let params = new HttpParams().set('Id', Id)
    return this.httpclient.get<Employee>(this.url+'GetById', {params:params})
  }

  //PostSuitcase
  insertEmployee(employee:Employee):Observable<any>{
    return this.httpclient.post(this.url+'AddEmployee', employee)
  }
}
