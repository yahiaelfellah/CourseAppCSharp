import { Injectable } from '@angular/core';
import { Http,HttpModule,RequestOptions,Response,Headers } from '@angular/http';
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import { Login } from '../model/Login';

@Injectable()
export class LoginAuthenticationService {

    constructor(private http: Http) {

        this.http = http;
    }

    authentication(username:string,password:string): any {

        var model = { Username: username, Password: password };

        this.http.post("/Main/Login", model).map(res => res.toString()).subscribe(
            success => {
                window.location.href = "/LoggedIn/index";
            });

    }




}