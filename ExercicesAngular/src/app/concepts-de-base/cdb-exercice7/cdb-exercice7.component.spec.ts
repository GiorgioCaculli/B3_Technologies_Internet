import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CdbExercice7Component } from './cdb-exercice7.component';

describe( 'CdbExercice7Component', () =>
{
  let component: CdbExercice7Component;
  let fixture: ComponentFixture<CdbExercice7Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ CdbExercice7Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( CdbExercice7Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
