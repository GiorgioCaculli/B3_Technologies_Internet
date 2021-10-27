import { Component, OnInit } from '@angular/core';

@Component( {
  selector: 'app-forms',
  templateUrl: './forms.component.html',
  styleUrls: [ './forms.component.css' ]
} )
export class FormsComponent implements OnInit
{
  values =
    {
      bestCourse: "",
      age: 0
    };

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

  sendData()
  {
    console.log( this.values );
  }
}
