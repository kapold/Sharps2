using System.Windows.Forms;

namespace LW2.Abstract_Factory;

class PupilF : LearnerProduct // ученик
{
    public string name;
    public string surname;
    public string patronymic;

    public PupilF()
    {
        name = "Кирилл";
        surname = "Хаританович";
        patronymic = "Дмитриевич";
    }
    public override void LearnerInfo()
    {
        MessageBox.Show($"Учащийся: Школьник\n\n" +
                        $"Фамилия: {surname}\n" +
                        $"Имя: {name}\n" +
                        $"Отчество: {patronymic}\n");
    }
}