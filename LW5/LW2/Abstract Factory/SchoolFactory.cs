namespace LW2.Abstract_Factory;

class SchoolFactory : AbstractFactory
{
    public override LearnerProduct CreateLearner()
    {
        return new PupilF();
    }

    public override TeachingProduct CreateTeaching()
    {
        return new TeacherF();
    }
}