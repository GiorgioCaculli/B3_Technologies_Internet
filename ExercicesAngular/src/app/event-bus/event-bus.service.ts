import { Injectable } from '@angular/core';
import { EventType } from "./event-type";
import { EventData } from "./event-data";
import { Observable, Subject } from "rxjs";
import { filter, map } from "rxjs/operators";

@Injectable( {
  providedIn: 'root'
} )
export class EventBusService
{
  private _bus: Subject< EventData > = new Subject< EventData >();

  constructor()
  {
  }

  when( eventType: EventType ): Observable< any >
  {
    return this._bus.asObservable().pipe(
      filter( event => event.type === eventType ),
      map( event => event.data )
    );
  }


  next( eventData: EventData )
  {
    this._bus.next( eventData );
  }
}
