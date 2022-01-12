import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Parcours } from "../parcours";

@Component({
  selector: 'app-parcours-form',
  templateUrl: './parcours-form.component.html',
  styleUrls: ['./parcours-form.component.css']
})
export class ParcoursFormComponent implements OnInit {
  @Output()
  parcoursCreated: EventEmitter<Parcours> = new EventEmitter<Parcours>();

  form: FormGroup = this.fb.group(
    {
      nom: [ '', Validators.required ],
      tempsMarcheMinutes: [ 0, Validators.required ],
      tempsCourseMinutes: [ 0, Validators.required ]
    }
  )

  constructor(private fb: FormBuilder) { }

  ngOnInit(): void {
  }

  emitPersonneCreation()
  {
    this.parcoursCreated.next(
      {
        nom: this.form.value.nom,
        tempsMarcheMinutes: this.form.value.tempsMarcheMinutes,
        tempsCourseMinutes: this.form.value.tempsCourseMinutes
      }
    )
    alert('Le parcours a ete ajoute avec succes!');
    location.reload();
  }
}
