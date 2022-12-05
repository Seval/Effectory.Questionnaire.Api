using effectory.questionnaire.domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace effectory.questionnaire.infrastructure
{
    public class JsonReader<T> : IJsonReader<T> where T : class
    {
        public T Read(string name)
        {
            using (StreamReader r = new StreamReader(Path.Combine(Environment.CurrentDirectory, $"Json/{name}.json")))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(json);
            }
        }

    }
}
