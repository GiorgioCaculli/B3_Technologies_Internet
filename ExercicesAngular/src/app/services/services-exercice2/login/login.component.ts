import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { AuthService } from "../auth.service";

@Component( {
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: [ './login.component.css' ]
} )
export class LoginComponent implements OnInit
{

  formLogin: FormGroup = this.fb.group(
    {
      email: [ '', Validators.required ],
      password: [ '', Validators.required ]
    }
  )

  constructor( private fb: FormBuilder, private authService: AuthService )
  {
  }

  ngOnInit(): void
  {
  }

  login()
  {
    this.authService.authenticate(
      this.formLogin.value.email,
      this.formLogin.value.password
    );
  }
}
