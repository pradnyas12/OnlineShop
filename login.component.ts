import { Component, OnInit } from '@angular/core';
import { cls_LoginModel } from 'src/Model/cls_LoginModel';
import { MyloginService } from '../my-login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  Userlogin:cls_LoginModel={
      AdminId:"",
      AdminPassword:""
  };
  constructor(private m1:MyloginService) { }

  ngOnInit(): void {
  }
  loginStatus:number=0;
  validate(login:cls_LoginModel){

   this.loginStatus=this.m1.postlogin(login);
    console.log(login.AdminId) ;
  console.log(this.loginStatus);
    
  }

}
