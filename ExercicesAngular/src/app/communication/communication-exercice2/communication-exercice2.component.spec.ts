import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CommunicationExercice2Component } from './communication-exercice2.component';

describe( 'CommunicationExercice2Component', () =>
{
  let component: CommunicationExercice2Component;
  let fixture: ComponentFixture<CommunicationExercice2Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ CommunicationExercice2Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( CommunicationExercice2Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
