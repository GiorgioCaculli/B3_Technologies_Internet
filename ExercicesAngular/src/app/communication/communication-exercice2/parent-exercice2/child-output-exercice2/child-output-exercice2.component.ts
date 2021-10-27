import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component( {
  selector: 'app-child-output-exercice2',
  templateUrl: './child-output-exercice2.component.html',
  styleUrls: [ './child-output-exercice2.component.css' ]
} )
export class ChildOutputExercice2Component implements OnInit
{
  @Output()
  randomNumChange: EventEmitter<number> = new EventEmitter<number>();

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

  private generateRandomNum(): number
  {
    return Math.round( Math.random() * 100 );
  }

  emitRandomNumber()
  {
    this.randomNumChange.next( this.generateRandomNum() );
  }
}
