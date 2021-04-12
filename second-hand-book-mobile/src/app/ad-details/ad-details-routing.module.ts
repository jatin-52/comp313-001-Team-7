import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AdDetailsPage } from './ad-details.page';

const routes: Routes = [
  {
    path: '',
    component: AdDetailsPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AdDetailsPageRoutingModule {}
