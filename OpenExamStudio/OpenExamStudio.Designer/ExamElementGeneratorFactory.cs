namespace OpenExamStudio.Designer
{
    public class ExamElementGeneratorFactory
    {
        private EnvironmentVariableProvider _environmentVariableProvider;
        public ExamElementGeneratorFactory()
        {
            _environmentVariableProvider = new EnvironmentVariableProvider();
        }

        public IExamElementGenerator GetExamElementGenerator()
        {
            string apiKey = _environmentVariableProvider.GetEnvironmentVariable("open-exam-studio-openai-key");
            if (string.IsNullOrEmpty(apiKey))
                return new ManualTransferElementGenerator();
            else
                return new OpenAIExamElementGenerator(apiKey);
        }
    }
}