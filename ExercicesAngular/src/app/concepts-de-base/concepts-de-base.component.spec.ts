import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConceptsDeBaseComponent } from './concepts-de-base.component';

describe( 'ConceptsDeBaseComponent', () =>
{
  let component: ConceptsDeBaseComponent;
  let fixture: ComponentFixture<ConceptsDeBaseComponent>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ ConceptsDeBaseComponent ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( ConceptsDeBaseComponent );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
