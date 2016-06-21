namespace PizzaMaker.Logic.Decorators
{
    using Models.BaseClasses;
    using Models.Interfaces;
    using Models.Models;

    public class SausageDecorator : Decorator
    {
        public SausageDecorator(IPizza pizza) 
            : base(pizza)
        {
        }

        public override void Decorate()
        {
            this.Pizza.Additions.Add(new Sausage(1));
        }
    }
}
