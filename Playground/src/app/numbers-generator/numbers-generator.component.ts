import { Component, OnInit } from '@angular/core';

@Component( {
  selector: 'app-numbers-generator',
  templateUrl: './numbers-generator.component.html',
  styleUrls: [ './numbers-generator.component.css' ]
} )
export class NumbersGeneratorComponent implements OnInit
{

  nums: number[] = [ 1, 2, 3 ];
  times: number = 10;

  constructor()
  {
  }

  addRandomNumbers( times: number )
  {
    for ( let i = 0; i < times; i++ )
    {
      this.nums.push( Math.random() );
    }
  }

  ngOnInit(): void
  {
  }

}
