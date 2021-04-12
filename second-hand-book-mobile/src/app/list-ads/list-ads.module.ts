import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { ListAdsPageRoutingModule } from './list-ads-routing.module';

import { ListAdsPage } from './list-ads.page';
import { MyCommonModule } from '../my-common/my-common.module';

@NgModule({
  imports: [
    MyCommonModule,
    CommonModule,
    FormsModule,
    IonicModule,
    ListAdsPageRoutingModule
  ],
  declarations: [ListAdsPage]
})
export class ListAdsPageModule {}
