import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CreateAdPage } from './create-ad.page';

const routes: Routes = [
  {
    path: '',
    component: CreateAdPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CreateAdPageRoutingModule {}
