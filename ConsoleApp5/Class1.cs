using System;
using System.Collections.Generic;

namespace InspectorLib
{
    public class FunctionInsp
    {
        private string inspectionName = "Автоинспекция г. Чита";
        private string chiefInspector = "Васильев Василий Иванович";
        private List<string> workers = new List<string>
        {
            "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И."
        };

        public string GetInspector()
        {
            return chiefInspector;
        }

        public string GetCarInspection()
        {
            return inspectionName;
        }

        public bool SetInspector(string fullname)
        {
            if (workers.Contains(fullname))
            {
                chiefInspector = fullname;
                return true;
            }
            return false;
        }

        public string GenerateNumber(string number, string symbol, string code = "75")
        {
            return $"{symbol.ToUpper()}{number}_{code}";
        }

        public List<string> GetWorker()
        {
            return workers;
        }

        public void AddWorker(string fullname)
        {
            if (!workers.Contains(fullname))
            {
                workers.Add(fullname);
            }
        }
    }
}
