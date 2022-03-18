namespace LW2.Proxy;

public class Proxy : ISubject
{
    private Student student;

    public Proxy(Student student)
    {
        this.student = student;
    }
    
    public void GetInfo()
    {
        if (student == null)
            student = new Student();

        student.GetInfo();
    }

    public void DeacreaseMark()
    {
        if (student == null)
            student = new Student();
        
        student.DeacreaseMark();
    }
}