using System.Collections.Generic;

namespace CalKul
{
    public interface IVariableStorage
    {
        List<string> GetAllKeys();
        object GetValue(string key);
        void SetValue(string key, object value);
    }
}