create database CaseStudyDB

use CaseStudyDB

create table Student(StudentId int primary key, StudentName varchar(20), DateOfBirth varchar(20))

create table Course (CourseId int primary key, CourseName varchar(20), Duration int, CourseFees varchar(20))

create table Enroll (StudentId int, CourseId int, foreign key(StudentId) references student(studentId),foreign key(CourseId) references Course(CourseId), DateOfEnroll varchar(20))

Drop table Student

Drop table Course

select * from student

select * from Course

Drop table Enroll