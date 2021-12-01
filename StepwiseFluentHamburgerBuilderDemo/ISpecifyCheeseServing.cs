namespace StepwiseFluentHamburgerBuilderDemo
{
    public interface ISpecifyCheeseServing
    {
        ISpecifyOnionServing WithCheese(ServingSize size);
    }
}