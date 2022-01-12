import { Injectable } from '@angular/core';
import { environment } from "../../environments/environment";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Personne } from "./personne";

@Injectable({
  providedIn: 'root'
})
export class PersonnesService {
  private static readonly API_URL: string = environment.apiUrl + "/personnes";

  constructor(private httpClient: HttpClient) { }

  getAll(): Observable<Personne[]>
  {
    return this.httpClient.get<Personne[]>(PersonnesService.API_URL);
  }

  create( personne: Personne ): Observable<Personne>
  {
    return this.httpClient.post<Personne>(PersonnesService.API_URL, personne);
  }
}
