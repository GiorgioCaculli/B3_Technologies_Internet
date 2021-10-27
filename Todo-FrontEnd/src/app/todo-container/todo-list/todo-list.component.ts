import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Todo } from "../../todo";

@Component( {
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: [ './todo-list.component.css' ]
} )
export class TodoListComponent implements OnInit
{
  @Output()
  todoDeleted: EventEmitter< Todo > = new EventEmitter< Todo >();
  @Output()
  todoChanged: EventEmitter< Todo > = new EventEmitter< Todo >();
  @Input()
  todos: Todo[] = [];

  constructor()
  {
  }

  ngOnInit(): void
  {
  }

  emitTodoDeletedByIndex( i: number )
  {
    this.todoDeleted.next( this.todos[ i ] );
  }

  emitTodoChanged( todo: Todo )
  {
    this.todoChanged.next( todo );
  }
}
