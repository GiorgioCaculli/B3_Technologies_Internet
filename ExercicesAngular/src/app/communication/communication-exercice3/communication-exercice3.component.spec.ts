import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CommunicationExercice3Component } from './communication-exercice3.component';

describe( 'CommunicationExercice3Component', () =>
{
  let component: CommunicationExercice3Component;
  let fixture: ComponentFixture<CommunicationExercice3Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ CommunicationExercice3Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( CommunicationExercice3Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
