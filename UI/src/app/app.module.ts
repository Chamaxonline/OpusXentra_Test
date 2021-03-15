import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './component/nav/nav.component';
import { DashboardComponent } from './component/dashboard/dashboard.component';
import { UserModule } from './component/user/user.module';
import { RegistrationComponent } from './component/user/registration/registration.component';
import { HomeComponent } from './component/home/home.component';
import { LoginComponent } from './component/login/login.component';
import { HttpClientModule } from '@angular/common/http';
import { UserService } from './services/user.service';
import { AuthGuard } from './services/auth.guard';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CompanyProfileComponent } from './component/company/company-profile/company-profile.component';
import { CompanyGridComponent } from './component/company/company-grid/company-grid.component';
import { EmployeeProfileComponent } from './component/employee/employee-profile/employee-profile.component';
import { EmployeeGridComponent } from './component/employee/employee-grid/employee-grid.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    DashboardComponent,
    HomeComponent,
    LoginComponent,
    CompanyProfileComponent,
    CompanyGridComponent,
    EmployeeProfileComponent,
    EmployeeGridComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    UserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(), // ToastrModule added
     
  ],
  providers: [UserService,AuthGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
