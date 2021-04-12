import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from "../services/auth.service";

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {

  public loginForm: FormGroup;

  constructor(
    private authServcie: AuthService, 
    private formBuilder: FormBuilder,
    private router: Router
  ) {
  }

  ngOnInit() {
    this.loginForm = new FormGroup({
      'email': new FormControl('', [Validators.required, Validators.email]),
      'password': new FormControl('', [Validators.required])
    });
  }

  login() {
    var formDetails = this.loginForm;
    console.log('--form--', this.loginForm.get('email').value);
    if(!formDetails.valid) {
      // show error
      return ;
    }
    this.authServcie.Login(this.loginForm.get('email').value, this.loginForm.get('password').value).then((res) => {
      localStorage.setItem("userEmail", this.loginForm.get('email').value);
      localStorage.setItem("userId", res.data);
      // this.router.navigate(['/list-ads']);
      window.location.href = '/list-ads';
    }, (err) => {
      console.assert(err);
      console.log("user not found");
    });
  }

}
