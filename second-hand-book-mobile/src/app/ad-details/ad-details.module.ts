import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { AdDetailsPageRoutingModule } from './ad-details-routing.module';

import { AdDetailsPage } from './ad-details.page';
import { MyCommonModule } from '../my-common/my-common.module';

@NgModule({
  imports: [
    MyCommonModule,
    CommonModule,
    FormsModule,
    IonicModule,
    AdDetailsPageRoutingModule
  ],
  declarations: [AdDetailsPage]
})
export class AdDetailsPageModule {}
