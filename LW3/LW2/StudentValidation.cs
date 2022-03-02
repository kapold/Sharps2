using System.ComponentModel.DataAnnotations;

namespace LW2;

public class StudentValidation : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        Student student = value as Student;
        if (student.address.index == 000000 ||
            student.address.index == 111111 || 
            student.address.index == 222222 || 
            student.address.index == 333333 || 
            student.address.index == 444444 || 
            student.address.index == 555555 || 
            student.address.index == 666666 || 
            student.address.index == 777777 || 
            student.address.index == 888888 || 
            student.address.index == 999999)
        {
            ErrorMessage = "В индексе все цифры не могут быть одинаковыми!!!";
            return false;
        }
        return true;
    }
}