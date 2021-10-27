import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component( {
  selector: 'app-sizer',
  templateUrl: './sizer.component.html',
  styleUrls: [ './sizer.component.css' ]
} )
export class SizerComponent implements OnInit
{
  @Input()
  num: number = 0;
  @Output()
  numChange: EventEmitter<number> = new EventEmitter<number>();

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

  increment()
  {
    this.num++;
    this.numChange.next( this.num );
  }

  decrement()
  {
    this.num--;
    this.numChange.next( this.num );
  }
}
