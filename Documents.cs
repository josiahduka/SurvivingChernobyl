using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivingChernobyl
{
    abstract class Document //parent class
    {
        private string body;
        private string date;
        public Document(string abody, string adate)
        {
            this.body = abody;
            this.date = adate;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Body: {body}\nDate: {date}");
        }

    }
    class WorkerBio : Document
    {
        private string position;
        private string name;
        public WorkerBio(string name, string position, string body, string date) : base(body, date)
        {
            this.position = position;
            this.name = name;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Name: {this.name}\nPosition in factory: {this.position}");
        }


    }
    class Orders : Document
    {
        private int orderNum;

        public Orders(int AnOrderNum, string body, string date) : base(body, date)
        {
            this.orderNum = AnOrderNum;

        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Order Number: {orderNum}");
        }
    }
}
