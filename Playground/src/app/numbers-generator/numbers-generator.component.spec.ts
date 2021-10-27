import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NumbersGeneratorComponent } from './numbers-generator.component';

describe( 'NumbersGeneratorComponent', () =>
{
  let component: NumbersGeneratorComponent;
  let fixture: ComponentFixture<NumbersGeneratorComponent>;

  beforeEach( async () =>
  {
    await TestBed.configureTestingModule( {
      declarations: [ NumbersGeneratorComponent ]
    } )
      .compileComponents();
  } );

  beforeEach( () =>
  {
    fixture = TestBed.createComponent( NumbersGeneratorComponent );
    component = fixture.componentInstance;
    fixture.detectChanges();
  } );

  it( 'should create', () =>
  {
    expect( component ).toBeTruthy();
  } );
} );
