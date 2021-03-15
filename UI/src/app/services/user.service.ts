import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.prod';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  apiUrl = environment.apiBase + 'ApplicationUser/';
  apiBaseUrl = environment.apiBase;
  constructor(private _http: HttpClient) { }

  userLogin(user) {
    debugger
    let userCredential = this.apiUrl + 'Login';
    return this._http.post<any>(userCredential, user);
  }

  loggedIn(){
    return !!localStorage.getItem('token')
  }
}
