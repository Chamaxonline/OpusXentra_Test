import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment.prod';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
  apiUrl = environment.apiBase + 'Department/';
  apiBaseUrl = environment.apiBase;
  constructor(private _http: HttpClient) { }

  addDepartment(department) {
    var tokenHeader = new HttpHeaders({ 'Authorization': 'Bearer ' + localStorage.getItem('token') })
    let saveDepartment = this.apiUrl + "AddDepartment";
    return this._http.post<any>(saveDepartment, department,{headers:tokenHeader});
  }
  getAllDepartments(){
    debugger
    var tokenHeader = new HttpHeaders({ 'Authorization': 'Bearer ' + localStorage.getItem('token') })
    let departments = this.apiUrl + "GetAllDepartments";
    return this._http.get<any>(departments,{headers:tokenHeader});
  }
}
