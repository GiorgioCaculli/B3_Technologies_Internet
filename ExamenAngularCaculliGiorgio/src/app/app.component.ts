import { Component } from '@angular/core';
import { faHome, faUser, faMap, faListUl } from "@fortawesome/free-solid-svg-icons";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ExamenAngularCaculliGiorgio';
  faHomeSolid = faHome;
  faUserSolid = faUser;
  faMapSolid = faMap;
  faListUlSolid = faListUl;
}
