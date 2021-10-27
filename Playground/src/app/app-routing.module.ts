import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from "@angular/router";
import { FormsComponent } from "./forms/forms.component";
import { PipeExampleComponent } from "./pipe-example/pipe-example.component";
import { NotFoundComponent } from "./not-found/not-found.component";

const routes: Routes =
  [
    {
      path: '', pathMatch: 'full', redirectTo: 'form'
    },
    {
      path: 'form', component: FormsComponent
    },
    {
      path: 'pipe', component: PipeExampleComponent
    },
    {
      path: '**', component: NotFoundComponent
    }
  ];

@NgModule( {
  imports:
    [
      RouterModule.forRoot( routes )
    ],
  exports:
    [
      RouterModule
    ]
} )
export class AppRoutingModule
{
}
