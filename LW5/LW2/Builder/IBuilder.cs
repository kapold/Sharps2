using System;

namespace LW2;

public interface IBuilder
{
    void BuildSurName(string surname);
    void BuildName(string name);
    void BuildPatronymic(string patronymic);
    void BuildDateOfBirth(DateTime dateOfBirth);
    void BuildCourse(int course);
    void BuildGroup(int group);
    void BuildMale(string male);
    void BuildSpeciality(string speciality);
    void BuildAvgMark(float avgMark);
    void BuildAdress(Address adress);
}