import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { CreateAdPageRoutingModule } from './create-ad-routing.module';

import { CreateAdPage } from './create-ad.page';
import { MyCommonModule } from '../my-common/my-common.module';

@NgModule({
  imports: [
    MyCommonModule,
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    IonicModule,
    CreateAdPageRoutingModule
  ],
  declarations: [CreateAdPage]
})
export class CreateAdPageModule {}
