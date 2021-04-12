import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MyHeaderComponent } from './my-header/my-header.component';
import { FormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';

@NgModule({
  declarations: [MyHeaderComponent],
  imports: [
    CommonModule
  ],
  bootstrap: [],
  exports: [MyHeaderComponent]
})
export class MyCommonModule { }
