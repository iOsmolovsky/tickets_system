create database transport_system;
 use transport_system;
 CREATE TABLE users (
     id int NOT NULL AUTO_INCREMENT,
     login CHAR(30) NOT NULL unique,
     pass CHAR(30) NOT NULL,
     PRIMARY KEY (id)
);
insert into users (id, login, pass) values
(null, 'admin', 'admin'),
(null, 'user1', '1234');