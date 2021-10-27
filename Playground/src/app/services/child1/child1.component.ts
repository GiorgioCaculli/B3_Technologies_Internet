import { Component, OnInit } from '@angular/core';
import { NumberIncrementService } from "../number-increment.service";

@Component( {
  selector: 'app-child1',
  templateUrl: './child1.component.html',
  styleUrls: [ './child1.component.css' ]
} )
export class Child1Component implements OnInit
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
