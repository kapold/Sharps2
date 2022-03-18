using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace LW2;

public static class XmlSerialize
{
    public static void Serialize(List<Student> obj, string fileName)
    {
        XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));

        using (StreamWriter sw = new StreamWriter(fileName, false))
        {
            formatter.Serialize(sw, obj);
        }
    }
        
    public static Student[] Deserialize(string fileName)
    {
        XmlSerializer formatter = new XmlSerializer(typeof(Student[]));
        Student[] students;
            
        using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
        {
            students = (Student[]) formatter.Deserialize(fs);
        }

        return students;
    }
}