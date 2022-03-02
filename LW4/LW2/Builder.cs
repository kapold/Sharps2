using System;
namespace LW2;

class Univer
{
    public StudentB Study(StudentBuilder studBuild)
    {
        studBuild.CreateStudent();
        studBuild.SetName();
        studBuild.SetCourse();
        studBuild.SetGroup();

        return studBuild.student;
    }
}

abstract class StudentBuilder
{
    public StudentB student { get; private set; }
    public void CreateStudent()
    {
        student = new StudentB();
    }
    
    public abstract void SetName();
    public abstract void SetCourse();
    public abstract void SetGroup();
}

class StudentB
{
    public FIO name { set; get; }
    public Course course { set; get; }
    public Group group { set; get; }
    
    public override string ToString()
    {
        return $"Name: {name.name}\nCourse: {course.course}\nGroup: {group.group}";
    }
}

class FIO
{
    public string name { set; get; }
}

class Course
{
    public string course { set; get; }
}

class Group
{
    public int group { set; get; }   
}

class Student1C : StudentBuilder
{
    Random rnd = new Random();
    public override void SetName()
    {
        student.name = new FIO {name = "qwerty1234"};
    }

    public override void SetCourse()
    {
        student.course = new Course {course = "Студент первого курса"};
    }

    public override void SetGroup()
    {
        student.group = new Group {group = rnd.Next(1, 10)};
    }
}

class Student2C : StudentBuilder
{
    Random rnd = new Random();
    public override void SetName()
    {
        this.student.name = new FIO {name = "Alex"};
    }

    public override void SetCourse()
    {
        this.student.course = new Course {course = "Студент второго курса"};
    }

    public override void SetGroup()
    {
        this.student.group = new Group {group = rnd.Next(1, 10)};
    }
}