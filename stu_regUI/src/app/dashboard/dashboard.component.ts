import { Component, OnInit } from '@angular/core';
import { SharedService } from '../shared.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})

export class DashboardComponent implements OnInit {

  constructor(private service :SharedService,private router:Router) { }
  StudentName:any;
  StudentCode:any;
  Department:any;
  Gender:any;
  EmailId:any;
  Dob:any;
  studetails:any=[];
  ngOnInit() {
    this.service.studetails().subscribe((data) => {
      this.studetails = data;
    });
    this.StudentName = sessionStorage.getItem('StudentName');
    this.StudentCode = sessionStorage.getItem('StudentCode');
    this.Department = sessionStorage.getItem('Department');
    this.Gender = sessionStorage.getItem('Gender');
    this.EmailId = sessionStorage.getItem('EmailId');
    this.Dob = sessionStorage.getItem('Dob');
  }
}
