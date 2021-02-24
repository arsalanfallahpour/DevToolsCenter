namespace FastExperience.Tools.Translation
{
    public class ParameterModel
    {
        public ParameterModel(string lastTargetPath, string lastOutpuPath)
        {
            _lastTargetPath = lastTargetPath;
            _lastOutpuPath = lastOutpuPath;
        }
        public string LastTargetPath => _lastTargetPath;
        private readonly string _lastTargetPath;
        public string LastOutputPath => _lastOutpuPath;
        private readonly string _lastOutpuPath;

    }
}