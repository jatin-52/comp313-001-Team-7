import { Component } from '@angular/core';
import { EventService } from './services/event.service';
import { Router } from '@angular/router';
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
  public userEmail = '';

  constructor(public eventService: EventService, private router: Router) {
    this.refreshThis();
  }

  refreshThis() {
    if( localStorage.getItem('userId') != null ) {
      this.userEmail = localStorage.getItem('userEmail');
      this.appPages.push({ title: 'Create Ad', url: '/create-ad', icon: 'archive' });
    }
  }

  logMeOut() {
    localStorage.clear();
    this.refreshThis();
    this.router.navigate(['/login']);
  }
}
