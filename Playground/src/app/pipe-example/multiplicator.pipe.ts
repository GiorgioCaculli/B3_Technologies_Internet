import { Pipe, PipeTransform } from '@angular/core';

@Pipe( {
  name: 'multiplicator'
} )
export class MultiplicatorPipe implements PipeTransform
{

  transform( value: number, mult: number ): number
  {
    return value * mult;
  }

}
