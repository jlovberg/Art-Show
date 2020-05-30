delete from shown;
delete from art_show;
delete from artwork;
delete from artist;
delete from customer;


INSERT INTO `art`.`customer`
(`phone`,
`name`,
`art_preferences`)
VALUES
('1234567899',
'Joe Smith',
'sculpture'),
('2222222222', 'Frank Flower', 'painting'), ('5554444444', 'Average Andy', 'contemporary')
, ('6665556666', 'Kanye West', 'religious');

INSERT INTO `art`.`artist`
(`name`,
`phone`,
`address`,`birth_place`, `age`, `style_of_art`)
VALUES
('Pablo', '6998886783', '674 Deer Lane', 'San Diego', '50', 'Sculpture'),('Susan', '5998880022', '123 Art Way', 'San Diego', '30', 'Sculpture'),
('Esco Jones', '5558732121', '673 Wavertree rd', 'Fullerton', '28', 'painting'),('Andy King', '7778889090', '5 Painting Rd', 'San Diego', '48', 'religious');

INSERT INTO `art`.`art_show`
(`date_and_time`,
`location`,
`contact_phone`,`contact_name`, `artist`)
VALUES
('2014-06-02 05:10:00', 'Library', '5556768888', 'Tracy', 'Pablo'),('2015-07-02 05:10:00', 'Book Store', '5556768800', 'Tom', 'Susan'),
('2019-04-11 12:00:00', 'Library', '5556768888', 'Tracy', 'Pablo'),('2017-01-14 06:10:00', 'Town Hall', '3336768888', 'Sammy', 'Esco Jones');


INSERT INTO `art`.`artwork`
(`unique_title`,
`artist`,
`type_of_art`,`date_of_creation`, `date_acquired`, `price`, `location`, `customerphone`)
VALUES
('Awakening', 'Pablo', 'Sculpture', '2013-05-05', '2016-02-14','100.00', 'blue room', '2222222222'),
('Savage', 'Pablo', 'Sculpture', '2014-23-05', '2018-05-14','50.50', 'basement', '2222222222'),
('Framed', 'Susan', 'Sculpture', '2009-05-18', '2016-03-03','75.00', 'blue room', '5554444444'),
('Chair', 'Esco Jones', 'painting', '2012-01-01', '2015-03-18','150.99', 'south hall', '6665556666');

INSERT INTO `art`.`shown`
(`artwork`,
`date_and_time`,
`location`)
VALUES
('Awakening', '2014-06-02 05:10:00', 'Library'), ('Framed', '2015-07-02 05:10:00', 'Book Store'),
('Savage', '2014-06-02 05:10:00', 'Library'),('Chair', '2017-01-14 06:10:00', 'Town Hall');

select * from art.customer;
select * from art.art_show;
select * from art.artist;
select * from art.artwork;
select * from art.shown;