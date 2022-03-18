using System.Windows.Forms;

namespace LW2.Abstract_Factory;

class StudentF : LearnerProduct // студент
{
    public string name;
    public string surname;
    public string patronymic;

    public StudentF()
    {
        name = "Дима";
        surname = "Заянковский";
        patronymic = "Владимирович";
    }
    public override void LearnerInfo()
    {
        MessageBox.Show($"Учащийся: Студент\n\n" +
                        $"Фамилия: {surname}\n" +
                        $"Имя: {name}\n" +
                        $"Отчество: {patronymic}\n");
    }
}