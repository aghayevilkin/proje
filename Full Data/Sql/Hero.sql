USE [HeroCF]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'Web Design')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'Digital Marketing')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'Mobile Deveplopment')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Surname], [Username], [Password], [Desc], [Work], [Page], [Image]) VALUES (1, N'David ', N'Muller', N'Admin', NULL, N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.', N'Founder', NULL, N'user1.jpg')
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Username], [Password], [Desc], [Work], [Page], [Image]) VALUES (2, N'John ', N'Doe', N'JohnDoe', NULL, N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.', N'Founder', NULL, N'user2.jpg')
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Username], [Password], [Desc], [Work], [Page], [Image]) VALUES (3, N'Test ', N'Torres', N'HannahTorres', NULL, N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.', N'Founder', NULL, N'user3.jpg')
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Username], [Password], [Desc], [Work], [Page], [Image]) VALUES (4, N'Ryan ', N'Torres', N'HannahTorres', NULL, N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.', N'Founder', NULL, N'user4.jpg')
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Username], [Password], [Desc], [Work], [Page], [Image]) VALUES (5, N'Hannah ', N'Torres', N'HannahTorres', NULL, N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor.', N'Founder', NULL, NULL)
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Username], [Password], [Desc], [Work], [Page], [Image]) VALUES (6, N'Emma', N'Marshall', N'EmmaMarshall', NULL, N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa', N'Web Developer', N'says', N'user1.jpg')
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Username], [Password], [Desc], [Work], [Page], [Image]) VALUES (7, N'Jhon', N'Doe', N'JhonDoe', NULL, N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa', N'UI/UX Designer', N'says', N'user2.jpg')
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Username], [Password], [Desc], [Work], [Page], [Image]) VALUES (8, N'Jessica', N'Doe', N'JessicaDoe', NULL, N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa', N'Web Designer', N'says', N'user3.jpg')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [Title], [Image], [Content], [Quote], [Heading], [Desc], [AdedDate], [CategoryId], [UserId]) VALUES (5, N'Seeing the big picture of information and information management', N'blog-img1.jpg', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis.', N'Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede', N'Heading', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem.', CAST(N'2020-04-06T00:00:00.0000000' AS DateTime2), 1, 1)
INSERT [dbo].[Blogs] ([Id], [Title], [Image], [Content], [Quote], [Heading], [Desc], [AdedDate], [CategoryId], [UserId]) VALUES (6, N'Seeing the big picture of information and information management', N'blog-img2.jpg', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis.', N'Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede', N'Heading', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem.', CAST(N'2020-04-06T00:00:00.0000000' AS DateTime2), 2, 4)
INSERT [dbo].[Blogs] ([Id], [Title], [Image], [Content], [Quote], [Heading], [Desc], [AdedDate], [CategoryId], [UserId]) VALUES (7, N'Seeing the big picture of information and information management', N'blog-img1.jpg', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis.', N'Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede', N'Heading', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem.', CAST(N'2020-04-06T00:00:00.0000000' AS DateTime2), 3, 2)
INSERT [dbo].[Blogs] ([Id], [Title], [Image], [Content], [Quote], [Heading], [Desc], [AdedDate], [CategoryId], [UserId]) VALUES (8, N'Seeing the big picture of information and information management', N'blog-img2.jpg', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis.', N'Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede', N'Heading', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem.', CAST(N'2020-04-06T00:00:00.0000000' AS DateTime2), 1, 3)
INSERT [dbo].[Blogs] ([Id], [Title], [Image], [Content], [Quote], [Heading], [Desc], [AdedDate], [CategoryId], [UserId]) VALUES (14, N'Seeing the big picture of information and information management', N'blog-img1.jpg', N'Lorem jhdbnmhjbs dsfnjk nfds jn kn', N'Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede', N'Heading', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem.', CAST(N'2018-01-07T00:00:00.0000000' AS DateTime2), 1, 1)
INSERT [dbo].[Blogs] ([Id], [Title], [Image], [Content], [Quote], [Heading], [Desc], [AdedDate], [CategoryId], [UserId]) VALUES (16, N'Seeing the big picture of information and information management', N'blog-img1.jpg', N'Lorem jhdbnmhjbs dsfnjk nfds jn kn', N'Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede', N'Heading', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem.', CAST(N'2019-06-26T00:00:00.0000000' AS DateTime2), 2, 5)
INSERT [dbo].[Blogs] ([Id], [Title], [Image], [Content], [Quote], [Heading], [Desc], [AdedDate], [CategoryId], [UserId]) VALUES (17, N'Seeing the big picture of information and information management', N'blog-img1.jpg', N'Lorem jhdbnmhjbs dsfnjk nfds jn kn', N'Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede', N'Heading', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem.', CAST(N'2005-02-17T06:00:00.0000000' AS DateTime2), 2, 1)
INSERT [dbo].[Blogs] ([Id], [Title], [Image], [Content], [Quote], [Heading], [Desc], [AdedDate], [CategoryId], [UserId]) VALUES (18, N'Seeing the big picture of information and information management', N'blog-img1.jpg', N'Lorem jhdbnmhjbs dsfnjk nfds jn kn', N'Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede', N'Heading', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem.', CAST(N'2015-09-23T00:00:00.0000000' AS DateTime2), 3, 1)
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
SET IDENTITY_INSERT [dbo].[Socials] ON 

INSERT [dbo].[Socials] ([Id], [Icon], [Link], [Color]) VALUES (1, N'fa fa-facebook', N'#', NULL)
INSERT [dbo].[Socials] ([Id], [Icon], [Link], [Color]) VALUES (2, N'fa fa-twitter', N'#', N'mu-twitter')
INSERT [dbo].[Socials] ([Id], [Icon], [Link], [Color]) VALUES (3, N'fa fa-pinterest-p', N'#', N'mu-pinterest')
INSERT [dbo].[Socials] ([Id], [Icon], [Link], [Color]) VALUES (4, N'fa fa-google-plus', N'#', N'mu-google-plus')
INSERT [dbo].[Socials] ([Id], [Icon], [Link], [Color]) VALUES (5, N'fa fa-youtube', N'#', N'mu-youtube')
SET IDENTITY_INSERT [dbo].[Socials] OFF
GO
SET IDENTITY_INSERT [dbo].[SocialToUsers] ON 

INSERT [dbo].[SocialToUsers] ([Id], [Link], [SocialId], [UserId]) VALUES (1, NULL, 1, 1)
INSERT [dbo].[SocialToUsers] ([Id], [Link], [SocialId], [UserId]) VALUES (2, NULL, 2, 1)
INSERT [dbo].[SocialToUsers] ([Id], [Link], [SocialId], [UserId]) VALUES (3, NULL, 3, 1)
INSERT [dbo].[SocialToUsers] ([Id], [Link], [SocialId], [UserId]) VALUES (4, NULL, 4, 1)
SET IDENTITY_INSERT [dbo].[SocialToUsers] OFF
GO
SET IDENTITY_INSERT [dbo].[Teams] ON 

INSERT [dbo].[Teams] ([Id], [Title], [BgImage], [UserId]) VALUES (1, NULL, NULL, 1)
INSERT [dbo].[Teams] ([Id], [Title], [BgImage], [UserId]) VALUES (2, NULL, NULL, 2)
INSERT [dbo].[Teams] ([Id], [Title], [BgImage], [UserId]) VALUES (3, NULL, NULL, 3)
INSERT [dbo].[Teams] ([Id], [Title], [BgImage], [UserId]) VALUES (4, NULL, NULL, 4)
SET IDENTITY_INSERT [dbo].[Teams] OFF
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([Id], [Name], [Email], [Website], [Content], [AddedDate], [BlogId], [CommentId]) VALUES (5, N'Admin', N'test@code.az', N'Code.az', N'HJBKjhkbhnliuyhjkuhjkn', CAST(N'2020-04-06T00:00:00.0000000' AS DateTime2), 5, NULL)
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Website], [Content], [AddedDate], [BlogId], [CommentId]) VALUES (11, N'Test', N'testt@edu.az', N'Web.az', N'HGnkmsndbj nmsd', CAST(N'2020-04-06T00:00:00.0000000' AS DateTime2), 6, NULL)
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Website], [Content], [AddedDate], [BlogId], [CommentId]) VALUES (12, N'Alone', N'bbb@web.az', N'edu.az', N'JHhbjnklmkmkjl,k', CAST(N'2020-04-06T00:00:00.0000000' AS DateTime2), 7, NULL)
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Website], [Content], [AddedDate], [BlogId], [CommentId]) VALUES (15, N'Test', N'aaa@com.az', N'com.az', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis.', CAST(N'2020-03-05T00:00:00.0000000' AS DateTime2), 5, 5)
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Website], [Content], [AddedDate], [BlogId], [CommentId]) VALUES (16, N'Test2', N'bb@bb.bb', N'com.az', N'
Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis.', CAST(N'2018-02-26T00:00:00.0000000' AS DateTime2), 5, 5)
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Website], [Content], [AddedDate], [BlogId], [CommentId]) VALUES (17, N'Michael', N'ab@abc.az', N'com.az', N'
Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis.', CAST(N'2018-02-26T00:00:00.0000000' AS DateTime2), 5, NULL)
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Website], [Content], [AddedDate], [BlogId], [CommentId]) VALUES (18, N'Test3', N'abc@mail.ru', N'web.az', N'
Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis.', CAST(N'2020-04-06T00:00:00.0000000' AS DateTime2), 5, 17)
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Website], [Content], [AddedDate], [BlogId], [CommentId]) VALUES (19, N'Anthony', N'test@list.ru', N'test.az', N'Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede', CAST(N'2020-03-05T00:00:00.0000000' AS DateTime2), 8, NULL)
INSERT [dbo].[Comments] ([Id], [Name], [Email], [Website], [Content], [AddedDate], [BlogId], [CommentId]) VALUES (20, N'Jackson', N'sdhgsd@an.az', N'code.az', N'Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, "Lorem ipsum dolor sit amet..", comes from a line in section 1.10.32.', CAST(N'2020-04-06T00:00:00.0000000' AS DateTime2), 8, 19)
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[About] ON 

