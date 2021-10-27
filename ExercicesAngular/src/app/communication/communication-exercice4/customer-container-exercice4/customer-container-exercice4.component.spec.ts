import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomerContainerExercice4Component } from './customer-container-exercice4.component';

describe( 'CustomerContainerExercice4Component', () =>
{
  let component: CustomerContainerExercice4Component;
  let fixture: ComponentFixture<CustomerContainerExercice4Component>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ CustomerContainerExercice4Component ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( CustomerContainerExercice4Component );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
