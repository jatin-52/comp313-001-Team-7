import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { FolderPageRoutingModule } from './folder-routing.module';

import { FolderPage } from './folder.page';
import { MyCommonModule } from '../my-common/my-common.module';
import { MyHeaderComponent } from '../my-common/my-header/my-header.component';

@NgModule({
  imports: [
    MyCommonModule,
    CommonModule,
    FormsModule,
    IonicModule,
    FolderPageRoutingModule
  ],
  declarations: [FolderPage]
})
export class FolderPageModule {}
