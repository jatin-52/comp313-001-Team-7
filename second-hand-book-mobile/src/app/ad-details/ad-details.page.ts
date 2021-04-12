import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AdList } from '../Models/ad';
import { EventService } from '../services/event.service';

@Component({
  selector: 'app-ad-details',
  templateUrl: './ad-details.page.html',
  styleUrls: ['./ad-details.page.scss'],
})
export class AdDetailsPage implements OnInit {
  public ad: AdList;
  constructor(
    private eventService: EventService,
    private router: Router
  ) { }

  ngOnInit() {
    if(!this.eventService.ad) {
      this.router.navigate(['list-ads']);
    }
    console.log(this.eventService.ad);
    this.ad = this.eventService.ad;
  }

}
