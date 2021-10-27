import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from "@angular/forms";
import { environment } from "../../environments/environment";

@Component( {
  selector: 'app-reactive-forms',
  templateUrl: './reactive-forms.component.html',
  styleUrls: [ './reactive-forms.component.css' ]
} )
export class ReactiveFormsComponent implements OnInit
{
  form: FormGroup = this.fb.group(
    {
      bestCourse: this.fb.control( "", Validators.required ),
      age: this.fb.control( 0, [
        Validators.min( 0 ),
        Validators.required
      ] ),
      /*sports: this.fb.array( [] )*/
    } );

  constructor( private fb: FormBuilder )
  {
  }

  get controls()
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

  autocomplete()
  {
    if ( environment.production )
    {
      return;
    }
    this.form.setValue(
      {
        bestCourse: "Roger" + Math.round( Math.random() * 100 ),
        age: Math.round( Math.random() * 100 )
      } );

    /*
    this.form.patchValue(
      {
        age: 22
      });
     */
  }
}
