USE [UI_grid]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 4/1/2019 11:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NULL,
	[Correct] [bit] NOT NULL,
	[QuestionId] [int] NOT NULL,
 CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cell]    Script Date: 4/1/2019 11:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cell](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Cell] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Question]    Script Date: 4/1/2019 11:32:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NULL,
	[CellId] [int] NOT NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Answer] ON 

INSERT [dbo].[Answer] ([Id], [Content], [Correct], [QuestionId]) VALUES (2, N'Junit', 0, 1)
INSERT [dbo].[Answer] ([Id], [Content], [Correct], [QuestionId]) VALUES (3, N'Doors', 1, 1)
INSERT [dbo].[Answer] ([Id], [Content], [Correct], [QuestionId]) VALUES (4, N'Zephyr', 1, 1)
INSERT [dbo].[Answer] ([Id], [Content], [Correct], [QuestionId]) VALUES (5, N'Pivotal', 0, 1)
INSERT [dbo].[Answer] ([Id], [Content], [Correct], [QuestionId]) VALUES (6, N'Cucumber', 0, 1)
INSERT [dbo].[Answer] ([Id], [Content], [Correct], [QuestionId]) VALUES (7, N'VersionOne', 0, 1)
INSERT [dbo].[Answer] ([Id], [Content], [Correct], [QuestionId]) VALUES (8, N'PAL page describing JUnit will be used by group (a):', 0, 2)
INSERT [dbo].[Answer] ([Id], [Content], [Correct], [QuestionId]) VALUES (9, N'PAL page describing Quality Center will be used by group (b):', 1, 2)
INSERT [dbo].[Answer] ([Id], [Content], [Correct], [QuestionId]) VALUES (10, N'PAL page describing TDD will be used by group (c):', 1, 2)
SET IDENTITY_INSERT [dbo].[Answer] OFF
SET IDENTITY_INSERT [dbo].[Cell] ON 

INSERT [dbo].[Cell] ([Id], [Name]) VALUES (1, N'Cell 16')
INSERT [dbo].[Cell] ([Id], [Name]) VALUES (2, N'Cell 53')
SET IDENTITY_INSERT [dbo].[Cell] OFF
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([Id], [Content], [CellId]) VALUES (1, N'From the given list of tools, select three tools that are used to manage requirements for a project.', 1)
INSERT [dbo].[Question] ([Id], [Content], [CellId]) VALUES (2, N'When building a PAL and assuming each page will be used by a distinct group of people. You have a group (a), of
    folks writing code and another group (b) involved in system test. Which of the following statements are true ?', 2)
SET IDENTITY_INSERT [dbo].[Question] OFF
/****** Object:  Index [IX_Answer_QuestionId]    Script Date: 4/1/2019 11:32:01 AM ******/
CREATE NONCLUSTERED INDEX [IX_Answer_QuestionId] ON [dbo].[Answer]
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Question_CellId]    Script Date: 4/1/2019 11:32:02 AM ******/
CREATE NONCLUSTERED INDEX [IX_Question_CellId] ON [dbo].[Question]
(
	[CellId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD  CONSTRAINT [FK_Answer_Question_QuestionId] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Answer] CHECK CONSTRAINT [FK_Answer_Question_QuestionId]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_Cell_CellId] FOREIGN KEY([CellId])
REFERENCES [dbo].[Cell] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_Cell_CellId]
GO
USE [master]
GO
ALTER DATABASE [UI_grid] SET  READ_WRITE 
GO
