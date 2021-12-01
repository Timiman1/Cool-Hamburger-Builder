using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StepwiseFluentHamburgerBuilderDemo
{
    public class Hamburger
    {
        public HamburgerType Type { get; set; }
        public ServingSize BunServing { get; set; }
        public ServingSize LettuceServing { get; set; }
        public ServingSize CheeseServing { get; set; }
        public ServingSize OnionServing { get; set; }
        public ServingSize PattyServing { get; set; }
        public ServingSize KetchupServing { get; set; }
        public ServingSize CucumberServing { get; set; }
        public ServingSize TomatoServing { get; set; }

        private PropertyInfo[] _PropertyInfos = null;
        
        public override string ToString()
        {
            if (_PropertyInfos == null)
                _PropertyInfos = this.GetType().GetProperties();

            var sb = new StringBuilder();

            foreach (var info in _PropertyInfos)
            {
                var value = info.GetValue(this, null) ?? "(null)";
                sb.AppendLine(info.Name + ": " + value.ToString());
            }

            return sb.ToString();
        }
    }
}
