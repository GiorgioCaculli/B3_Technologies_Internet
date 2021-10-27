import { Injectable } from '@angular/core';

@Injectable( {
  providedIn: 'root'
} )
export class AuthService
{
  constructor()
  {
  }

  private _emailUserConnected: string = "";

  get emailUserConnected(): string
  {
    return this._emailUserConnected;
  }

  authenticate( email: string, password: string )
  {
    this._emailUserConnected = email;
  }
}
