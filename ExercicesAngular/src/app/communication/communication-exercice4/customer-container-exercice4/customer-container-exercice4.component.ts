import { Component, OnDestroy, OnInit } from '@angular/core';
import { EventBusService } from "../../../event-bus/event-bus.service";
import { CustomerCommunicationExercice4 } from "../customer-communication-exercice4";
import { EventType } from "../../../event-bus/event-type";
import { Subscription } from "rxjs";

@Component( {
  selector: 'app-customer-container-exercice4',
  templateUrl: './customer-container-exercice4.component.html',
  styleUrls: [ './customer-container-exercice4.component.css' ]
} )
export class CustomerContainerExercice4Component implements OnInit, OnDestroy
{
  customers: CustomerCommunicationExercice4[] =
    [
      {
        firstName: "Giorgio",
        lastName: "Caculli"
      },
      {
        firstName: "Tanguy",
        lastName: "Taminiau"
      },
      {
        firstName: "Guillaume",
        lastName: "Lambert"
      }
    ];
  private customerDeletedSubscription: Subscription | any = null;

  constructor(private eventBus: EventBusService )
  {
  }

  ngOnInit(): void
  {
    this.customerDeletedSubscription =
    this.eventBus.when( EventType.CUSTOMER_DELETED ).subscribe( customer => console.log( customer ) );
  }

  ngOnDestroy(): void
  {
    this.customerDeletedSubscription?.unsubscribe();
  }

  logCustomerDeleted( customerCommunicationExercice4: CustomerCommunicationExercice4 )
  {
    console.log( customerCommunicationExercice4 );
  }
}
