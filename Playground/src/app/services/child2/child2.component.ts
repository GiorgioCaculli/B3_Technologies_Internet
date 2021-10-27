import { Component, OnInit } from '@angular/core';
import { NumberIncrementService } from "../number-increment.service";

@Component( {
  selector: 'app-child2',
  templateUrl: './child2.component.html',
  styleUrls: [ './child2.component.css' ]
} )
export class Child2Component implements OnInit
{

  constructor( private numberService: NumberIncrementService )
  {
  }

  get number()
  {
    return this.numberService.number;
  }

  ngOnInit(): void
  {
  }
}
