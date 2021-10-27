import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ParentExercice3Component } from './parent-exercice3.component';

describe( 'ParentExercice3Component', () =>
{
  let component: ParentExercice3Component;
  let fixture: ComponentFixture<ParentExercice3Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ ParentExercice3Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( ParentExercice3Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
