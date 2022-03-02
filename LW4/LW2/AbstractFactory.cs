using System.Windows.Forms;

namespace LW2;

// абстрактный класс - травоядные
abstract class Herbivore
{ }
// абстрактный класс - хищник
abstract class Carnivore
{
    public abstract void Eat(Herbivore h);
}
 
// хищник ЛЕВ
class Lion : Carnivore
{
    public override void Eat(Herbivore h)
    {
        // Eat Wildebeest
        MessageBox.Show(this.GetType().Name + " охотится на " + h.GetType().Name);
    }
}
// травоядная АНТИЛОПА
class Antelope : Herbivore
{ }
// травоядный БИЗОН
class Bison : Herbivore
{ }
// хищник ВОЛК
class Wolf : Carnivore
{
    public override void Eat(Herbivore h)
    {
        // Eat Bison
        MessageBox.Show(this.GetType().Name + " охотится на " + h.GetType().Name);
    }
}
// класс абстрактной фабрики
abstract class ContinentFactory
{
    public abstract Herbivore CreateHerbivore();
    public abstract Carnivore CreateCarnivore();
}
// Фабрика создания цепочки АНТИЛОПА-ЛЕВ
class AfricaFactory : ContinentFactory
{
    public override Herbivore CreateHerbivore()
    {
        return new Antelope();
    }
    public override Carnivore CreateCarnivore()
    {
        return new Lion();
    }
}
// Фабрика создания цепочки БИЗОН-ВОЛК
class AmericaFactory : ContinentFactory
{
    public override Herbivore CreateHerbivore()
    {
        return new Bison();
    }
    public override Carnivore CreateCarnivore()
    {
        return new Wolf();
    }
}

class AnimalWorld
{
    private Herbivore herbivore;
    private Carnivore carnivore;
    // Constructor
    public AnimalWorld(ContinentFactory factory)
    {
        carnivore = factory.CreateCarnivore();
        herbivore = factory.CreateHerbivore();
    }
    public void RunFoodChain()
    {
        carnivore.Eat(herbivore);
    }
}