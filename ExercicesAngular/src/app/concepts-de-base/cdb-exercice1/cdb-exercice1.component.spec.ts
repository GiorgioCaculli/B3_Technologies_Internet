import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CdbExercice1Component } from './cdb-exercice1.component';

describe( 'CdbExercice1Component', () =>
{
  let component: CdbExercice1Component;
  let fixture: ComponentFixture<CdbExercice1Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ CdbExercice1Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( CdbExercice1Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
