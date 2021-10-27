import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ParentExercice1Component } from './parent-exercice1.component';

describe( 'ParentExercice1Component', () =>
{
  let component: ParentExercice1Component;
  let fixture: ComponentFixture<ParentExercice1Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ ParentExercice1Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( ParentExercice1Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
