import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChildInputExercice1Component } from './child-input-exercice1.component';

describe( 'ChildInputExercice1Component', () =>
{
  let component: ChildInputExercice1Component;
  let fixture: ComponentFixture<ChildInputExercice1Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ ChildInputExercice1Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( ChildInputExercice1Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
