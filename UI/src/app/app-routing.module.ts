import { NgModule } from '@angular/core';
import { Routes, RouterModule,CanActivate } from '@angular/router';
import { CompanyProfileComponent } from './component/company/company-profile/company-profile.component';
import { DashboardComponent } from './component/dashboard/dashboard.component';
import { EmployeeProfileComponent } from './component/employee/employee-profile/employee-profile.component';
import { HomeComponent } from './component/home/home.component';
import { LoginComponent } from './component/login/login.component';import { NavComponent } from './component/nav/nav.component';
import { RegistrationComponent } from './component/user/registration/registration.component';
import { AuthGuard } from './services/auth.guard';



const routes: Routes = [

  { path: 'login', component: LoginComponent, },
  { path: 'dashboard', component: DashboardComponent,canActivate:[AuthGuard]},
  { path: 'nav', component: NavComponent,canActivate:[AuthGuard] },
  { path: 'user/registration', component: RegistrationComponent },
  { path: 'company/copanyprofile', component: CompanyProfileComponent,canActivate:[AuthGuard]},
  { path: 'employee/employeeprofile', component: EmployeeProfileComponent,canActivate:[AuthGuard]}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
