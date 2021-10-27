import { Component, OnInit } from '@angular/core';
import { Person, PersonService } from "./person.service";
import { Observable } from "rxjs";

@Component( {
  selector: 'app-services-exercice1',
  templateUrl: './services-exercice1.component.html',
  styleUrls: [ './services-exercice1.component.css' ]
} )
export class ServicesExercice1Component implements OnInit
{
  persons: Person[] = [];

  constructor( private personService: PersonService )
  {
  }

  get persons$(): Observable<Person[]>
  {
    return this.personService.getPersons();
  }

  ngOnInit(): void
  {
    this.persons$.subscribe( personsFromServer => this.persons = personsFromServer )
  }

}
