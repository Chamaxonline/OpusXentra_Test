import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.prod';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {
  apiUrl = environment.apiBase + 'company/';
  apiBaseUrl = environment.apiBase;
  constructor(private _http: HttpClient) { }

  addDepartment(company) {
    var tokenHeader = new HttpHeaders({ 'Authorization': 'Bearer ' + localStorage.getItem('token') })
    let saveDepartment = this.apiUrl + "AddCompany";
    return this._http.post<any>(saveDepartment, company,{headers:tokenHeader});
  }
}
