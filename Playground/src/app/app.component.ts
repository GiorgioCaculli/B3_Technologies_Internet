import { Component } from '@angular/core';
import { EventBusService } from "./event-bus/event-bus.service";
import { EventType } from "./event-bus/event-type";

@Component( {
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: [ './app.component.css' ]
} )
export class AppComponent
{
  title = 'Playground Funzies';
  variable: string = "haha";
  isDisplayed: boolean = false;
  bestRed: string = "crimson";
  count: number = 0;

  constructor( private eventBus: EventBusService )
  {
  }

  ngOnInit()
  {
    this.eventBus.when( EventType.MESSAGE_DISPLAYED ).subscribe( value => console.log( value ) );
  }

  toggleDisplay()
  {
    this.isDisplayed = !this.isDisplayed;
  }

  increment()
  {
    this.count++;
  }

  decrement()
  {
    this.count--;
  }
}
