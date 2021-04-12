import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'login',
    pathMatch: 'full'
  },
  {
    path: 'folder/:id',
    loadChildren: () => import('./folder/folder.module').then( m => m.FolderPageModule)
  },
  {
    path: 'login',
    loadChildren: () => import('./login/login.module').then( m => m.LoginPageModule)
  },
  {
    path: 'sign-up',
    loadChildren: () => import('./sign-up/sign-up.module').then( m => m.SignUpPageModule)
  },
  {
    path: 'create-ad',
    loadChildren: () => import('./create-ad/create-ad.module').then( m => m.CreateAdPageModule)
  },
  {
    path: 'list-ads',
    loadChildren: () => import('./list-ads/list-ads.module').then( m => m.ListAdsPageModule)
  },
  {
    path: 'ad-details',
    loadChildren: () => import('./ad-details/ad-details.module').then( m => m.AdDetailsPageModule)
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}
