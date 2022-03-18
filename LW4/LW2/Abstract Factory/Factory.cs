namespace LW2.Abstract_Factory;

class Factory
{
    private LearnerProduct learner;
    private TeachingProduct teaching;

    public Factory(AbstractFactory factory)
    {
        learner = factory.CreateLearner();
        teaching = factory.CreateTeaching();
    }

    public void InfoAboutFactory()
    {
        learner.LearnerInfo();
        teaching.TeachingInfo();
    }
}