import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";

@Component( {
  selector: 'app-formulaires-exercice2',
  templateUrl: './formulaires-exercice2.component.html',
  styleUrls: [ './formulaires-exercice2.component.css' ]
} )
export class FormulairesExercice2Component implements OnInit
{

  form: FormGroup = new FormGroup(
    {
      username: new FormControl( '', [
        Validators.required,
        Validators.minLength( 5 )
      ] ),
      password: new FormControl( '', [
        Validators.required,
        Validators.minLength( 5 )
      ] )
    } );

  constructor()
  {
  }

  get control()
  {
    return this.form.controls;
  }

  ngOnInit(): void
  {
  }

  sendData()
  {
    console.log( this.form.value );
  }
}
