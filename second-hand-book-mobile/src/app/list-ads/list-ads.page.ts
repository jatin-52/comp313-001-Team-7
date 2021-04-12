import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AdList } from '../Models/ad';
import { AdsService } from '../services/ads.service';
import { EventService } from '../services/event.service';

@Component({
  selector: 'app-list-ads',
  templateUrl: './list-ads.page.html',
  styleUrls: ['./list-ads.page.scss'],
})
export class ListAdsPage implements OnInit {
  public allAds: Array<AdList> = [];

  constructor(
    private ads: AdsService, 
    private router: Router,
    private eventService: EventService
  ) { }

  ngOnInit() {
    this.ads.List().then(res => {
      this.allAds = res.data;
      console.log('--res--', this.allAds);
    });
  }

  goToAdsDetails(item: AdList) {
    this.eventService.ad = item;
    this.router.navigate(['ad-details']);
  }
}
