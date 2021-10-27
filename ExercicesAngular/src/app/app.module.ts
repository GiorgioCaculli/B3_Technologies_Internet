import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ConceptsDeBaseComponent } from './concepts-de-base/concepts-de-base.component';
import { CdbExercice1Component } from './concepts-de-base/cdb-exercice1/cdb-exercice1.component';
import { CdbExercice2Component } from './concepts-de-base/cdb-exercice2/cdb-exercice2.component';
import { CdbExercice3Component } from './concepts-de-base/cdb-exercice3/cdb-exercice3.component';
import { CdbExercice4Component } from './concepts-de-base/cdb-exercice4/cdb-exercice4.component';
import { CdbExercice5Component } from './concepts-de-base/cdb-exercice5/cdb-exercice5.component';
import { CdbExercice6Component } from './concepts-de-base/cdb-exercice6/cdb-exercice6.component';
import { CdbExercice7Component } from './concepts-de-base/cdb-exercice7/cdb-exercice7.component';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { FormulairesComponent } from './formulaires/formulaires.component';
import { FormulairesExercice1Component } from './formulaires/formulaires-exercice1/formulaires-exercice1.component';
import { FormulairesExercice2Component } from './formulaires/formulaires-exercice2/formulaires-exercice2.component';
import { FormulairesExercice3Component } from './formulaires/formulaires-exercice3/formulaires-exercice3.component';
import { ServicesComponent } from './services/services.component';
import { ServicesExercice1Component } from './services/services-exercice1/services-exercice1.component';
import { ServicesExercice2Component } from './services/services-exercice2/services-exercice2.component';
import { LoginComponent } from './services/services-exercice2/login/login.component';
import { HeaderComponent } from './services/services-exercice2/header/header.component';
import { CommunicationComponent } from './communication/communication.component';
import { CommunicationExercice1Component } from './communication/communication-exercice1/communication-exercice1.component';
import { CommunicationExercice2Component } from './communication/communication-exercice2/communication-exercice2.component';
import { CommunicationExercice3Component } from './communication/communication-exercice3/communication-exercice3.component';
import { ParentExercice1Component } from './communication/communication-exercice1/parent-exercice1/parent-exercice1.component';
import { ChildInputExercice1Component } from './communication/communication-exercice1/parent-exercice1/child-input-exercice1/child-input-exercice1.component';
import { ParentExercice2Component } from './communication/communication-exercice2/parent-exercice2/parent-exercice2.component';
import { ChildOutputExercice2Component } from './communication/communication-exercice2/parent-exercice2/child-output-exercice2/child-output-exercice2.component';
import { ParentExercice3Component } from './communication/communication-exercice3/parent-exercice3/parent-exercice3.component';
import { ChildExercice3Component } from './communication/communication-exercice3/parent-exercice3/child-exercice3/child-exercice3.component';
import { CommunicationExercice4Component } from './communication/communication-exercice4/communication-exercice4.component';
import { CustomerListExercice4Component } from './communication/communication-exercice4/customer-list-exercice4/customer-list-exercice4.component';
import { CustomerContainerExercice4Component } from './communication/communication-exercice4/customer-container-exercice4/customer-container-exercice4.component';

@NgModule( {
  declarations: [
    AppComponent,
    ConceptsDeBaseComponent,
    CdbExercice1Component,
    CdbExercice2Component,
    CdbExercice3Component,
    CdbExercice4Component,
    CdbExercice5Component,
    CdbExercice6Component,
    CdbExercice7Component,
    FormulairesComponent,
    FormulairesExercice1Component,
    FormulairesExercice2Component,
    FormulairesExercice3Component,
    ServicesComponent,
    ServicesExercice1Component,
    ServicesExercice2Component,
    LoginComponent,
    HeaderComponent,
    CommunicationComponent,
    CommunicationExercice1Component,
    CommunicationExercice2Component,
    CommunicationExercice3Component,
    ParentExercice1Component,
    ChildInputExercice1Component,
    ParentExercice2Component,
    ChildOutputExercice2Component,
    ParentExercice3Component,
    ChildExercice3Component,
    CommunicationExercice4Component,
    CustomerListExercice4Component,
    CustomerContainerExercice4Component,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [ AppComponent ]
} )
export class AppModule
{
}
