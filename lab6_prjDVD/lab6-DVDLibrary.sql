create login mylogin with password = 'mylogin', check_policy = off
use DVDLibrary
sp_changedbowner mylogin 

drop database DVDLibrary
use DVDLibrary

create table DVDLibrary (
	DVDCodeNo int primary key,
	DVDTitle nvarchar(100) not null,
	[Language] nvarchar(20) not null,
	Subtitle bit not null,
	Price money not null);



select * from DVDLibrary
insert into DVDLibrary values (1, 'Sách A', 'Tiếng Việt', 1, 10000);
