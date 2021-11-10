INSERT INTO users (first_name, last_name) VALUES ('Giorgio', 'Caculli');
INSERT INTO users (first_name, last_name) VALUES ('Tanguy', 'Taminiau');
INSERT INTO users (first_name, last_name) VALUES ('Guillaume', 'Lambert');

INSERT INTO games (name, minutes_for_completion) VALUES ('DnD',300);

INSERT INTO history_items (user_id, game_id, minutes_time_played) VALUES (1, 1, 250);
INSERT INTO history_items (user_id, game_id, minutes_time_played) VALUES (2, 1, 175);
INSERT INTO history_items (user_id, game_id, minutes_time_played) VALUES (3, 1, 112);
