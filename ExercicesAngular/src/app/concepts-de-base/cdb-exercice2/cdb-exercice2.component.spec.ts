import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CdbExercice2Component } from './cdb-exercice2.component';

describe( 'CdbExercice2Component', () =>
{
  let component: CdbExercice2Component;
  let fixture: ComponentFixture<CdbExercice2Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ CdbExercice2Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( CdbExercice2Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
