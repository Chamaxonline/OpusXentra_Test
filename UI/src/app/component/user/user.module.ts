import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserRoutingModule } from './user-routing.module';
import { RegistrationComponent } from './registration/registration.component';


@NgModule({
  declarations: [RegistrationComponent],
  imports: [
    CommonModule,
    UserRoutingModule
  ]
})
export class UserModule { }
