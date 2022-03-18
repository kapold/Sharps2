namespace LW2.Abstract_Factory;

class UniverFactory : AbstractFactory
{
    public override LearnerProduct CreateLearner()
    {
        return new StudentF();
    }

    public override TeachingProduct CreateTeaching()
    {
        return new LecturerF();
    }
}