using System;

namespace LW2;

class StudentBuilder : IBuilder
{
    private Student student = new Student();

    public StudentBuilder()
    {
        Reset();
    }

    public Student GetStudent()
    {
        Student result = student;

        Reset();

        return result;
    }

    public void Reset()
    {
        student = new Student();
    }

    public void BuildAdress(Address adress)
    {
        student.address = adress;
    }

    public void BuildAvgMark(float avgMark)
    {
        student.averageMark = avgMark;
    }

    public void BuildCourse(int course)
    {
        student.course = course;

    }

    public void BuildDateOfBirth(DateTime dateOfBirth)
    {
        student.birthday = dateOfBirth;

    }

    public void BuildGroup(int group)
    {
        student.group = group;
    }

    public void BuildName(string name)
    {
        student.name = name;
    }

    public void BuildPatronymic(string patronymic)
    {
        student.secondName = patronymic;
    }

    public void BuildMale(string sex)
    {
        student.male = sex;
    }

    public void BuildSpeciality(string speciality)
    {
        student.speciality = speciality;

    }

    public void BuildSurName(string surname)
    {
        student.surname = surname;
    }
}