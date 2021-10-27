import { Component, OnInit } from '@angular/core';

@Component( {
  selector: 'app-cdb-exercice5',
  templateUrl: './cdb-exercice5.component.html',
  styleUrls: [ './cdb-exercice5.component.css' ]
} )

export class CdbExercice5Component implements OnInit
{
  computers: Computer[] = [
    {
      name: "AlienHELHa",
      price: 10000,
      isPowerful: true
    },
    {
      name: "Lenoto",
      price: 500,
      isPowerful: false
    },
    {
      name: "iPasteque",
      price: 2500,
      isPowerful: true
    },
  ];
  pc: IObjectInfo = new Computer( "test", 12.5, true );

  constructor()
  {
  }

  ngOnInit(): void
  {
  }
}

interface IObjectInfo
{
  name: string;
  price: number;
  isPowerful: boolean;
}

class Computer implements IObjectInfo
{
  isPowerful: boolean;
  name: string;
  price: number;

  constructor( name: string, price: number, isPowerful: boolean )
  {
    this.name = name;
    this.price = price;
    this.isPowerful = isPowerful;
  }
}
