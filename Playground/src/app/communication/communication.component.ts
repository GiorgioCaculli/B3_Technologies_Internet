import { Component, OnInit } from '@angular/core';
import { EventBusService } from "../event-bus/event-bus.service";
import { EventType } from "../event-bus/event-type";

@Component( {
  selector: 'app-communication',
  templateUrl: './communication.component.html',
  styleUrls: [ './communication.component.css' ]
} )
export class CommunicationComponent implements OnInit
{

  constructor( private eventBus: EventBusService )
  {
  }

  ngOnInit(): void
  {
    this.eventBus.next(
      {
        type: EventType.MESSAGE_DISPLAYED,
        data: "Mon premier message sur le bus de donnees"
      }
    );
  }

}
