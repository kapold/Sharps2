using System.Windows.Forms;

namespace LW2.Abstract_Factory;

class LecturerF : TeachingProduct // преподаватель
{
    public string name;
    public string surname;
    public string patronymic;

    public LecturerF()
    {
        name = "Евгения";
        surname = "Блинова";
        patronymic = "Александровна";
    }
    public override void TeachingInfo()
    {
        MessageBox.Show($"Обучающий: Преподаватель\n\n" +
                        $"Фамилия: {surname}\n" +
                        $"Имя: {name}\n" +
                        $"Отчество: {patronymic}\n");
    }
}