import { Component } from '@angular/core';
@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.scss'],
})
export class AppComponent {
  public appPages = [
    { title: 'Login', url: '/login', icon: 'accessibility' },
    { title: 'SignUp', url: '/sign-up', icon: 'body' },
    { title: 'List Ads', url: '/list-ads', icon: 'heart' },
  ];
  public labels = ['Family', 'Friends', 'Notes', 'Work', 'Travel', 'Reminders'];

  constructor() {
    if( localStorage.getItem('userId') != null ) {
      this.appPages.push({ title: 'Create Ad', url: '/create-ad', icon: 'archive' });
    }
  }
}
