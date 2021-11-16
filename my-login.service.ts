 
import { Injectable } from '@angular/core';
import { cls_LoginModel } from 'src/Model/cls_LoginModel';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { flatten } from '@angular/compiler';
@Injectable({
  providedIn: 'root'
})
export class MyloginService {
  public api='https://localhost:44384/api/';
  mystatus:number=0;
  public getapi='https://localhost:44384/api/';
  constructor(private http:HttpClient) {

   }
   postlogin(logindata:cls_LoginModel):number{
    let endpoints="Admin/AdminLogin";
    let loginStatus:boolean=false;
    this.http.post(this.getapi+endpoints,logindata).subscribe(
      (i:any) => { this.mystatus=i.status; console.log("mystatus="+this.mystatus);}
       
      );
     return this.mystatus; 
  }

}
