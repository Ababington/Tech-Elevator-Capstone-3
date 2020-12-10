USE [final_capstone]
GO

/****** Object:  Table [dbo].[patients]    Script Date: 12/9/2020 7:13:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[patients](
	[patientId] [int] NOT NULL,
	[firstName] [varchar](30) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[streetAddress] [varchar](100) NOT NULL,
	[streetAddress2] [varchar](50) NULL,
	[city] [varchar](50) NOT NULL,
	[state] [varchar](50) NOT NULL,
	[zip] [int] NOT NULL,
	[phone] [int] NOT NULL,
	[email] [varchar](75) NULL,
	[dateOfBirth] [datetime] NOT NULL,
 CONSTRAINT [PK_patients] PRIMARY KEY CLUSTERED 
(
	[patientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[patients]  WITH CHECK ADD  CONSTRAINT [FK_patients_users] FOREIGN KEY([patientId])
REFERENCES [dbo].[users] ([user_id])
GO

ALTER TABLE [dbo].[patients] CHECK CONSTRAINT [FK_patients_users]
GO

CREATE TABLE [dbo].[doctor](
	[userId] [int] NOT NULL,
	[hourlyRate] [money] NOT NULL,
	[firstName] [varchar](35) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_doctor] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[doctor]  WITH CHECK ADD  CONSTRAINT [FK_doctor_users] FOREIGN KEY([userId])
REFERENCES [dbo].[users] ([user_id])
GO

ALTER TABLE [dbo].[doctor] CHECK CONSTRAINT [FK_doctor_users]
GO

CREATE TABLE [dbo].[office](
	[id] [int] NOT NULL,
	[streetAddress] [varchar](100) NOT NULL,
	[streetAddress2] [varchar](50) NULL,
	[city] [varchar](50) NOT NULL,
	[state] [varchar](50) NOT NULL,
	[zip] [int] NOT NULL,
	[phone] [int] NOT NULL,
	[officeHours] [int] NOT NULL,
 CONSTRAINT [PK_office] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[daysOfTheWeek](
	[dayId] [int] IDENTITY(1,1) NOT NULL,
	[day] [varchar](15) NOT NULL,
 CONSTRAINT [PK_daysOfTheWeek] PRIMARY KEY CLUSTERED 
(
	[dayId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[doctor_day](
	[doc_day_id] [int] NOT NULL,
	[doctorId] [int] NOT NULL,
	[dayId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_doctor_office_1] PRIMARY KEY CLUSTERED 
(
	[doc_day_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[doctor_day]  WITH CHECK ADD  CONSTRAINT [FK_doctor_day_doctor] FOREIGN KEY([doctorId])
REFERENCES [dbo].[doctor] ([userId])
GO

ALTER TABLE [dbo].[doctor_day] CHECK CONSTRAINT [FK_doctor_day_doctor]
GO

ALTER TABLE [dbo].[doctor_day]  WITH CHECK ADD  CONSTRAINT [FK_doctor_office_office] FOREIGN KEY([dayId])
REFERENCES [dbo].[daysOfTheWeek] ([dayId])
GO

ALTER TABLE [dbo].[doctor_day] CHECK CONSTRAINT [FK_doctor_office_office]
GO

CREATE TABLE [dbo].[docDay_office](
	[doctor_day_id] [int] NOT NULL,
	[officeId] [int] NOT NULL,
	[availability] [int] NOT NULL,
 CONSTRAINT [PK_docDay_office] PRIMARY KEY CLUSTERED 
(
	[doctor_day_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[docDay_office]  WITH CHECK ADD  CONSTRAINT [FK_docDay_office_doctor_day] FOREIGN KEY([doctor_day_id])
REFERENCES [dbo].[doctor_day] ([doc_day_id])
GO

ALTER TABLE [dbo].[docDay_office] CHECK CONSTRAINT [FK_docDay_office_doctor_day]
GO

ALTER TABLE [dbo].[docDay_office]  WITH CHECK ADD  CONSTRAINT [FK_docDay_office_office] FOREIGN KEY([officeId])
REFERENCES [dbo].[office] ([id])
GO

ALTER TABLE [dbo].[docDay_office] CHECK CONSTRAINT [FK_docDay_office_office]
GO

CREATE TABLE [dbo].[office_day](
	[id] [int] NOT NULL,
	[officeId] [int] NOT NULL,
	[dayId] [int] NOT NULL,
 CONSTRAINT [PK_office_day] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[office_day]  WITH CHECK ADD  CONSTRAINT [FK_office_day_daysOfTheWeek] FOREIGN KEY([dayId])
REFERENCES [dbo].[daysOfTheWeek] ([dayId])
GO

ALTER TABLE [dbo].[office_day] CHECK CONSTRAINT [FK_office_day_daysOfTheWeek]
GO

ALTER TABLE [dbo].[office_day]  WITH CHECK ADD  CONSTRAINT [FK_office_day_office] FOREIGN KEY([officeId])
REFERENCES [dbo].[office] ([id])
GO

ALTER TABLE [dbo].[office_day] CHECK CONSTRAINT [FK_office_day_office]
GO

CREATE TABLE [dbo].[officeReviews](
	[reviewId] [int] NOT NULL,
	[officeId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[message] [varchar](300) NOT NULL,
	[rating] [int] NOT NULL,
	[anonymous] [bit] NOT NULL,
 CONSTRAINT [PK_officeReviews] PRIMARY KEY CLUSTERED 
(
	[reviewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[officeReviews]  WITH CHECK ADD  CONSTRAINT [FK_officeReviews_office] FOREIGN KEY([officeId])
REFERENCES [dbo].[office] ([id])
GO

ALTER TABLE [dbo].[officeReviews] CHECK CONSTRAINT [FK_officeReviews_office]
GO

ALTER TABLE [dbo].[officeReviews]  WITH CHECK ADD  CONSTRAINT [FK_officeReviews_patients] FOREIGN KEY([userId])
REFERENCES [dbo].[patients] ([patientId])
GO

ALTER TABLE [dbo].[officeReviews] CHECK CONSTRAINT [FK_officeReviews_patients]
GO

CREATE TABLE [dbo].[reviewResponses](
	[responseId] [int] NOT NULL,
	[reviewId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[message] [varchar](300) NULL,
 CONSTRAINT [PK_reviewResponses] PRIMARY KEY CLUSTERED 
(
	[responseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[reviewResponses]  WITH CHECK ADD  CONSTRAINT [FK_reviewResponses_doctor] FOREIGN KEY([responseId])
REFERENCES [dbo].[doctor] ([userId])
GO

ALTER TABLE [dbo].[reviewResponses] CHECK CONSTRAINT [FK_reviewResponses_doctor]
GO

ALTER TABLE [dbo].[reviewResponses]  WITH CHECK ADD  CONSTRAINT [FK_reviewResponses_officeReviews] FOREIGN KEY([reviewId])
REFERENCES [dbo].[officeReviews] ([reviewId])
GO

ALTER TABLE [dbo].[reviewResponses] CHECK CONSTRAINT [FK_reviewResponses_officeReviews]
GO