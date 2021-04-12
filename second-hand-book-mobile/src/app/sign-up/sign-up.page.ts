import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.page.html',
  styleUrls: ['./sign-up.page.scss'],
})
export class SignUpPage implements OnInit {

  public signUpForm: FormGroup;
  constructor(
    private authServcie: AuthService, 
    private formBuilder: FormBuilder,
    private router: Router
  ) {
  }

  ngOnInit() {
    this.signUpForm = new FormGroup({
      'email': new FormControl('', [Validators.required, Validators.email]),
      'password': new FormControl('', [Validators.required])
    });
  }

  signUp() {
    var formDetails = this.signUpForm;
    console.log('--form--', this.signUpForm.get('email').value);
    if(!formDetails.valid) {
      // show error
      return ;
    }
    this.authServcie.SignUp(this.signUpForm.get('email').value, this.signUpForm.get('password').value).then((res) => {
      this.router.navigate(['/login']);
    }, (err) => {
      console.assert(err);
      console.log("user not found");
    });
  }

}
