
namespace Factory_Pattern.Simple_Factory.Contract
{
    public interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
}
