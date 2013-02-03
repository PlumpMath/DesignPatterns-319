using Factory_Pattern.Simple_Factory.Concrete;

namespace Factory_Pattern.Simple_Factory.Contract
{
    public interface IPizzaFactory
    {
        IPizza CreatePizza(PizzaType type);
    }
}
