import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChildExercice3Component } from './child-exercice3.component';

describe( 'ChildExercice3Component', () =>
{
  let component: ChildExercice3Component;
  let fixture: ComponentFixture<ChildExercice3Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ ChildExercice3Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( ChildExercice3Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
