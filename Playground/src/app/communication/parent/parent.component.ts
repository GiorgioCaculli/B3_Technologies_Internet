import { Component, OnInit } from '@angular/core';

@Component( {
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: [ './parent.component.css' ]
} )
export class ParentComponent implements OnInit
{
  nums: Number[] = [];
  num: number = 0;

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

  saveNumbers( nums: number[] )
  {
    this.nums = nums;
  }
}
