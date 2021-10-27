import { Component, Input, OnInit } from '@angular/core';

@Component( {
  selector: 'app-child-input-exercice1',
  templateUrl: './child-input-exercice1.component.html',
  styleUrls: [ './child-input-exercice1.component.css' ]
} )
export class ChildInputExercice1Component implements OnInit
{
  @Input()
  text: string = "";

  constructor()
  {
  }

  ngOnInit(): void
  {
  }
}
