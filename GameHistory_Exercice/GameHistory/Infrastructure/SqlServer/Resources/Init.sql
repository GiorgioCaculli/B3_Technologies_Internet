IF EXISTS (SELECT * FROM sysobjects WHERE name='history_items' and xtype='U')
DROP TABLE history_items;

IF EXISTS (SELECT * FROM sysobjects WHERE name='users' and xtype='U')
DROP TABLE users;

IF EXISTS (SELECT * FROM sysobjects WHERE name='games' and xtype='U')
DROP TABLE games;

CREATE TABLE users(
    id INT IDENTITY PRIMARY KEY,
    first_name VARCHAR(200) NOT NULL,
    last_name VARCHAR(200) NOT NULL,
);

CREATE TABLE games(
    id INT IDENTITY PRIMARY KEY,
    name VARCHAR(200),
    minutes_for_completion INT NOT NULL
);

CREATE TABLE history_items(
    id INT IDENTITY PRIMARY KEY,
    user_id INT FOREIGN KEY REFERENCES users(id),
    game_id INT FOREIGN KEY REFERENCES games(id),
    minutes_time_played INT NOT NULL
);

