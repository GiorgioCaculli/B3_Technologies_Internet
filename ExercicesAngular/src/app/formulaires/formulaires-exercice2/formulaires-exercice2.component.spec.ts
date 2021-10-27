import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormulairesExercice2Component } from './formulaires-exercice2.component';

describe( 'FormulairesExercice2Component', () =>
{
  let component: FormulairesExercice2Component;
  let fixture: ComponentFixture<FormulairesExercice2Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ FormulairesExercice2Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( FormulairesExercice2Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
