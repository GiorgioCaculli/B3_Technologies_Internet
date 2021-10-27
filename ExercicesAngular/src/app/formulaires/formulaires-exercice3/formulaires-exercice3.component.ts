import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";

@Component( {
  selector: 'app-formulaires-exercice3',
  templateUrl: './formulaires-exercice3.component.html',
  styleUrls: [ './formulaires-exercice3.component.css' ]
} )
export class FormulairesExercice3Component implements OnInit
{

  form: FormGroup = this.fb.group(
    {
      main: this.fb.group( {
        username: this.fb.control( "",
          [
            Validators.required,
            Validators.minLength( 5 )
          ] ),
        password: this.fb.control( "",
          [
            Validators.required,
            Validators.minLength( 5 )
          ] ),
        email: this.fb.control( "",
          [
            Validators.required
          ] ),
        date: this.fb.control( "",
          [
            Validators.pattern( /^\d{2}\/\d{2}\/\d{4}$/ ),
            Validators.required
          ] )
      } ),
      other: this.fb.group( {
        continueCourse: this.fb.control( true ),
        angularKnowledge: this.fb.control( "From school" ),
        ratingTI: this.fb.control( 3 )
      } )
    } )

  constructor( private fb: FormBuilder )
  {
  }

  ngOnInit(): void
  {
  }

  sendData()
  {
    console.log( this.form.value );
  }

  reset()
  {
    this.form.reset();
  }

  autocomplete()
  {
    this.form.setValue(
      {
        main:
          {
            username: "Username",
            password: "Password",
            email: "email@email.com",
            date: "10/10/1990"
          },
        other:
          {
            continueCourse: true,
            angularKnowledge: 'Both',
            ratingTI: 5
          }
      }
    );
  }
}
