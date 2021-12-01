namespace StepwiseFluentHamburgerBuilderDemo
{
    public interface ISpecifyCucumberServing
    {
        ISpecifyTomatoServing WithCucumber(ServingSize size);
    }
}