INSERT [dbo].[About] ([Id], [Title], [Desc], [Image]) VALUES (1, N'Our Mission', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis,', N'about_us.jpg')
INSERT [dbo].[About] ([Id], [Title], [Desc], [Image]) VALUES (2, N'Our Vision', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis,', NULL)
INSERT [dbo].[About] ([Id], [Title], [Desc], [Image]) VALUES (3, N'Our Valuse', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis,', NULL)
SET IDENTITY_INSERT [dbo].[About] OFF
GO
SET IDENTITY_INSERT [dbo].[AllPageTitles] ON 

INSERT [dbo].[AllPageTitles] ([Id], [Title], [Desc], [Page]) VALUES (1, N'WHO WE ARE', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa cum sociis.', N'about')
INSERT [dbo].[AllPageTitles] ([Id], [Title], [Desc], [Page]) VALUES (2, N'OUR WORKING SKILL
', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa cum sociis.', N'skill')
INSERT [dbo].[AllPageTitles] ([Id], [Title], [Desc], [Page]) VALUES (3, N'CREATIVE TEAM', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa cum sociis.', N'team')
INSERT [dbo].[AllPageTitles] ([Id], [Title], [Desc], [Page]) VALUES (4, N'Our exclusive services', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa cum sociis.', N'services')
INSERT [dbo].[AllPageTitles] ([Id], [Title], [Desc], [Page]) VALUES (5, N'OUR PRICING TABLE', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa cum sociis.', N'pricing')
INSERT [dbo].[AllPageTitles] ([Id], [Title], [Desc], [Page]) VALUES (6, N'What Our Client Says', NULL, N'says')
INSERT [dbo].[AllPageTitles] ([Id], [Title], [Desc], [Page]) VALUES (7, N'SAY HELLO!', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa cum sociis.', N'contact')
INSERT [dbo].[AllPageTitles] ([Id], [Title], [Desc], [Page]) VALUES (8, N'Our Recent Project', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa cum sociis.', N'portfolio')
INSERT [dbo].[AllPageTitles] ([Id], [Title], [Desc], [Page]) VALUES (9, N'FROM OUR BLOG', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa cum sociis.', N'blog')
INSERT [dbo].[AllPageTitles] ([Id], [Title], [Desc], [Page]) VALUES (10, N'SUBSCRIBE OUR NEWSLETTER', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa cum sociis.', N'subscribe')
SET IDENTITY_INSERT [dbo].[AllPageTitles] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [Name], [Adress], [Phone], [Email], [Icon]) VALUES (1, N'CONTACT INFORMATION', N'349 Main St, Deseronto, ON K0K 1X0, Canada', N'
+00 123 456 789 00', N'support@bhero.com', N'')
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[Counters] ON 

INSERT [dbo].[Counters] ([Id], [Count], [Name], [Icon]) VALUES (2, 250, N'PROJECT', N'fa fa-suitcase')
INSERT [dbo].[Counters] ([Id], [Count], [Name], [Icon]) VALUES (3, 56, N'CLIENTS', N'fa fa-user')
INSERT [dbo].[Counters] ([Id], [Count], [Name], [Icon]) VALUES (4, 15, N'STUFF', N'fa fa-coffee')
INSERT [dbo].[Counters] ([Id], [Count], [Name], [Icon]) VALUES (5, 290, N'DAY', N'fa fa-clock-o')
SET IDENTITY_INSERT [dbo].[Counters] OFF
GO
SET IDENTITY_INSERT [dbo].[JumBotrons] ON 

INSERT [dbo].[JumBotrons] ([Id], [Title], [Desc], [BgImage], [BtnName], [BtnLink]) VALUES (1, N'This is a simple hero unit, a simple jumbotron-style', N'component for calling extra attention to featured content or information.', N'skill-bg.jpg', N'Get a Quote ', N'#')
SET IDENTITY_INSERT [dbo].[JumBotrons] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderUnorders] ON 

INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (1, N'Unorder list-Test', N'Test ipsum dolor sit amet, consectetur ', N'unorder')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (2, NULL, N'Curabitur blandit felis in tincidunt semper.', N'unorder')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (3, NULL, N'Etiam interdum felis egestas eros elementum', N'unorder')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (4, NULL, N'Test Aliquam et massa feugiat,', N'unorder')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (5, NULL, N'Nunc ullamcorper tellus eget eros euismod,', N'unorder')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (6, NULL, N'Maecenas sagittis lectus ac nisi euismod fringilla.', N'unorder')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (7, NULL, N'Lorem ipsum dolor sit amet, consectetur', N'unorder')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (8, NULL, N'Curabitur blandit felis in tincidunt semper.', N'unorder')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (9, N'Order list-Test
', N'Test ipsum dolor sit amet, consectetur ', N'order')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (10, NULL, N'Curabitur blandit felis in tincidunt semper.', N'order')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (11, NULL, N'Etiam interdum felis egestas eros elementum', N'order')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (12, NULL, N'Test Aliquam et massa feugiat,', N'order')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (13, NULL, N'Nunc ullamcorper tellus eget eros euismod,', N'order')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (14, NULL, N'Maecenas sagittis lectus ac nisi euismod fringilla.', N'order')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (15, NULL, N'Lorem ipsum dolor sit amet, consectetur', N'order')
INSERT [dbo].[OrderUnorders] ([Id], [Name], [Desc], [Section]) VALUES (16, NULL, N'Curabitur blandit felis in tincidunt semper.', N'order')
SET IDENTITY_INSERT [dbo].[OrderUnorders] OFF
GO
SET IDENTITY_INSERT [dbo].[PageHeaders] ON 

INSERT [dbo].[PageHeaders] ([Id], [Name], [Image], [Page]) VALUES (1, N'BLOG DETAILS', N'page-header-bg.jpg', N'blogSingle')
INSERT [dbo].[PageHeaders] ([Id], [Name], [Image], [Page]) VALUES (2, N'ABOUT US', N'page-header-bg.jpg', N'about')
INSERT [dbo].[PageHeaders] ([Id], [Name], [Image], [Page]) VALUES (3, N'OUR EXCLUSIVE SERVICES', N'page-header-bg.jpg', N'services')
INSERT [dbo].[PageHeaders] ([Id], [Name], [Image], [Page]) VALUES (4, N'PORTFOLIO', N'page-header-bg.jpg', N'portfolio')
INSERT [dbo].[PageHeaders] ([Id], [Name], [Image], [Page]) VALUES (5, N'Contact us', N'page-header-bg.jpg', N'contact')
SET IDENTITY_INSERT [dbo].[PageHeaders] OFF
GO
SET IDENTITY_INSERT [dbo].[Partners] ON 

INSERT [dbo].[Partners] ([Id], [Image]) VALUES (1, N'cl_logo1.png')
INSERT [dbo].[Partners] ([Id], [Image]) VALUES (2, N'cl_logo2.png')
INSERT [dbo].[Partners] ([Id], [Image]) VALUES (3, N'cl_logo3.png')
INSERT [dbo].[Partners] ([Id], [Image]) VALUES (4, N'cl_logo4.png')
INSERT [dbo].[Partners] ([Id], [Image]) VALUES (5, N'cl_logo5.png')
INSERT [dbo].[Partners] ([Id], [Image]) VALUES (6, N'cl_logo6.png')
SET IDENTITY_INSERT [dbo].[Partners] OFF
GO
SET IDENTITY_INSERT [dbo].[Pricings] ON 

INSERT [dbo].[Pricings] ([Id], [Icon], [Name], [Info], [Price], [Btn]) VALUES (1, N'fa fa-user', N'BASIC', N'Lorem ipsum dolor sit amet.
Consectetuer elit aeneaneget dolor.
Aenean massa cum sociis natoque.
Penatibus.', N'29$', N'Buy Now')
INSERT [dbo].[Pricings] ([Id], [Icon], [Name], [Info], [Price], [Btn]) VALUES (2, N'fa fa-lock', N'STANDARD', N'Lorem ipsum dolor sit amet.
Consectetuer elit aeneaneget dolor.
Aenean massa cum sociis natoque.
Penatibus.', N'99$', N'Buy Now')
INSERT [dbo].[Pricings] ([Id], [Icon], [Name], [Info], [Price], [Btn]) VALUES (3, N'fa fa-paper-plane', N'PREMIUM', N'Lorem ipsum dolor sit amet.
Consectetuer elit aeneaneget dolor.
Aenean massa cum sociis natoque.
Penatibus.', N'229$', N'Buy Now')
SET IDENTITY_INSERT [dbo].[Pricings] OFF
GO
SET IDENTITY_INSERT [dbo].[RecentProjects] ON 

INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (1, N'All', NULL, N'all')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (2, N'Web design', NULL, N'1')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (3, N'Mobile Development', NULL, N'2')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (4, N'E-commerces', NULL, N'3')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (5, N'Arts', NULL, N'4')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (6, N'Branding', NULL, N'5')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (7, N'Web design', N'webimg1.jpg', N'1')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (8, N'Web design', N'webimg2.jpg', N'1')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (9, N'Web design', N'webimg3.jpg', N'1')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (10, N'Mobile Development', N'mobil1.jpg', N'2')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (11, N'Mobile Development', N'mobil2.jpg', N'2')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (12, N'Mobile Development', N'mobil3.jpg', N'2')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (13, N'Mobile Development', N'mobil4.jpg', N'2')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (14, N'E-commerces', N'e-commerce1.jpg', N'3')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (15, N'E-commerces', N'e-commerce2.jpg', N'3')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (16, N'E-commerces', N'e-commerce3.jpg', N'3')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (17, N'Arts', N'arts1.jpg', N'4')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (18, N'Arts', N'arts2.jpg', N'4')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (19, N'Branding', N'brand1.jpg', N'5')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (20, N'Branding', N'brand2.jpg', N'5')
INSERT [dbo].[RecentProjects] ([Id], [Name], [Image], [DataFilter]) VALUES (21, N'Branding', N'brand3.jpg', N'5')
SET IDENTITY_INSERT [dbo].[RecentProjects] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([Id], [Name], [Info], [Icon]) VALUES (1, N'E-Commerce', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor commodo .', N'fa fa-shopping-cart')
INSERT [dbo].[Services] ([Id], [Name], [Info], [Icon]) VALUES (2, N'
ONLINE MARKETING', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor commodo .', N'fa fa-bullhorn')
INSERT [dbo].[Services] ([Id], [Name], [Info], [Icon]) VALUES (3, N'
WEB DESIGN', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor commodo .', N'fa fa-laptop')
INSERT [dbo].[Services] ([Id], [Name], [Info], [Icon]) VALUES (4, N'MOBILE DEVELOPMENT', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor commodo .', N'fa fa-mobile')
INSERT [dbo].[Services] ([Id], [Name], [Info], [Icon]) VALUES (5, N'
CUSTOMER SUPPORT', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor commodo .', N'NULLfa fa-clock-o')
INSERT [dbo].[Services] ([Id], [Name], [Info], [Icon]) VALUES (6, N'
CUSTOMIZATION', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor commodo .', N'fa fa-cog')
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Logo], [LogoText], [FooterDesc], [Footer]) VALUES (1, N'logo.png', N'B-HERO', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus.', N'Copyright All right reserved.')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[Skills] ON 

INSERT [dbo].[Skills] ([Id], [Title], [Desc], [BgImage], [Loader]) VALUES (1, N'Web Design', N'Lorem ipsum dolor sit amet, con sectetuer adipiscing elitamin.', N'skill-bg.jpg', N'circle-1')
INSERT [dbo].[Skills] ([Id], [Title], [Desc], [BgImage], [Loader]) VALUES (2, N'Mobile Development', N'Lorem ipsum dolor sit amet, con sectetuer adipiscing elitamin.', NULL, N'circle-2')
INSERT [dbo].[Skills] ([Id], [Title], [Desc], [BgImage], [Loader]) VALUES (3, N'E-commerce', N'Lorem ipsum dolor sit amet, con sectetuer adipiscing elitamin.', NULL, N'circle-3')
INSERT [dbo].[Skills] ([Id], [Title], [Desc], [BgImage], [Loader]) VALUES (4, N'Online Marketing', N'Lorem ipsum dolor sit amet, con sectetuer adipiscing elitamin.', NULL, N'circle-4')
SET IDENTITY_INSERT [dbo].[Skills] OFF
GO
SET IDENTITY_INSERT [dbo].[Sliders] ON 

INSERT [dbo].[Sliders] ([Id], [Title], [Desc], [BgImage], [BtnName], [Link]) VALUES (1, N'Welcome to b-hero', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis,', N'slider1.jpg', N'Read More', N'#')
INSERT [dbo].[Sliders] ([Id], [Title], [Desc], [BgImage], [BtnName], [Link]) VALUES (2, N'We Promote Your Business', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis,', N'slider1.jpg', N'Read More', N'#')
INSERT [dbo].[Sliders] ([Id], [Title], [Desc], [BgImage], [BtnName], [Link]) VALUES (3, N'Free Multipurpose Template', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis,', N'slider1.jpg', N'Read More', N'#')
SET IDENTITY_INSERT [dbo].[Sliders] OFF
GO
SET IDENTITY_INSERT [dbo].[TwitterFeeds] ON 

INSERT [dbo].[TwitterFeeds] ([Id], [Title], [Name], [Desc], [Icon]) VALUES (1, N'Twitter feed', N'b_hero', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit.', N'fa fa-twitter')
INSERT [dbo].[TwitterFeeds] ([Id], [Title], [Name], [Desc], [Icon]) VALUES (2, NULL, N'b_hero', N'Lorem ipsum dolor sit amet, consectetuer adipiscing elit.', N'fa fa-twitter')
SET IDENTITY_INSERT [dbo].[TwitterFeeds] OFF
GO
SET IDENTITY_INSERT [dbo].[Videos] ON 

INSERT [dbo].[Videos] ([Id], [BgImage], [Link], [Desc]) VALUES (1, N'skill-bg.jpg', N'https://www.youtube.com/embed/n9AVEl9764s', N'In this video from our "Talking business" series, our expert discusses the role a business plan can play in the success of your business.')
SET IDENTITY_INSERT [dbo].[Videos] OFF
GO
