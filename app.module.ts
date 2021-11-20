import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { MyloginService } from './my-login.service';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import routes,{ AppRoutingModule } from './app-routing.module';
import { FormsModule } from '@angular/forms';
import { HomepageComponent } from './homepage/homepage.component';
// import { ProductComponent } from './product/product.component';
import { MyProductService } from './my-product.service';
import { ShowProductComponent } from './show-product/show-product.component';
import { ShowProductSpeakerComponent } from './show-product-speaker/show-product-speaker.component';




@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomepageComponent,
    ShowProductComponent,
    ShowProductSpeakerComponent
    // ProductComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    FormsModule

  ],
  providers: [MyloginService, MyProductService],
   bootstrap: [ShowProductComponent]
  // [ShowProductSpeakerComponent]
  

})
export class AppModule { }
