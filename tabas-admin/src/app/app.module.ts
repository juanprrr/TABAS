import { NgModule, Component } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule, routingComponents } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBarComponent } from './Components/nav-bar/nav-bar.component';
import { LoginComponent } from './Components/login/login.component';
import { HomeComponent } from './Components/home/home.component';
import { SigninComponent } from './Components/signin/signin.component';
import { BaggageToFlightComponent } from './Components/baggage-to-flight/baggage-to-flight.component';
import { MainmenuComponent } from './Components/mainmenu/mainmenu.component';
import { AssbagcartComponent } from './Components/assbagcart/assbagcart.component';


@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    LoginComponent,
    HomeComponent,
    SigninComponent,
    routingComponents,
    BaggageToFlightComponent,
    MainmenuComponent,
    AssbagcartComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
