import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { EventBusService } from "../../../event-bus/event-bus.service";
import { EventType } from "../../../event-bus/event-type";

@Component( {
  selector: 'app-child-output',
  templateUrl: './child-output.component.html',
  styleUrls: [ './child-output.component.css' ]
} )
export class ChildOutputComponent implements OnInit
{
  @Output()
  numbersChange: EventEmitter<number[]> = new EventEmitter<number[]>();

  constructor( private eventBus: EventBusService )
  {
  }

  ngOnInit(): void
  {
  }

  generateNumbers(): number[]
  {
    let numbers = [];
    for ( let i = 0; i < 10; i++ )
    {
      numbers.push( Math.round( Math.random() * 100 ) );
    }
    return numbers;
  }

  emitNumbers()
  {
    const localNums: number[] = this.generateNumbers();
    this.numbersChange.next( this.generateNumbers() );
    this.eventBus.next(
      {
        type: EventType.MESSAGE_DISPLAYED,
        data: localNums
      }
    );
  }
}
