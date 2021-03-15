import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Login } from 'src/app/entity/login';
import { User } from 'src/app/entity/User';
import { ApplicationUserService } from 'src/app/services/application-user.service';
import { UserService } from 'src/app/services/user.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  constructor(private _userService: UserService, private router: Router,private _toastr:ToastrService) { }
  login: Login;
  userLoginform = new FormGroup({
    username: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required)
  });

  ngOnInit(): void {

  }
  userLoginSubmit() {
    debugger

    this.login = this.userLoginform.value
    //this.login.password="12345";
    this._userService.userLogin(this.login).subscribe(
      (res: any) => {
        debugger
        localStorage.setItem('token', res.token);
        localStorage.setItem('islogged', 'success');
        // this._toastr.success("Login Success",'Congratulations')
        this.router.navigateByUrl('/dashboard')
        //this._commonService.callComponentMethod();
      },
      err => {
        if (err.status == 400) {
          this._toastr.error('Incorrect UserName or Passwords', 'Authencation failed');
        }
        
        else
          console.log(err);
      }
    );
  }
}