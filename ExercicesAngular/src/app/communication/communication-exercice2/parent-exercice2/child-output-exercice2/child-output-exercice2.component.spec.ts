import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChildOutputExercice2Component } from './child-output-exercice2.component';

describe( 'ChildOutputExercice2Component', () =>
{
  let component: ChildOutputExercice2Component;
  let fixture: ComponentFixture<ChildOutputExercice2Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ ChildOutputExercice2Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( ChildOutputExercice2Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
