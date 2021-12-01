namespace StepwiseFluentHamburgerBuilderDemo
{
    public interface ISpecifyTomatoServing
    {
        IBuildHamburger WithTomato(ServingSize size);
    }
}