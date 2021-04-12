import { Injectable } from '@angular/core';
import axios from 'axios';
import { Ad } from '../Models/ad';

@Injectable({
  providedIn: 'root'
})
export class AdsService {

  private url = "http://secondhandbook-dev.us-east-2.elasticbeanstalk.com/api/BookADSAPI/";
  constructor() { }
  
  Create(input: Ad) {
    return axios.post(this.url, input);
  }

  List() {
    return axios.get(this.url);
  }

  BookDetails(bookId) {
    return axios.get(this.url+'/'+bookId);
  }
}
