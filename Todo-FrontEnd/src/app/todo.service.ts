import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { Todo } from "./todo";
import { environment } from "../environments/environment";

@Injectable( {
  providedIn: 'root'
} )
export class TodoService
{
  private static readonly API_URL: string = environment.apiURL + "/todo";

  constructor( private httpClient: HttpClient )
  {
  }

  getAll(): Observable< Todo[] >
  {
    return this.httpClient.get< Todo[] >( TodoService.API_URL );
  }

  create( todo: Todo ): Observable<Todo>
  {
    return this.httpClient.post< Todo >( TodoService.API_URL, todo );
  }

  delete( id: number ): Observable< any >
  {
    return this.httpClient.delete( TodoService.API_URL + "/" + id );
  }

  update( id: number, todo: Todo ): Observable< any >
  {
    return this.httpClient.put( TodoService.API_URL + "/" + id, todo );
  }
}
