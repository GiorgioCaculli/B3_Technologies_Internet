import { Injectable } from '@angular/core';
import { environment } from "../../environments/environment";
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Parcours } from "./parcours";

@Injectable({
  providedIn: 'root'
})
export class ParcoursService {
  private static readonly API_URL: string = environment.apiUrl + "/parcours";

  constructor(private httpClient: HttpClient) { }

  getAll(): Observable<Parcours[]>
  {
    return this.httpClient.get<Parcours[]>(ParcoursService.API_URL);
  }

  create( parcours: Parcours ): Observable<Parcours>
  {
    return this.httpClient.post<Parcours>(ParcoursService.API_URL, parcours);
  }
}
