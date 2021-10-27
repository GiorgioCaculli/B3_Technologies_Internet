import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ServicesExercice1Component } from './services-exercice1.component';

describe( 'ServicesExercice1Component', () =>
{
  let component: ServicesExercice1Component;
  let fixture: ComponentFixture<ServicesExercice1Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ ServicesExercice1Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( ServicesExercice1Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
