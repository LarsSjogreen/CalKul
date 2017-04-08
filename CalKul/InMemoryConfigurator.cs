using System;
using System.Collections.Generic;

namespace CalKul
{
    internal class InMemoryConfigurator : IConfigurator
    {
        static IVariableStorage _varStore;
        static Dictionary<string, List<Action>> subscribers;

        public InMemoryConfigurator(IVariableStorage varStore)
        {
            _varStore = varStore;
            subscribers = new Dictionary<string, List<Action>>();
        }
        public int ReadConfig(string key, int defaultValue)
        {
            if (_varStore.GetAllKeys().Contains(key))
            {
                return (int)_varStore.GetValue(key);
            } else
            {
                _varStore.SetValue(key, defaultValue);
                return defaultValue;
            }
        }

        public void SetConfig(string key, int value)
        {
            _varStore.SetValue(key, value);
            UpdateSubscribers(key);
        }

        private void UpdateSubscribers(string key)
        {
            if (subscribers.ContainsKey(key))
            {
                foreach (var sub in subscribers[key])
                {
                    sub.Invoke();
                }
            }
        }

        public void Subscribe(Action consumer, string key)
        {
            if (subscribers.ContainsKey(key))
            {
                subscribers[key].Add(consumer);
            } else
            {
                var tempList = new List<Action>();
                tempList.Add(consumer);
                subscribers.Add(key, tempList);
            }
        }
    }
}