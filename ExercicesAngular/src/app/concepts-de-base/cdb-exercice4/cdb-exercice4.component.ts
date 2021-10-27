import { Component, OnInit } from '@angular/core';
import { isNumeric } from "rxjs/internal-compatibility";
import { toNumbers } from "@angular/compiler-cli/src/diagnostics/typescript_version";

@Component( {
  selector: 'app-cdb-exercice4',
  templateUrl: './cdb-exercice4.component.html',
  styleUrls: [ './cdb-exercice4.component.css' ]
} )
export class CdbExercice4Component implements OnInit
{
  value: string = "";

  TYPES =
    {
      EVEN: 1,
      ODD: 2,
      NaN: 3,
      EMPTY: 4
    }

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

  determineTypeOfValue()
  {
    if ( this.value === "" )
    {
      return this.TYPES.EMPTY;
    }

    const potentialNumber = Number( this.value );

    if ( potentialNumber || potentialNumber === 0 )
    {
      return potentialNumber % 2 === 0 ? this.TYPES.EVEN : this.TYPES.ODD;
    }

    return this.TYPES.NaN;
  }
}
