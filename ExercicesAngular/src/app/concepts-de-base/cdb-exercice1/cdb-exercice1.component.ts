import { Component, OnInit } from '@angular/core';

@Component( {
  selector: 'app-cdb-exercice1',
  templateUrl: './cdb-exercice1.component.html',
  styleUrls: [ './cdb-exercice1.component.css' ]
} )
export class CdbExercice1Component implements OnInit
{

  variable: string = "Variable";

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

}
