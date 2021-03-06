USE [School Manangment System]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 04/08/2019 15:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[book_id] [int] IDENTITY(1,1) NOT NULL,
	[book_name] [nvarchar](50) NOT NULL,
	[book_writer] [nvarchar](50) NOT NULL,
	[book_type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[book_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 04/08/2019 15:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[expense_id] [int] IDENTITY(1,1) NOT NULL,
	[expense_name] [nvarchar](50) NOT NULL,
	[date_of_expense] [datetime] NOT NULL,
	[expense_amount] [bigint] NOT NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[expense_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 04/08/2019 15:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[course_id] [int] IDENTITY(1,1) NOT NULL,
	[course_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[course_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 04/08/2019 15:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[teacher_id] [int] IDENTITY(1,1) NOT NULL,
	[teacher_name] [nvarchar](50) NOT NULL,
	[gender] [nvarchar](50) NOT NULL,
	[contact_number] [bigint] NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[date_of_birth] [nvarchar](50) NOT NULL,
	[religion] [nvarchar](50) NOT NULL,
	[qualification] [nvarchar](50) NOT NULL,
	[salary] [int] NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[teacher_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 04/08/2019 15:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[student_id] [int] IDENTITY(1,1) NOT NULL,
	[student_name] [nvarchar](50) NOT NULL,
	[father_name] [nvarchar](50) NOT NULL,
	[gender] [nvarchar](50) NOT NULL,
	[date_of_birth] [int] NOT NULL,
	[religion] [nvarchar](50) NOT NULL,
	[nationality] [nvarchar](50) NOT NULL,
	[student_address] [nvarchar](50) NOT NULL,
	[student_cell_number] [int] NOT NULL,
	[date_of_addmission] [datetime] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 04/08/2019 15:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staffs](
	[staff_id] [int] IDENTITY(1,1) NOT NULL,
	[staff_name] [nvarchar](50) NOT NULL,
	[gender] [nvarchar](50) NOT NULL,
	[contact_number] [bigint] NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[date_of_birth] [nvarchar](50) NOT NULL,
	[religion] [nvarchar](50) NOT NULL,
	[designation] [nvarchar](50) NOT NULL,
	[salary] [int] NOT NULL,
 CONSTRAINT [PK_Staffs] PRIMARY KEY CLUSTERED 
(
	[staff_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Signups]    Script Date: 04/08/2019 15:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Signups](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Signups] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers_Salaries]    Script Date: 04/08/2019 15:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers_Salaries](
	[teacher_id] [int] NOT NULL,
	[teacher_name] [nvarchar](50) NOT NULL,
	[teacher_salary] [bigint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parents]    Script Date: 04/08/2019 15:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parents](
	[parent_id] [int] IDENTITY(1,1) NOT NULL,
	[parent_name] [nvarchar](50) NOT NULL,
	[gender] [nvarchar](50) NOT NULL,
	[contact_number] [bigint] NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[date_of_birth] [int] NOT NULL,
	[religion] [nvarchar](50) NOT NULL,
	[relationship_with_student] [nvarchar](50) NOT NULL,
	[student_id] [int] NULL,
 CONSTRAINT [PK_Parents] PRIMARY KEY CLUSTERED 
(
	[parent_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Liabrary_Books_Issue]    Script Date: 04/08/2019 15:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Liabrary_Books_Issue](
	[book_id] [int] NOT NULL,
	[student_id] [int] NOT NULL,
	[returning_date] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff_Salaries]    Script Date: 04/08/2019 15:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff_Salaries](
	[staff_id] [int] NOT NULL,
	[staff_name] [nvarchar](50) NOT NULL,
	[staff_salary] [bigint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 04/08/2019 15:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[class_id] [int] IDENTITY(1,1) NOT NULL,
	[course_id] [int] NOT NULL,
	[teacher_id] [int] NOT NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[class_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exams]    Script Date: 04/08/2019 15:16:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exams](
	[exam_id] [int] IDENTITY(1,1) NOT NULL,
	[exam_type] [nvarchar](50) NOT NULL,
	[class_id] [int] NOT NULL,
 CONSTRAINT [PK_Exams] PRIMARY KEY CLUSTERED 
(
	[exam_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__Students__date_o__31EC6D26]    Script Date: 04/08/2019 15:16:24 ******/
ALTER TABLE [dbo].[Students] ADD  DEFAULT (getdate()) FOR [date_of_addmission]
GO
/****** Object:  Check [CHK2_gender]    Script Date: 04/08/2019 15:16:24 ******/
ALTER TABLE [dbo].[Staffs]  WITH CHECK ADD  CONSTRAINT [CHK2_gender] CHECK  (([gender]='male' OR [gender]='female'))
GO
ALTER TABLE [dbo].[Staffs] CHECK CONSTRAINT [CHK2_gender]
GO
/****** Object:  Check [CHK_gender]    Script Date: 04/08/2019 15:16:24 ******/
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [CHK_gender] CHECK  (([gender]='male' OR [gender]='female'))
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [CHK_gender]
GO
/****** Object:  Check [CHK1_gender]    Script Date: 04/08/2019 15:16:24 ******/
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [CHK1_gender] CHECK  (([gender]='male' OR [gender]='female'))
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [CHK1_gender]
GO
/****** Object:  ForeignKey [FK__Classes__course___164452B1]    Script Date: 04/08/2019 15:16:24 ******/
ALTER TABLE [dbo].[Classes]  WITH CHECK ADD FOREIGN KEY([course_id])
REFERENCES [dbo].[Courses] ([course_id])
GO
/****** Object:  ForeignKey [FK__Classes__teacher__1273C1CD]    Script Date: 04/08/2019 15:16:24 ******/
ALTER TABLE [dbo].[Classes]  WITH CHECK ADD  CONSTRAINT [FK__Classes__teacher__1273C1CD] FOREIGN KEY([teacher_id])
REFERENCES [dbo].[Teachers] ([teacher_id])
GO
ALTER TABLE [dbo].[Classes] CHECK CONSTRAINT [FK__Classes__teacher__1273C1CD]
GO
/****** Object:  ForeignKey [FK__Exams__class_id__182C9B23]    Script Date: 04/08/2019 15:16:24 ******/
ALTER TABLE [dbo].[Exams]  WITH CHECK ADD FOREIGN KEY([class_id])
REFERENCES [dbo].[Classes] ([class_id])
GO
/****** Object:  ForeignKey [FK__Liabrary___book___15502E78]    Script Date: 04/08/2019 15:16:24 ******/
ALTER TABLE [dbo].[Liabrary_Books_Issue]  WITH CHECK ADD  CONSTRAINT [FK__Liabrary___book___15502E78] FOREIGN KEY([book_id])
REFERENCES [dbo].[Books] ([book_id])
GO
ALTER TABLE [dbo].[Liabrary_Books_Issue] CHECK CONSTRAINT [FK__Liabrary___book___15502E78]
GO
/****** Object:  ForeignKey [FK__Liabrary___stude__164452B1]    Script Date: 04/08/2019 15:16:24 ******/
ALTER TABLE [dbo].[Liabrary_Books_Issue]  WITH CHECK ADD  CONSTRAINT [FK__Liabrary___stude__164452B1] FOREIGN KEY([student_id])
REFERENCES [dbo].[Students] ([student_id])
GO
ALTER TABLE [dbo].[Liabrary_Books_Issue] CHECK CONSTRAINT [FK__Liabrary___stude__164452B1]
GO
/****** Object:  ForeignKey [FK__Parents__student__38996AB5]    Script Date: 04/08/2019 15:16:24 ******/
ALTER TABLE [dbo].[Parents]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[Students] ([student_id])
GO
/****** Object:  ForeignKey [FK__Staff_Sal__staff__173876EA]    Script Date: 04/08/2019 15:16:24 ******/
ALTER TABLE [dbo].[Staff_Salaries]  WITH CHECK ADD  CONSTRAINT [FK__Staff_Sal__staff__173876EA] FOREIGN KEY([staff_id])
REFERENCES [dbo].[Staffs] ([staff_id])
GO
ALTER TABLE [dbo].[Staff_Salaries] CHECK CONSTRAINT [FK__Staff_Sal__staff__173876EA]
GO
/****** Object:  ForeignKey [FK__Teachers___teach__182C9B23]    Script Date: 04/08/2019 15:16:24 ******/
ALTER TABLE [dbo].[Teachers_Salaries]  WITH CHECK ADD  CONSTRAINT [FK__Teachers___teach__182C9B23] FOREIGN KEY([teacher_id])
REFERENCES [dbo].[Teachers] ([teacher_id])
GO
ALTER TABLE [dbo].[Teachers_Salaries] CHECK CONSTRAINT [FK__Teachers___teach__182C9B23]
GO
