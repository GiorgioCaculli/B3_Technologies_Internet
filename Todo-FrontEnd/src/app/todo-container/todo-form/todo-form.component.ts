import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { Todo } from "../../todo";

@Component( {
  selector: 'app-todo-form',
  templateUrl: './todo-form.component.html',
  styleUrls: [ './todo-form.component.css' ]
} )
export class TodoFormComponent implements OnInit
{
  @Output()
  todoCreated: EventEmitter<Todo> = new EventEmitter<Todo>();

  form: FormGroup = this.fb.group(
    {
      title: [ '', Validators.required ]
    }
  )

  constructor( private fb: FormBuilder)
  {
  }

  ngOnInit(): void
  {
  }

  emitTodoCreation()
  {
    this.todoCreated.next(
      {
        title: this.form.value.title
      }
    )
  }
}
