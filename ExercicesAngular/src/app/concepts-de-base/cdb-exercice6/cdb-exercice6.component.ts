import { Component, OnInit } from '@angular/core';

@Component( {
  selector: 'app-cdb-exercice6',
  templateUrl: './cdb-exercice6.component.html',
  styleUrls: [ './cdb-exercice6.component.css' ]
} )
export class CdbExercice6Component implements OnInit
{
  numberToDelete: number = 0;
  numbers: number[] =
    []

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

  generate()
  {
    this.numbers.splice( 0, this.numbers.length );
    for ( let i = 0; i < 100; i++ )
    {
      const num = Math.round( Math.random() * 100 );
      this.numbers.push( num );
    }
  }

  delete( numberToDelete: number )
  {
    this.numbers = this.numbers.filter( num => num !== numberToDelete );
  }
}
