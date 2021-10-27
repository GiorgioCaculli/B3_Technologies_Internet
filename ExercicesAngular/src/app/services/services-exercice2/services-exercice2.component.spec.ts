import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ServicesExercice2Component } from './services-exercice2.component';

describe( 'ServicesExercice2Component', () =>
{
  let component: ServicesExercice2Component;
  let fixture: ComponentFixture<ServicesExercice2Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ ServicesExercice2Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( ServicesExercice2Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
