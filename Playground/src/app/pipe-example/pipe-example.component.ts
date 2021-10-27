import { Component, OnInit } from '@angular/core';

@Component( {
  selector: 'app-pipe-example',
  templateUrl: './pipe-example.component.html',
  styleUrls: [ './pipe-example.component.css' ]
} )
export class PipeExampleComponent implements OnInit
{
  num: number = 0;

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

}
