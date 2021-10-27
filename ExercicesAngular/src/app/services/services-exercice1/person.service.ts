import { Injectable } from '@angular/core';
import { Observable, of } from "rxjs";

export interface Person
{
  firstName: string;
  lastName: string;
}

@Injectable( {
  providedIn: 'root'
} )
export class PersonService
{

  constructor()
  {
  }

  public getPersons(): Observable<Person[]>
  {
    return of( [
      {
        firstName: "Giorgio",
        lastName: "Caculli"
      },
      {
        firstName: "Tanguy",
        lastName: "Taminiau"
      },
      {
        firstName: "Guillaume",
        lastName: "Lambert"
      }
    ] )
  }
}
