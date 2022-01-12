import { Component, OnInit } from '@angular/core';
import { Parcours } from "./parcours";
import { ParcoursService } from "./parcours.service";
import { Personne } from "../personnes/personne";
import { PersonnesService } from "../personnes/personnes.service";
import { Session } from "../sessions/session";
import { SessionsService } from "../sessions/sessions.service";

@Component({
  selector: 'app-parcours',
  templateUrl: './parcours.component.html',
  styleUrls: ['./parcours.component.css']
})
export class ParcoursComponent implements OnInit {
  parcours: Parcours[] = [];
  personnes: Personne[] = [];
  sessions: Session[] = [];

  constructor(private personnesService: PersonnesService, private parcoursService: ParcoursService, private sessionService: SessionsService) { }

  ngOnInit(): void {
    this.getAllParcours();
    this.getAllPersonnes();
    this.getAllSessions();
  }

  private getAllPersonnes()
  {
    this.personnesService.getAll().subscribe(personnes => this.personnes = personnes);
  }

  private getAllParcours()
  {
    this.parcoursService.getAll().subscribe(parcours => this.parcours = parcours);
  }

  private getAllSessions()
  {
    this.sessionService.getAll().subscribe(sessions => this.sessions = sessions);
  }

  sendParcours( parcours: Parcours )
  {
    this.parcoursService.create(parcours).subscribe(parcours => this.parcours.push( parcours ));
  }

  sendSession( session: Session )
  {
    this.sessionService.create(session).subscribe(sessions => this.sessions.push(sessions))
  }
}
