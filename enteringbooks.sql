

SELECT * FROM BOOKS;
SELECT * FROM USERS;
SELECT * FROM Customers;
SELECT * FROM ORDERS;
SELECT * FROM BookOrder;


INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('1785034677', 'The Martian', 'Ebury Publishing', 'English', 271, 'Any Weir', 
'So you want to lieve on Mars. Perhaps its the rugged terrain, beutiful scenery, or vast..', 
'Six days ago, astronaut Mark Watney became one of the fist people to walk on Mars', 5, 5, 'Science Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0441000681', 'Neuromancer', 'Ace Publishing', 'English', 278, 'William F. Gibson', 
'Case was the hottest computer cowboy cruising the information superhighway--jacking his consciousness into cyberspace...', 
'The sky above the port was the color of television, tuned to a dead channel.', 5, 5, 'Science Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0441012035', 'Neuromancer', 'Ace Publishing', 'English', 278, 'William F. Gibson', 
'Case was the hottest computer cowboy cruising the information superhighway--jacking his consciousness into cyberspace...', 
'The sky above the port was the color of television, tuned to a dead channel.', 5, 5, 'Science Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0670881465', '48 Laws of Power', 'Viking', 'English', 198, 'Robert Greene', 
'Amoral, cunning, ruthless, and instructive, this piercing work distills three thousand years of the history of power in to forty-eight well explicated laws.', 
'At work, in relationships, on the street, or on the five oclock news, these Laws are exerted everywhere.', 5, 5, 'Psychology');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0713631880', 'The Critic', 'Methuen Drama', 'English', 85, 'Richard Brinsley Sheridan', 
'The Critic was Sheridans response to a very specific political and theatrical situation. ', 
'g. This edition traces both the political and the theatrical objects of Sheridans satire', 5, 5, 'Drama');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0385746539', 'The King of Mulberry Street', 'Wendy Lamb Books', 'English', 245, 'Donna Jo Napoli', 
'In 1892, nine-year-old Dom’s mother puts him on a ship leaving Italy, bound for America.', 
'In the turbulent world of homeless children in Manhattans Five Points, Dom learns street smarts, and not only survives, but thrives by starting his own business.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0425153975', 'The Eyes of Darkness', 'Berkley', 'English', 369, 'Dean Koontz', 
'Tina Evans, grieving over the death of her little boy in a tragic accident, and her compassionate lover embark on a terrifying odyssey in search of the truth about her sons death and the shocking messages that lead her to believe that the child may not be dead after all.', 
'One year after her little boy Danny dies, his mother swears that she sees him in a strangers car, and becoming obsessed with the mystery, she journeys to Las Vegas and the High Sierras in search of the truth.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0007368305', 'Odd Thomas', 'Harper', 'English', 452, 'Dean Koontz', 
'Sometimes the silent souls who seek out Odd want justice. Occasionally their otherworldly tips help him prevent a crime. But this time it’s different.', 
'Odd is worried. He knows things, sees things - about the living, the dead and the soon to be dead. Things that he has to act on.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0743424425', 'The Shining', 'Pocket Books', 'English', 324, 'Stephen King', 
'The Overlook Hotel is more than just a home-away-from-home for the Torrance family.', 
'Stephen Kings classic thriller is one of the most powerfully imagined novels of our time.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0439064872', 'Harry Potter and the Chamber of Secrets', 'Scholastic', 'English', 344, 'JK Rowling', 
'Throughout the summer holidays after his first year at Hogwarts School of Witchcraft and Wizardry, Harry Potter has been receiving sinister warnings from a house-elf called Dobby.', 
'For in Harrys second year at Hogwarts, fresh torments and horrors arise,', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('059035342X', 'Harry Potter and the Sorcerers Stone', 'Scholastic', 'English', 312, 'JK Rowling', 
'When mysterious letters start arriving on his doorstep, Harry Potter has never heard of Hogwarts School of Witchcraft and Wizardry.', 
'Mr. And Mrs. Dursley, of number four, Privet Drive, were proud to say that they were perfectly normal, thank you very much.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0439136350', 'Harry Potter and the Prisoner of Azkaban', 'Scholastic', 'English', 435, 'JK Rowling', 
'For Harry Potter, it’s the start of another far-from-ordinary year at Hogwarts when the Knight Bus crashes through the darkness and comes to an abrupt halt in front of him.', 
'In his first Divination class, Professor Trelawney sees an omen of death in Harry’s tea leaves.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0439139597', 'Harry Potter and the Goblet of Fire', 'Scholastic', 'English', 734, 'JK Rowling', 
'The villagers of Little Hangleton still called it the Riddle House, even though it had been many years since the Riddle family had lived there.', 
'Its the pivotal fourth novel in the seven-part saga of a young wizards coming of age. The thickest. The juiciest yet.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('9955084332', 'Harry Potter and the Order of the Phoenix', 'Scholastic', 'English', 734, 'JK Rowling', 
'After the Dementors’ attack on his cousin Dudley, Harry knows he is about to become Voldemort’s next target.', 
'The hottest day of the summer so far was drawing to a close and a drowsy silence lay over the large, square houses of Privet Drive.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('8532519474', 'Harry Potter and the Half-Blood Prince', 'Scholastic', 'English', 784, 'JK Rowling', 
'Rumours and suspicion spread through the wizarding world – it feels as if even Hogwarts itself might be under threat.', 
'It was nearing midnight and the Prime Minister was sitting alone in his office, reading a long memo that was slipping through his brain without leaving the slightest trace of meaning behind.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0545029368', 'Harry Potter and the Deathly Hallows', 'Scholastic', 'English', 794, 'JK Rowling', 
'In Harry Potter and the Deathly Hallows, the seventh and final book in the epic tale of Harry Potter, Harry and Lord Voldemort each prepare for their ultimate encounter.', 
'They visit the Burrow, Grimmauld Place, the Ministry, Godric’s Hollow, Malfoy Manor, Diagon Alley…', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('000647988X', 'A Game of Thrones', 'Voyager', 'English', 704, 'George R. R. Martin', 
'Long ago, in a time forgotten, a preternatural event threw the seasons out of balance.', 
'"We should start back," Gared urged as the woods began to grow dark around them.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0553108034', 'A Clash of Kings', 'Bantam Books', 'English', 761, 'George R. R. Martin', 
'It is a tale in which brother plots against brother and the dead rise to walk in the night.', 
'A comet the color of blood and flame cuts across the sky.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0553106635', 'A Storm of Swords', 'Bantam Books', 'English', 973, 'George R. R. Martin', 
'Of the five contenders for power, one is dead, another in disfavor, and still the wars rage as alliances are made and broken.', 
'An east wind blew through his tangled hair, as soft and fragrant as Cerseis fingers.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0553801503', 'A Feast for Crows', 'Bantam Books', 'English', 753, 'George R. R. Martin', 
'Bloodthirsty, treacherous and cunning, the Lannisters are in power on the Iron Throne in the name of the boy-king Tommen.', 
'From the icy north, where Others threaten the Wall, apprentice Maester Samwell Tarly brings a mysterious babe in arms to the Citadel.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('9780002247399', 'A Dance with Dragons', 'Bantam Books', 'English', 853, 'George R. R. Martin', 
'In the aftermath of a colossal battle, the future of the Seven Kingdoms hangs in the balance—beset by newly emerging threats from every direction.', 
'“The world is full of wine,” he muttered in the dankness of his cabin. ', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('2070333930', 'Moi, Boy', 'Livre de Poche', 'English', 323, 'Roald Dahl', 
'Boy is an autobiographical book by British writer Roald Dahl. This book describes his life from birth until leaving school.', 
'It presents humorous anecdotes from the authors childhood which includes summer vacations in Norway and an English boarding school.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('0399130276', 'Chapterhouse: Dune', 'Putnam', 'English', 464, 'Frank Herbert', 
'The final book in the Dune series.', 
'The Bene Gesserit find themselves the target of the Honored Matres, whose conquest of the Old Empire is almost complete.', 5, 5, 'Fiction');

INSERT INTO dbo.Books (Isbn, Title, Publisher, Language, Pages, AuthorName, Synopsis, Excerpt, TotalCopies, AvalableCopies, Genre)
VALUES ('9781607742739', 'Flour Water Salt Yeast', 'Ten Speed Press', 'English', 272, 'Ken Forkish', 
'From Portlands most acclaimed and beloved baker comes this must-have baking guide, featuring scores of recipes for world-class breads and pizzas and a variety of schedules suited for the home baker.', 
'Tips on creating and adapting bread baking schedules that fit in readers day-to-day lives', 5, 5, 'Cooking');