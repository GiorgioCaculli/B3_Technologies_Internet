import { Component, OnInit } from '@angular/core';

@Component( {
  selector: 'app-parent-exercice1',
  templateUrl: './parent-exercice1.component.html',
  styleUrls: [ './parent-exercice1.component.css' ]
} )
export class ParentExercice1Component implements OnInit
{
  text: any;

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

  saveText( text: any )
  {
    this.text = text;
  }
}
