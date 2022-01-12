import { Component, Input, OnInit } from '@angular/core';
import { Personne } from "../personne";

@Component({
  selector: 'app-personne-list',
  templateUrl: './personne-list.component.html',
  styleUrls: ['./personne-list.component.css']
})
export class PersonneListComponent implements OnInit {
  @Input()
  personnes: Personne[] = [];
  displayedColumns: string[] = ['id', 'nom', 'prenom'];
  dataSource = this.personnes;

  constructor() { }

  ngOnInit(): void {
  }

}
