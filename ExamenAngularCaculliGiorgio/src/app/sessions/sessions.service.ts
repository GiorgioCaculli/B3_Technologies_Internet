import { Injectable } from '@angular/core';
import { environment } from "../../environments/environment";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Session } from "./session";

@Injectable({
  providedIn: 'root'
})
export class SessionsService {
  private static readonly API_URL: string = environment.apiUrl + "/sessions";

  constructor(private httpClient: HttpClient) { }

  getAll(): Observable<Session[]>
  {
    return this.httpClient.get<Session[]>(SessionsService.API_URL);
  }

  create( session: Session ): Observable<Session>
  {
    return this.httpClient.post<Session>(SessionsService.API_URL, session);
  }
}
