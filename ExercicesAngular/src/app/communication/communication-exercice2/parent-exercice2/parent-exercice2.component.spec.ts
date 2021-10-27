import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ParentExercice2Component } from './parent-exercice2.component';

describe( 'ParentExercice2Component', () =>
{
  let component: ParentExercice2Component;
  let fixture: ComponentFixture<ParentExercice2Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ ParentExercice2Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( ParentExercice2Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
