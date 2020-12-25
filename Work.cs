using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment
{
    class Work
    {
        private List<Workers> workers;
        public List<Workers> Workers { get { return workers; } }//можем управлять доступом к переменной workers

        public Work(List<Workers> list)
        {
            workers = list;
        }

        public Work() 
        {
        }

        //добавление сотрудника
        public void AddWorker(Workers worker)
        {
            workers.Add(worker);
        }
    }
}
