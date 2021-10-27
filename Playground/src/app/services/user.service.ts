import { Injectable } from '@angular/core';
import { Observable, of } from "rxjs";

export interface User
{
  pseudo: string;
  email: string;
}

@Injectable( {
  providedIn: 'root'
} )
export class UserService
{

  constructor()
  {
  }

  public getUsers(): Observable<User[]>
  {
    return of( [
      {
        pseudo: "Roger",
        email: "roger@helha.be"
      },
      {
        pseudo: "Smourbif",
        email: "smourbif@helha.be"
      }
    ] );
  }
}
