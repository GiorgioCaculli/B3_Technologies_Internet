import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { NumbersGeneratorComponent } from './numbers-generator/numbers-generator.component';
import { FormsComponent } from './forms/forms.component';
import { ReactiveFormsComponent } from './reactive-forms/reactive-forms.component';
import { ServicesComponent } from './services/services.component';
import { Child1Component } from './services/child1/child1.component';
import { Child2Component } from './services/child2/child2.component';
import { CommunicationComponent } from './communication/communication.component';
import { ParentComponent } from './communication/parent/parent.component';
import { ChildInputComponent } from './communication/parent/child-input/child-input.component';
import { ChildOutputComponent } from './communication/parent/child-output/child-output.component';
import { SizerComponent } from './communication/parent/sizer/sizer.component';
import { PipeExampleComponent } from './pipe-example/pipe-example.component';
import { MultiplicatorPipe } from './pipe-example/multiplicator.pipe';
import { AppRoutingModule } from "./app-routing.module";
import { NotFoundComponent } from './not-found/not-found.component';

@NgModule( {
  declarations: [
    AppComponent,
    NumbersGeneratorComponent,
    FormsComponent,
    ReactiveFormsComponent,
    ServicesComponent,
    Child1Component,
    Child2Component,
    CommunicationComponent,
    ParentComponent,
    ChildInputComponent,
    ChildOutputComponent,
    SizerComponent,
    PipeExampleComponent,
    MultiplicatorPipe,
    NotFoundComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [ AppComponent ]
} )
export class AppModule
{
}
