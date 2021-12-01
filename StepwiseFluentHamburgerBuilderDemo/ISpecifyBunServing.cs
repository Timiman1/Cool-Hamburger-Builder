namespace StepwiseFluentHamburgerBuilderDemo
{
    public interface ISpecifyBunServing
    {
        ISpecifyLettuceServing WithBun(ServingSize size);
    }
}