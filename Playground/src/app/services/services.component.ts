import { Component, OnInit } from '@angular/core';
import { NumberIncrementService } from "./number-increment.service";
import { User, UserService } from "./user.service";

@Component( {
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: [ './services.component.css' ]
} )
export class ServicesComponent implements OnInit
{

  users: User[] = [];

  constructor(
    private numberService: NumberIncrementService,
    private userService: UserService
  )
  {
  }

  ngOnInit(): void
  {
    /* getUsers() RENVOIE UN FLUX DE DONNEES - PAS UNE LISTE D'UTILISATEURS */
    this.userService.getUsers().subscribe( usersFromServer => this.users = usersFromServer );
  }

  increment()
  {
    this.numberService.increment();
  }
}
