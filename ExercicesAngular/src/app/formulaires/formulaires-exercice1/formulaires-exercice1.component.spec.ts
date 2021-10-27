import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormulairesExercice1Component } from './formulaires-exercice1.component';

describe( 'FormulairesExercice1Component', () =>
{
  let component: FormulairesExercice1Component;
  let fixture: ComponentFixture<FormulairesExercice1Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ FormulairesExercice1Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( FormulairesExercice1Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
