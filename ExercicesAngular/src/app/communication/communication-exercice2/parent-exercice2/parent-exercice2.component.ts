import { Component, OnInit } from '@angular/core';

@Component( {
  selector: 'app-parent-exercice2',
  templateUrl: './parent-exercice2.component.html',
  styleUrls: [ './parent-exercice2.component.css' ]
} )
export class ParentExercice2Component implements OnInit
{
  randomNum: number = 0;

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

  saveRandomNum( randomNum: number )
  {
    this.randomNum = randomNum;
  }
}
