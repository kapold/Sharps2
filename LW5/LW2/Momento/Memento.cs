using System;

namespace LW2;

public class Memento
{
    public string name { set; get; }
    public string secondName { set; get; }
    public string surname { set; get; }
    public string speciality { set; get; }
    public DateTime birthday { set; get; }
    public int course { set; get; }
    public int group { set; get; }
    public string male { set; get; }
    public float averageMark { set; get; }

    public Memento(string name, string secondName, string surname, string speciality, DateTime birthday, int course, int group, string male, float Mark)
    {
        this.name = name;
        this.secondName = secondName;
        this.surname = surname;
        this.speciality = speciality;
        this.birthday = birthday;
        this.course = course;
        this.group = group;
        this.male = male;
        this.averageMark = Mark;
    }
}