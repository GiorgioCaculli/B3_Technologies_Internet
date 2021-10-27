import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormulairesExercice3Component } from './formulaires-exercice3.component';

describe( 'FormulairesExercice3Component', () =>
{
  let component: FormulairesExercice3Component;
  let fixture: ComponentFixture<FormulairesExercice3Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ FormulairesExercice3Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( FormulairesExercice3Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
