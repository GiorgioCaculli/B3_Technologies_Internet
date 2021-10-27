import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component( {
  selector: 'app-child-exercice3',
  templateUrl: './child-exercice3.component.html',
  styleUrls: [ './child-exercice3.component.css' ]
} )
export class ChildExercice3Component implements OnInit
{
  @Input()
  name: string = "";
  @Output()
  nameChange: EventEmitter< string > = new EventEmitter< string >();

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

  emitNameChange()
  {
    this.nameChange.next( this.name );
  }
}
