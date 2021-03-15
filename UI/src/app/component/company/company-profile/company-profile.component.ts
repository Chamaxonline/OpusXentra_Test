import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Company } from 'src/app/entity/company';
import { CompanyService } from 'src/app/services/company.service';

@Component({
  selector: 'app-company-profile',
  templateUrl: './company-profile.component.html',
  styleUrls: ['./company-profile.component.scss']
})
export class CompanyProfileComponent implements OnInit {

  constructor(private _companyService: CompanyService,private _toastr: ToastrService) { }
  company: Company;
  companyform = new FormGroup({
    name: new FormControl('', Validators.required),
    email: new FormControl('', ),
    website: new FormControl('',)
  });
  ngOnInit(): void {
  }
  companySubmit()
  {
    this.company = this.companyform.value
    //this.login.password="12345";
    this._companyService.addDepartment(this.company).subscribe(
      (res: any) => {
        debugger
        this._toastr.success('Company Created successfully', '');
       
      },
      err => {
        if (err.status == 400) {

        }
       
        else
          console.log(err);
          this._toastr.error('Incorrect UserName or Passwords', 'Authencation failed');
      }
    );
  }

}
