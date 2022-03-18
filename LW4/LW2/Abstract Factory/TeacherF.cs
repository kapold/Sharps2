using System.Windows.Forms;

namespace LW2.Abstract_Factory;

class TeacherF :  TeachingProduct // учитель
{
    public string name;
    public string surname;
    public string patronymic;

    public TeacherF()
    {
        name = "Врублевская";
        surname = "Ольга";
        patronymic = "Михайловна";
    }
    public override void TeachingInfo()
    {
        MessageBox.Show($"Обучающий: Учитель\n\n" +
                        $"Фамилия: {surname}\n" +
                        $"Имя: {name}\n" +
                        $"Отчество: {patronymic}\n");
    }
}