import { Component, OnInit } from '@angular/core';

@Component( {
  selector: 'app-cdb-exercice3',
  templateUrl: './cdb-exercice3.component.html',
  styleUrls: [ './cdb-exercice3.component.css' ]
} )
export class CdbExercice3Component implements OnInit
{

  counter: number = 0;
  value: number = 1;

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

  increment()
  {
    this.counter += this.value;
  }
}
