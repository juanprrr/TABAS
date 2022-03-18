import { BaggageToFlightComponent } from './Components/baggage-to-flight/baggage-to-flight.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {WregisterComponent} from "../app/Components/wregister/wregister.component";
import { LoginComponent } from './Components/login/login.component';
import { SigninComponent } from './Components/signin/signin.component';

const routes: Routes = [
  {path:'Wregister', component: WregisterComponent},
  {path:'Login', component: LoginComponent},
  {path:'Signin', component: SigninComponent},
  {path: 'BaggageToFlight', component: BaggageToFlightComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [WregisterComponent, LoginComponent] 