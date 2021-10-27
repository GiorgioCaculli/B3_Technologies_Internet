import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CommunicationExercice1Component } from './communication-exercice1.component';

describe( 'CommunicationExercice1Component', () =>
{
  let component: CommunicationExercice1Component;
  let fixture: ComponentFixture<CommunicationExercice1Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ CommunicationExercice1Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( CommunicationExercice1Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
