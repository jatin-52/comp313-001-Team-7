import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { SignUpPageRoutingModule } from './sign-up-routing.module';

import { SignUpPage } from './sign-up.page';
import { MyCommonModule } from '../my-common/my-common.module';

@NgModule({
  imports: [
    MyCommonModule,
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    IonicModule,
    SignUpPageRoutingModule
  ],
  declarations: [SignUpPage]
})
export class SignUpPageModule {}
