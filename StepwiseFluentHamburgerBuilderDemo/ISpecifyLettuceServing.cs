namespace StepwiseFluentHamburgerBuilderDemo
{
    public interface ISpecifyLettuceServing
    {
        ISpecifyCheeseServing WithLettuce(ServingSize size);
    }
}