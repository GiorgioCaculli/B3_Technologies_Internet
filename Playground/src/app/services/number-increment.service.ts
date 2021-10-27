import { Injectable } from '@angular/core';

@Injectable( {
  providedIn: 'root'
} )
export class NumberIncrementService
{
  constructor()
  {
  }

  private _number: number = 0;

  get number(): number
  {
    return this._number;
  }

  increment()
  {
    this._number++;
  }
}
