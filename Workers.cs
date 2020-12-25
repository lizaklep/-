using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment
{
    class Workers
    {

        public string Name;
        private int age;
        private int resident;
        public string LastWork;
        public string Post;
        public Taker prinimaet;
        public DateTime FirstTime;  //когда начал работать
        public DateTime LastTime; // когда уволился
        public Workers(string name, string lastwork, string post, DateTime firstTime, DateTime lastTime)
        {
            Name = name;
            LastWork = lastwork;
            Post = post;
            FirstTime = firstTime;
            LastTime = lastTime;
        }

        public Workers(string v1, string v2, string v3, (int, int, int) p1, (int, int, int) p2)
        {
        }

        public int Resident//свойство проверки на резидента РФ
        {
            get
            {
                return resident;
            }
            set
            {
                if (value < 183)
                {
                    throw new NoResident("Не является резидентом РФ");
                }
                else
                {
                    resident = value;
                }
            }
        }
        public int Age//свойство проверки на своершеннолетие
        {
            get
            {
                return age;
            }
            set
            {
                if (value<18)
                {
                    throw new OlderOrNo("Меньше 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
         TimeSpan _expiriense//опыт работы
        {
            get
            {
                return _expiriense;
            }
            set
            {
                _expiriense = FirstTime - LastTime ;
            }
        }

        //вывод опыта работы
        public void printExpiriense()
        {
            Console.WriteLine("Опыт работы:" +  _expiriense );
        }

        //вывод человека, принимающего на работу
        public void printTaker()
        {
            Console.WriteLine("На работу его принял: " + prinimaet);
        }

        //вывод последнего места работы
        public void printLastWork()
        {
            Console.WriteLine("Предыдущая работа : ", LastWork);
        }
    }
}
