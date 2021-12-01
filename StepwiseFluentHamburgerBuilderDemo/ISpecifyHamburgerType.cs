using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepwiseFluentHamburgerBuilderDemo
{
    public interface ISpecifyHamburgerType
    {
        ISpecifyBunServing OfType(HamburgerType type);
    }
}
