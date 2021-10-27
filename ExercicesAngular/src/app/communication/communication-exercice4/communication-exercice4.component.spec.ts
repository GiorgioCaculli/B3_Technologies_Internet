import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CommunicationExercice4Component } from './communication-exercice4.component';

describe( 'CommunicationExercice4Component', () =>
{
  let component: CommunicationExercice4Component;
  let fixture: ComponentFixture<CommunicationExercice4Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ CommunicationExercice4Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( CommunicationExercice4Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
