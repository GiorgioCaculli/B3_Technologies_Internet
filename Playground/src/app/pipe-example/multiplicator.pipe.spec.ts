import { MultiplicatorPipe } from './multiplicator.pipe';

describe( 'MultiplicatorPipe', () =>
{
  it( 'create an instance', () =>
  {
    const pipe = new MultiplicatorPipe();
    expect( pipe ).toBeTruthy();
  } );
} );
