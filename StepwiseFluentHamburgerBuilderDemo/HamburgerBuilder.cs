using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepwiseFluentHamburgerBuilderDemo
{
    public class HamburgerBuilder
    {
        private class Impl :
            ISpecifyHamburgerType,
            ISpecifyBunServing,
            ISpecifyLettuceServing,
            ISpecifyCheeseServing,
            ISpecifyOnionServing,
            ISpecifyPattyServing,
            ISpecifyKetchupServing,
            ISpecifyCucumberServing,
            ISpecifyTomatoServing,
            IBuildHamburger
        {
            private Hamburger burger = new Hamburger();
            public Hamburger Build()
            {
                return burger;
            }

            public ISpecifyBunServing OfType(HamburgerType type)
            {
                burger.Type = type;
                return this;
            }

            public ISpecifyLettuceServing WithBun(ServingSize size)
            {
                burger.BunServing = size;
                return this;
            }

            public ISpecifyOnionServing WithCheese(ServingSize size)
            {
                burger.CheeseServing = size;
                return this;
            }

            public ISpecifyTomatoServing WithCucumber(ServingSize size)
            {
                burger.CucumberServing = size;
                return this;
            }

            public ISpecifyCucumberServing WithKetchup(ServingSize size)
            {
                burger.KetchupServing = size;
                return this;
            }

            public ISpecifyCheeseServing WithLettuce(ServingSize size)
            {
                burger.LettuceServing = size;
                return this;
            }

            public ISpecifyPattyServing WithOnion(ServingSize size)
            {
                burger.OnionServing = size;
                return this;
            }

            public ISpecifyKetchupServing WithPatty(ServingSize size)
            {
                burger.PattyServing = size;
                return this;
            }

            public IBuildHamburger WithTomato(ServingSize size)
            {
                burger.TomatoServing = size;
                return this;
            }
        }
        public static ISpecifyHamburgerType Create()
        {
            return new Impl();
        }
    }
}
