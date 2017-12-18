using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFBootstrapper.Extensibility
{
    public abstract class ConfigurationControl
    {
        public string OptionIdentifier { get; private set; }
        public string OptionDisplayName { get; private set; }
        public string OptionDescription { get; private set; }

        public string ControlType { get; private set; }
        public ConfigurationControl(string optionIdentifier, string optionName, string optionDescription, string controlType)
        {
            OptionIdentifier = optionIdentifier;
            OptionDisplayName = optionName;
            OptionDescription = optionDescription;
            ControlType = controlType;
        }
    }

    public class TextConfigurationControl : ConfigurationControl
    {
        public string PlaceholderText { get; private set; }
        public string DefaultValue { get; private set; }
        public TextConfigurationControl(string optionIdentifier, string optionName, string optionDescription, string placeholderText = "", string defaultValue = "") : base(optionIdentifier, optionName, optionDescription, "text")
        {
            PlaceholderText = placeholderText;
            DefaultValue = defaultValue;
        }
    }

    public class NumericalConfigurationControl : ConfigurationControl
    {
        public NumericalConfigurationControl(string optionIdentifier, string optionName, string optionDescription) : base(optionIdentifier, optionName, optionDescription, "numerical")
        {

        }
    }

    public class OptionConfigurationControl : ConfigurationControl
    {
        public bool Multiselect { get; private set; }
        public OptionConfigurationControl(string optionIdentifier, string optionName, string optionDescription, bool multiselect = false) : base(optionIdentifier, optionName, optionDescription, "option")
        {
            Multiselect = multiselect;
        }

        public List<OptionConfigurationControlChoice> Options { get; set; } = new List<OptionConfigurationControlChoice>();

    }

    public class OptionConfigurationControlChoice
    {
        public string Identifier { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}
