namespace LW2.Abstract_Factory;

abstract class AbstractFactory
{
    public abstract LearnerProduct CreateLearner();
    public abstract TeachingProduct CreateTeaching();
}