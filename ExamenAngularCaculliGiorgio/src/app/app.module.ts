import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatToolbarModule } from "@angular/material/toolbar";
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { MatSelectModule } from "@angular/material/select";
import { RouterModule } from "@angular/router";
import { MatButtonModule } from "@angular/material/button";
import { NotFoundComponent } from './not-found/not-found.component';
import { HomeComponent } from './home/home.component';
import { AppRoutingModule } from "./app-routing.module";
import { PersonnesComponent } from './personnes/personnes.component';
import { ParcoursComponent } from './parcours/parcours.component';
import { SessionsComponent } from './sessions/sessions.component';
import { HttpClient, HttpClientModule } from "@angular/common/http";
import { MatTableModule } from "@angular/material/table";
import { MatIconModule } from "@angular/material/icon";
import { PersonneFormComponent } from './personnes/personne-form/personne-form.component';
import { ReactiveFormsModule } from "@angular/forms";
import { MatInputModule } from "@angular/material/input";
import { MatCardModule } from "@angular/material/card";
import { PersonneListComponent } from './personnes/personne-list/personne-list.component';
import { ParcoursListComponent } from './parcours/parcours-list/parcours-list.component';
import { ParcoursFormComponent } from './parcours/parcours-form/parcours-form.component';
import { SessionsListComponent } from './sessions/sessions-list/sessions-list.component';
import { SessionsFormComponent } from './sessions/sessions-form/sessions-form.component';

@NgModule({
  declarations: [
    AppComponent,
    NotFoundComponent,
    HomeComponent,
    PersonnesComponent,
    ParcoursComponent,
    SessionsComponent,
    PersonneFormComponent,
    PersonneListComponent,
    ParcoursListComponent,
    ParcoursFormComponent,
    SessionsListComponent,
    SessionsFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatToolbarModule,
    FontAwesomeModule,
    MatSelectModule,
    MatButtonModule,
    MatTableModule,
    MatIconModule,
    ReactiveFormsModule,
    MatInputModule,
    MatCardModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
