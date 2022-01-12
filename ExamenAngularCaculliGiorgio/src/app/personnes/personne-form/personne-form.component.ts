import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Personne } from "../personne";
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { PersonnesService } from "../personnes.service";

@Component({
  selector: 'app-personne-form',
  templateUrl: './personne-form.component.html',
  styleUrls: ['./personne-form.component.css']
})
export class PersonneFormComponent implements OnInit {
  @Output()
  personneCreated: EventEmitter<Personne> = new EventEmitter<Personne>();

  form: FormGroup = this.fb.group(
    {
      nom: [ '', Validators.required ],
      prenom: [ '', Validators.required ]
    }
  )

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
  }

  emitPersonneCreation()
  {
    this.personneCreated.next(
      {
        nom: this.form.value.nom,
        prenom: this.form.value.prenom
      }
    )
    alert('La personne a ete ajoutee avec succes!');
    location.reload();
  }
}
