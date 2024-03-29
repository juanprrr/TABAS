import { BaggageToFlightComponent } from './Components/baggage-to-flight/baggage-to-flight.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {WregisterComponent} from "../app/Components/wregister/wregister.component";
import { LoginComponent } from './Components/login/login.component';
import { MainmenuComponent } from './Components/mainmenu/mainmenu.component';
import { SigninComponent } from './Components/signin/signin.component';
import { AssbagcartComponent } from './Components/assbagcart/assbagcart.component';

const routes: Routes = [
  {path:'Wregister', component: WregisterComponent},
  {path:'Login', component: LoginComponent},
  {path:'Signin', component: SigninComponent},
  {path: 'BaggageToFlight', component: BaggageToFlightComponent},
  {path:'Mainmenu', component: MainmenuComponent},
  {path:'Assbagcart', component: AssbagcartComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [WregisterComponent, LoginComponent, SigninComponent, MainmenuComponent,AssbagcartComponent] 