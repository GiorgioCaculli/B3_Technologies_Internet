import { Component, OnInit } from '@angular/core';
import { Personne } from "./personne";
import { PersonnesService } from "./personnes.service";

@Component({
  selector: 'app-personnes',
  templateUrl: './personnes.component.html',
  styleUrls: ['./personnes.component.css']
})
export class PersonnesComponent implements OnInit {

  personnes: Personne[] = [];

  constructor(private personnesService: PersonnesService) { }

  ngOnInit(): void {
    this.getAllPersonnes();
  }

  private getAllPersonnes()
  {
    this.personnesService.getAll().subscribe(personnes => this.personnes = personnes);
  }

  sendPersonne( personne: Personne )
  {
    this.personnesService.create(personne).subscribe(personne => this.personnes.push( personne ));
  }
}
