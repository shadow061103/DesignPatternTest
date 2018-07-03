using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Resume:ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private string timeArea;
        private string company;
        private WorkExperience work;
        public Resume(string name)
        {
            work = new WorkExperience();
            this.name = name;
        }
        private Resume(WorkExperience work) //私有
        {
            this.work = (WorkExperience)work.Clone();//深複製
        }
        public void setPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }
        public void sexWorkExperience(string timeArea, string company)
        {
            work.WorkDate = timeArea;
            work.Company = company;
        }
        public void Display()
        {
            Console.WriteLine($"{name},{sex},{age}");
            Console.WriteLine($"工作經歷{work.WorkDate} {work.Company }");
        }
        public object Clone()
        {
            Resume obj = new Resume(this.work);
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            // return (Object)this.MemberwiseClone();//淺層副本
            return obj;//深層複製 物件參考

        }
    }
}
