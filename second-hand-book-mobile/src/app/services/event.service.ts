import { Injectable } from '@angular/core';
import { AdList } from '../Models/ad';

@Injectable({
  providedIn: 'root'
})
export class EventService {
  public ad: AdList;

  public userEmail: string = '';
  public userId: string = '';
  
  constructor() { }
}
