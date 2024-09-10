using System;

namespace OpenExamStudio.Designer
{
    public class EnvironmentVariableProvider
    {
        public EnvironmentVariableProvider() { }
        public string GetEnvironmentVariable(string name)
        {
            return Environment.GetEnvironmentVariable(name, EnvironmentVariableTarget.Machine);
        }
    }
}