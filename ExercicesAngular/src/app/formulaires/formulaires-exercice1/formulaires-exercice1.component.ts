import { Component, OnInit } from '@angular/core';

@Component( {
  selector: 'app-formulaires-exercice1',
  templateUrl: './formulaires-exercice1.component.html',
  styleUrls: [ './formulaires-exercice1.component.css' ]
} )
export class FormulairesExercice1Component implements OnInit
{

  user =
    {
      username: "",
      password: ""
    }

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

  sendData()
  {
    console.log( this.user )
  }
}
