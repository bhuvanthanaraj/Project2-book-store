import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly APIUrl = "https://localhost:7287/api";
  constructor(private http:HttpClient,private router:Router) { }


  studetails():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/home');
  }

}
