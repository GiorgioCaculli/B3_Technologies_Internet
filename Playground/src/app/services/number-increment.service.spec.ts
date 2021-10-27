import { TestBed } from '@angular/core/testing';

import { NumberIncrementService } from './number-increment.service';

describe( 'NumberIncrementService', () =>
{
  let service: NumberIncrementService;

  beforeEach( () =>
  {
    TestBed.configureTestingModule( {} );
    service = TestBed.inject( NumberIncrementService );
  } );

  it( 'should be created', () =>
  {
    expect( service ).toBeTruthy();
  } );
} );
