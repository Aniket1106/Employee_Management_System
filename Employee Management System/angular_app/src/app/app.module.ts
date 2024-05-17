import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './auth/login/login.component';
import { SignInComponent } from './auth/sign-in/sign-in.component';
import { NavbarComponent } from './landing-page/navbar/navbar.component';
import { HomePageComponent } from './landing-page/home_page/home-page/home-page.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    SignInComponent,
    NavbarComponent,
    HomePageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
