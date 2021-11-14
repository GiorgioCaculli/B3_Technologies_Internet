USE todos;

CREATE TABLE todo_values(
    id INTEGER IDENTITY PRIMARY KEY,
    title VARCHAR(200) NOT NULL,
    is_done BIT NOT NULL
)