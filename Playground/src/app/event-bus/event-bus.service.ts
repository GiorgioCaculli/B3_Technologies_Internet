import { Injectable } from '@angular/core';
import { Observable, pipe, Subject } from "rxjs";
import { EventData } from "./event-data";
import { EventType } from "./event-type";
import { filter, map } from "rxjs/operators";

@Injectable( {
  providedIn: 'root'
} )
export class EventBusService
{

  private _bus: Subject<EventData> = new Subject<EventData>();

  constructor()
  {
  }

  when( eventType: EventType ): Observable<any>
  {
    return this._bus.pipe(
      filter( event => event.type === eventType ),
      map( event => event.data )
    );
  }

  next( event: EventData )
  {
    this._bus.next( event );
  }
}
