import { Injectable } from '@angular/core';
import axios from 'axios';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private url = "http://secondhandbook-dev.us-east-2.elasticbeanstalk.com/api/MobileLogin/";
  constructor() { }

  Login(email, password) {
    return axios.post(this.url+'Login', {
      Email: email,
      Password: password
    });
  }

  SignUp(email, password) {
    return axios.post(this.url+'SignUp', {
      Email: email,
      Password: password
    });
  }
}
