import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment.prod';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApplicationUserService {
  apiUrl = environment.apiBase;

  constructor(private _http: HttpClient) { }

  login(userDetail) {
    let getAllCustomer = this.apiUrl + "ApplicationUser/Login";
    return this._http.post<any>(getAllCustomer,userDetail);
  }
}
