import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomerListExercice4Component } from './customer-list-exercice4.component';

describe( 'CustomerListExercice4Component', () =>
{
  let component: CustomerListExercice4Component;
  let fixture: ComponentFixture<CustomerListExercice4Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ CustomerListExercice4Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( CustomerListExercice4Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
