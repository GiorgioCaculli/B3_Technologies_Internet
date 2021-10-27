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
  title = 'ExercicesAngular';

  constructor( private eventBus: EventBusService )
  {
  }

  ngOnInit()
  {
  }
}
