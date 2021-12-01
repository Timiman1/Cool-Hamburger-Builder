namespace StepwiseFluentHamburgerBuilderDemo
{
    public interface ISpecifyPattyServing
    {
        ISpecifyKetchupServing WithPatty(ServingSize size);
    }
}