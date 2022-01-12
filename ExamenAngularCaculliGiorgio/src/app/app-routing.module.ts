import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from "@angular/router";
import { HomeComponent } from "./home/home.component";
import { NotFoundComponent } from "./not-found/not-found.component";
import { PersonnesComponent } from "./personnes/personnes.component";
import { ParcoursComponent } from "./parcours/parcours.component";
import { SessionsComponent } from "./sessions/sessions.component";
import { PersonneFormComponent } from "./personnes/personne-form/personne-form.component";

const routes: Routes =
  [
    {
      path: 'home', component: HomeComponent
    },
    {
      path: 'personnes', component: PersonnesComponent
    },
    {
      path: 'parcours', component: ParcoursComponent
    },
    {
      path: 'sessions', component: SessionsComponent
    },
    {
      path: '', pathMatch: 'full', redirectTo: 'home'
    },
    {
      path: '**', component: NotFoundComponent
    }
  ]


@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot( routes, { useHash: true } )
  ],
  exports:
  [
    RouterModule
  ]
})
export class AppRoutingModule { }
