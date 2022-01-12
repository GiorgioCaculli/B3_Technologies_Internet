import { Component, Input, OnInit } from '@angular/core';
import { Session } from "../session";

@Component({
  selector: 'app-sessions-list',
  templateUrl: './sessions-list.component.html',
  styleUrls: ['./sessions-list.component.css']
})
export class SessionsListComponent implements OnInit {
  @Input()
  sessions: Session[] = [];
  displayedColumns: string[] = ['id', 'id-utilisateur', 'id-parcours', 'type', 'temps-minutes'];
  dataSource = this.sessions;

  constructor() { }

  ngOnInit(): void {
  }
}
