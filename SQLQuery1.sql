select c.CourseId,c.CourseName,s.StudentId,s.FirstName,s.LastName from Course c
INNER Join TakedCourse tk
on 
c.CourseId = tk.CourseId
join Student s
on
tk.StudentId = s.StudentId
and s.StudentId=920605

select Course.CourseId,Course.CourseName from Course
JOIN
TakedCourse
ON
Course.CourseId = TakedCourse.CourseId
AND
TakedCourse.StudentId = 920601



alter table term
drop constraint StudentId

alter table term 
drop column StudentId,CourseId

insert into Term (TermId,TermName) values (2,'93-2')


select * from Term


delete  from student where StudentId = 920601