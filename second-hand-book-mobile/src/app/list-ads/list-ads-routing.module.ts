import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ListAdsPage } from './list-ads.page';

const routes: Routes = [
  {
    path: '',
    component: ListAdsPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ListAdsPageRoutingModule {}
