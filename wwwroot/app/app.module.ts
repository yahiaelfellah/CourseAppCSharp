import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Http, Headers, RequestOptions } from '@angular/http';
import { Router } from '@angular/router';
import { LoginAuthenticationService } from './services/login.service';


@NgModule({
    imports: [BrowserModule, HttpModule,FormsModule],
    declarations: [AppComponent],
    bootstrap: [AppComponent],
    providers: [LoginAuthenticationService]
})
export class AppModule { }