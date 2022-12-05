using System;
using System.Collections.Generic;
using System.Text;

namespace effectory.questionnaire.infrastructure
{
    public interface IJsonReader<T>
    {
        T Read(string name);
    }
}
