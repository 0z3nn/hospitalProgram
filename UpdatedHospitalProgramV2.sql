USE [UserAuthDB]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 02/05/2025 8:55:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[appointment_id] [int] IDENTITY(1,1) NOT NULL,
	[doctorid] [int] NULL,
	[patientid] [int] NULL,
	[appointment_date] [datetime] NULL,
	[symptoms] [nvarchar](255) NULL,
	[status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[appointment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 02/05/2025 8:55:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[userid] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Specialty] [nvarchar](100) NULL,
	[Phone] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[startTime] [time](7) NULL,
	[endTime] [time](7) NULL,
	[schedule] [nvarchar](50) NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientInformation]    Script Date: 02/05/2025 8:55:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientInformation](
	[userid] [int] NULL,
	[age] [nvarchar](10) NULL,
	[bloodtype] [nvarchar](4) NULL,
	[conditions] [nvarchar](255) NULL,
	[allergies] [nvarchar](255) NULL,
	[labresults] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 02/05/2025 8:55:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[userid] [int] NOT NULL,
	[firstname] [nvarchar](100) NULL,
	[lastname] [nvarchar](100) NULL,
	[gender] [nvarchar](10) NULL,
	[dateofbirth] [date] NULL,
	[address] [nvarchar](255) NULL,
	[phone] [nvarchar](20) NULL,
 CONSTRAINT [PK__Patients__3213E83F1A5C89B8] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 02/05/2025 8:55:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](30) NOT NULL,
	[password] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 

INSERT [dbo].[Appointments] ([appointment_id], [doctorid], [patientid], [appointment_date], [symptoms], [status]) VALUES (1, 2, 4, CAST(N'2025-05-04T00:00:00.000' AS DateTime), N'Headaches', N'Completed')
SET IDENTITY_INSERT [dbo].[Appointments] OFF
GO
INSERT [dbo].[Doctors] ([userid], [Name], [Specialty], [Phone], [Email], [startTime], [endTime], [schedule]) VALUES (1, N'Dr.JoneDoe', N'Cardiologist', N'09555123456', N'john@hospital.com', CAST(N'07:00:00' AS Time), CAST(N'15:00:00' AS Time), N'Monday-Saturday')
INSERT [dbo].[Doctors] ([userid], [Name], [Specialty], [Phone], [Email], [startTime], [endTime], [schedule]) VALUES (2, N'Dr.Keanu Miguel Nael', N'Neurologist', N'09065125656', N'keanu@hospital.com', CAST(N'09:00:00' AS Time), CAST(N'18:00:00' AS Time), N'Tuesday-Saturday')
INSERT [dbo].[Doctors] ([userid], [Name], [Specialty], [Phone], [Email], [startTime], [endTime], [schedule]) VALUES (3, N'Dr. Errol John Matienzo', N'Pediatrician', N'09951128496', N'derrol@hospital.com', CAST(N'06:00:00' AS Time), CAST(N'20:00:00' AS Time), N'monday-friday')
GO
INSERT [dbo].[PatientInformation] ([userid], [age], [bloodtype], [conditions], [allergies], [labresults]) VALUES (4, N'53', N'O+', N'Arthritis', N'Sea Foods, Nuts', N'Diagnosed with Arthritis on (January 12, 2024).')
GO
INSERT [dbo].[Patients] ([userid], [firstname], [lastname], [gender], [dateofbirth], [address], [phone]) VALUES (4, N'Douglas', N'McArthur', N'Male', CAST(N'1984-02-17' AS Date), N'32 Blk 21 Durian St. Makati City', N'09234106788')
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [username], [password]) VALUES (1, N'johndoe', N'doctor123')
INSERT [dbo].[Users] ([id], [username], [password]) VALUES (2, N'keanunael', N'doctor123')
INSERT [dbo].[Users] ([id], [username], [password]) VALUES (3, N'drerrol', N'doctor123')
INSERT [dbo].[Users] ([id], [username], [password]) VALUES (4, N'douglas', N'puffy123')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__F3DBC572C95A76CA]    Script Date: 02/05/2025 8:55:12 pm ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD FOREIGN KEY([doctorid])
REFERENCES [dbo].[Doctors] ([userid])
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD FOREIGN KEY([patientid])
REFERENCES [dbo].[Patients] ([userid])
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD  CONSTRAINT [FK__Doctors__userid__59063A47] FOREIGN KEY([userid])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Doctors] CHECK CONSTRAINT [FK__Doctors__userid__59063A47]
GO
ALTER TABLE [dbo].[PatientInformation]  WITH CHECK ADD FOREIGN KEY([userid])
REFERENCES [dbo].[Patients] ([userid])
GO
ALTER TABLE [dbo].[Patients]  WITH CHECK ADD  CONSTRAINT [FK__Patients__userid__5EBF139D] FOREIGN KEY([userid])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Patients] CHECK CONSTRAINT [FK__Patients__userid__5EBF139D]
GO
