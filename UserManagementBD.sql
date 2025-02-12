DROP DATABASE IF EXISTS `Userdb`;
CREATE DATABASE `Userdb`;
USE `Userdb`;

CREATE TABLE AdminTable  (
  admin_id INT NOT NULL,
  username  VARCHAR(50),
  admin_password   VARCHAR(50),
  PRIMARY KEY (admin_id)
);

CREATE TABLE Users (
  user_id INT AUTO_INCREMENT NOT NULL,
  first_name VARCHAR(50),
  last_name VARCHAR(50),
  email VARCHAR(50),
  gender VARCHAR(10),
  id_number VARCHAR (13),
  birth_date DATE,
  PRIMARY KEY (user_id)
);

INSERT INTO AdminTable (admin_id,username, admin_password)
VALUES 
    (1,'Manddy', 'ManddyP@ssw0rd15');
    
    
INSERT INTO Users (user_id, first_name, last_name, email, gender, id_number,birth_date)
VALUES
(1, 'Leslie', 'Knope', 'leslieknope@gmail.com', 'Female', 1009250976899,'2010-09-25'),
(2, 'Tom', 'Haverford', 'tomhaverford@gmail.com', 'Male', 9703040968355 ,'1997-03-04'),
(3, 'April', 'Ludgate', 'april.ludgate@gmail.com','Male' , 9403278947569, '1994-03-27'),
(4, 'Jerry', 'Gergich', 'jerrygerich@gmail.com', 'Male', 0508284677098 ,'2005-08-28');    