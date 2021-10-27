import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CdbExercice3Component } from './cdb-exercice3.component';

describe( 'CdbExercice3Component', () =>
{
  let component: CdbExercice3Component;
  let fixture: ComponentFixture<CdbExercice3Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ CdbExercice3Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( CdbExercice3Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
