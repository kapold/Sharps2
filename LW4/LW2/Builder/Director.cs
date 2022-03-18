using System;

namespace LW2;

public class Director
{
        private IBuilder builder;

        public IBuilder Builder
        {
            set
            {
                builder = value;
            }
        }

        Random ranNum = new Random();

        public void BuildRandomStudent()
        {
            string Surname = getRanSurname();
            string Name;
            string Patronymic;

            string Sex = getRanSex();
            if (Sex == "Male")
            {
                 Name = getRanManName();
                 Patronymic = getRanManPatronymic();
            }
            else
            {
                 Name = getRanWomanName();
                 Patronymic = getRanWomanPatronymic();
            }
            
            int Course = getRanCourse();
            string Speciality = getRanSpeciality();
            int Group = getRanGroup();
            DateTime DateOfBirth = getDateOfBirth();
            float AvgMark = getRanAvgMark();

            Address address = new Address();

            string Country = getRanCity();
            string Street = getRanStreet();
            int Home = getRanHouse();
            int Index = getRanIndex();

            address.city = Country;
            address.street = Street;
            address.home = Home;
            address.index = Index;

            builder.BuildSurName(Surname);
            builder.BuildName(Name);
            builder.BuildPatronymic(Patronymic);
            builder.BuildMale(Sex);
            builder.BuildSpeciality(Speciality);
            builder.BuildCourse(Course);
            builder.BuildGroup(Group);
            builder.BuildAvgMark(AvgMark);
            builder.BuildDateOfBirth(DateOfBirth);
            builder.BuildAdress(address);
        }

        public string getRanSex()
        {
            string[] sex = { "Male", "Female" };
            string result = sex[ranNum.Next(0, sex.Length)];
            return result;
        }

        public string getRanManName()
        {
            string[] manNames = { "Иван", "Максим", "Дмитрий", "Антон", "Роман" };
            return manNames[ranNum.Next(0, manNames.Length)];
        }

        public string getRanWomanName()
        {
            string[] womanNames = { "Алина", "Лерка", "Алена", "Оля", "Виктория" };
            return womanNames[ranNum.Next(0, womanNames.Length)];
        }

        public string getRanSurname()
        {
            string[] surnames = { "Машук", "Каленик", "Адамович", "Котович", "Шиман" };
            return surnames[ranNum.Next(0, surnames.Length)];
        }

        public string getRanManPatronymic()
        {
            string[] manPatronymics = { "Сергеевич", "Игоревич", "Владимирович", "Александрович", "Владимирович" };
            return manPatronymics[ranNum.Next(0, manPatronymics.Length)];
        }

        public string getRanWomanPatronymic()
        {
            string[] womanPatronymics = { "Сергеевна", "Игоревна", "Владимировна", "Александровна", "Владимировна" };
            return womanPatronymics[ranNum.Next(0, womanPatronymics.Length)];
        }

        public string getRanSpeciality()
        {
            string[] specialities = { "ПОИТ", "ИСИТ", "ДЭВИ", "ПОИБМС" };
            return specialities[ranNum.Next(0, specialities.Length )];
        }

        public float getRanAvgMark()
        {
            return ranNum.Next(4, 10) + (float)ranNum.Next(0, 11)/10;
        }

        public string getRanCity()
        {
            string[] countries = { "Несвиж", "Столбцы", "Минск", "Городея" };
            return countries[ranNum.Next(0, countries.Length )];
        }

        public string getRanStreet()
        {
            string[] streets = { "Победа", "Мая", "Ленина", "Сталина" };
            return streets[ranNum.Next(0, streets.Length)];
        }

        public int getRanHouse()
        {
            return ranNum.Next(1, 200);
        }

        public int getRanIndex()
        {
            return ranNum.Next(100000, 999999);
        }

        public int getRanCourse()
        {
            return ranNum.Next(1, 4);
        }

        public int getRanGroup()
        {
            return ranNum.Next(1, 10);
        }

        public DateTime getDateOfBirth()
        {
            int year = ranNum.Next(1990, 2005);
            int month = ranNum.Next(1, 13);
            int day = ranNum.Next(1, 29);

            DateTime dateOfBirth = new DateTime(year, month, day);
            return dateOfBirth;
        }
}