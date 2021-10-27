import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { EventBusService } from "../../../event-bus/event-bus.service";
import { EventType } from "../../../event-bus/event-type";
import { CustomerCommunicationExercice4 } from "../customer-communication-exercice4";

@Component( {
  selector: 'app-customer-list-exercice4',
  templateUrl: './customer-list-exercice4.component.html',
  styleUrls: [ './customer-list-exercice4.component.css' ]
} )
export class CustomerListExercice4Component implements OnInit
{
  @Input()
  customers: CustomerCommunicationExercice4[] = [];
  @Output()
  customerDeleted: EventEmitter< CustomerCommunicationExercice4 > = new EventEmitter< CustomerCommunicationExercice4 >();

  constructor( private eventBus: EventBusService )
  {
  }

  ngOnInit(): void
  {
  }

  deleteCustomer( index: number )
  {
    const customer: CustomerCommunicationExercice4 = this.customers[ index ];
    this.customers.splice( index, 1 );

    this.eventBus.next
    (
      {
        type: EventType.CUSTOMER_DELETED,
        data: customer
      }
    );

    this.customerDeleted.next( customer );
  }
}
