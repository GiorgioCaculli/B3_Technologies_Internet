import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Session } from "../session";
import { Parcours } from "../../parcours/parcours";
import { Personne } from "../../personnes/personne";

@Component({
  selector: 'app-sessions-form',
  templateUrl: './sessions-form.component.html',
  styleUrls: ['./sessions-form.component.css']
})
export class SessionsFormComponent implements OnInit {
  @Input()
  parcours: Parcours[] = [];
  @Input()
  utilisateurs: Personne[] = [];
  @Output()
  sessionCreated: EventEmitter<Session> = new EventEmitter<Session>();

  form: FormGroup = this.fb.group(
    {
      idUtilisateur: [ 0, Validators.required ],
      idParcours: [ 0, Validators.required ],
      typeSession: [ '', Validators.required ],
      tempsMinutes: [ 0, Validators.required ]
    }
  )

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
  }

  emitSessionCreation()
  {
    this.sessionCreated.next(
      {
        idUtilisateur: this.form.value.idUtilisateur,
        idParcours: this.form.value.idParcours,
        typeSession: this.form.value.typeSession,
        tempsMinutes: this.form.value.tempsMinutes
      }
    )
    alert('La session a ete ajoutee avec succes!');
    location.reload();
  }
}
