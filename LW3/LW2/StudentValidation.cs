using System;
using System.ComponentModel.DataAnnotations;

namespace LW2;

public class StudentValidation : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        Student student = value as Student;
        if (Convert.ToString(student.address.index)[0] != '2')
        {
            ErrorMessage = "Индекс должен начинаться с двойки";
            return false;
        }
        return true;
    }
}