import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Suitcase } from '../Model/suitcase';

@Injectable({
  providedIn: 'root'
})
export class SuitcaseService {
  url='https://localhost:7076/api/Suitcase/'
  constructor(private httpclient:HttpClient) { }

  //GetSuitcase
  getSuitcase(Number:number):Observable<Suitcase>{
    let params = new HttpParams().set('Number', Number)
    return this.httpclient.get<Suitcase>(this.url+'Get', {params:params})
  }

  //PostSuitcase
  insertSuitcase(suitcase:Suitcase):Observable<any>{
    return this.httpclient.post(this.url+'Post', suitcase)
  }
}
