
drop table if exists SpecialUnicornAbilities;
drop table if exists SpecialAbilities;
drop table if exists Unicorns;

create table Unicorns (
	Id				int				not null,
	name			varchar (100)	not null,
	birthday		date			not null,
	color			int				not null,
	description 	varchar (1000)	not null,
	primary key clustered (Id asc)
);

create table SpecialAbilities (
	Id				int				not null,
	name			varchar (100)	not null,
	description		varchar (1000)	not null,
	primary key clustered (Id asc)
);

create table SpecialUnicornAbilities (
	unicornId				int		not null,
	specialAbilitiesId		int		not null,
	primary key (unicornId, specialAbilitiesId),
	foreign key (unicornId) 			references Unicorns (Id),
	foreign key (specialAbilitiesId)	references SpecialAbilities (Id)
);



insert into Unicorns (id, name, birthday, color, description) values (1, 'Pseudalopex gymnocercus', DATE('0345-0Id1-03'), 805137, 'Suspendisse impotenti. Cras in purus eu magna vulputate luctus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vivamus vestibulum sagittis sapien. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam vel augue.');
insert into Unicorns (id, name, birthday, color, description) values (2, 'Fratercula corniculata', date('0945-01-12'), 7559408, 'Duis consequat dui nec nisi volutpat eleifend. Donec ut dolor. Morbi vel lectus in quam fringilla rhoncus. Mauris enim leo, rhoncus sed, vestibulum sit amet, cursus id, turpis. Integer aliquet, massa id lobortis convallis, tortor risus dapibus augue, vel accumsan tellus nisi eu orci. Mauris lacinia sapien quis libero. Nullam sit amet turpis elementum ligula vehicula consequat. Morbi a ipsum. Integer a nibh. In quis justo.');
insert into Unicorns (id, name, birthday, color, description) values (3, 'Haliaetus leucogaster', Date('1770-03-12'), 2170496, 'Phasellus id sapien in sapien iaculis congue. Vivamus metus arcu, adipiscing molestie, hendrerit at, vulputate vitae, nisl. Aenean lectus. Pellentesque eget nunc. Donec quis orci eget orci vehicula condimentum. Curabitur in libero ut massa volutpat convallis. Morbi odio odio, elementum eu, interdum eu, tincidunt in, leo. Maecenas pulvinar lobortis est. Phasellus sit amet erat. Nulla tempus.');
insert into Unicorns (id, name, birthday, color, description) values (4, 'Tadorna tadorna', date('0268-11-16'), 3065052, 'Maecenas tincidunt lacus at velit. Vivamus vel nulla eget eros elementum pellentesque. Quisque porta volutpat erat.');
insert into Unicorns (id, name, birthday, color, description) values (5, 'Ammospermophilus nelsoni', Date('1390-10-12'), 9871741, 'Curabitur gravida nisi at nibh. In hac habitasse platea dictumst. Aliquam augue quam, sollicitudin vitae, consectetuer eget, rutrum at, lorem.');

