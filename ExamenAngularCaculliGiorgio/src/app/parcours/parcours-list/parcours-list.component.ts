import { Component, Input, OnInit } from '@angular/core';
import { Personne } from "../../personnes/personne";
import { Parcours } from "../parcours";

@Component({
  selector: 'app-parcours-list',
  templateUrl: './parcours-list.component.html',
  styleUrls: ['./parcours-list.component.css']
})
export class ParcoursListComponent implements OnInit {
  @Input()
  parcours: Parcours[] = [];
  displayedColumns: string[] = ['id', 'nom', 'temps-marche-minutes', 'temps-course-minutes'];
  dataSource = this.parcours;

  constructor() { }

  ngOnInit(): void {
  }

}
