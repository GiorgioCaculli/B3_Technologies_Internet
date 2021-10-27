import { Component, OnInit } from '@angular/core';
import { Todo } from "../todo";
import { TodoService } from "../todo.service";

@Component( {
  selector: 'app-todo-container',
  templateUrl: './todo-container.component.html',
  styleUrls: [ './todo-container.component.css' ]
} )
export class TodoContainerComponent implements OnInit
{
  todos: Todo[] = [];

  constructor( private todoService: TodoService )
  {
  }

  ngOnInit(): void
  {
    this.getAllTodos();
    //this.mockTodos();
  }

  sendTodo( todo: Todo )
  {
    this.todoService.create( todo ).subscribe( todo => this.todos.push( todo ) );
  }

  private mockTodos()
  {
    this.todos =
      [
        {
          id: 1,
          title: "Chasser le Smourbif",
          isDone: false
        },
        {
          id: 2,
          title: "Manger une pizza",
          isDone: true
        }
      ]
  }

  deleteTodo( todoDeleted: Todo )
  {
    this.todoService.delete( todoDeleted.id || -1 ).subscribe( () =>
    {
      for ( let i = 0; i < this.todos.length; i++ )
      {
        const todo = this.todos[ i ];
        if( todoDeleted.id === todo.id )
        {
          this.todos.splice( i, 1 );
          break;
        }
      }
    });
  }

  private getAllTodos()
  {
    this.todoService.getAll().subscribe( todos => this.todos = todos );
  }

  updateTodo( todo: Todo )
  {
    this.todoService.update( todo.id || -1, todo ).subscribe();
  }
}
