using System;

namespace CalKul
{
    public interface IConfigurator
    {
        int ReadConfig(string key, int defaultValue);
        void SetConfig(string key, int value);
        void Subscribe(Action updateConfigs, string v);
    }
}