import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomepageComponent } from './homepage/homepage.component';
import { LoginComponent } from './login/login.component';
import { ShowProductSpeakerComponent } from './show-product-speaker/show-product-speaker.component';
// import { ProductComponent } from './product/product.component';
import { ShowProductComponent } from './show-product/show-product.component';

const routes: Routes = [
  {path:'login',component:LoginComponent},
  // {path: 'product', component:ProductComponent}
  {path: 'product', component:ShowProductComponent},
  {path: 'product', component:ShowProductSpeakerComponent}

];

export default routes;

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
