using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public class Person
    {
        public string _id { get; set; } //Параметры какие-то
        public string _identifity { get; set; }
        internal defaultInfo _person { get; set; }
        
        internal class defaultInfo
        {
            internal string _name { get; set; }
            internal string _bio { get; set; }
            internal string _someInfo { get; set; } = string.Empty;
            internal List<string> folowers { get; set; } = new List<string> { };
            internal List<string> folowings { get; set; } = new List<string> { };

            //Соу мач как-то выходить, не?

            //Конструктор, если кого-то нового создаем
            internal defaultInfo(string name, string bio, string someInfo)
            {
                _name = name;
                _bio = bio;
                _someInfo = someInfo;
            }
        } //Внутрений класс

        public Person(string id, string identifity, string name, string bio, string someInfo)
        {
            _id = id;
            _identifity = identifity;
            _person = new defaultInfo(name, bio, someInfo);
        } //Конструктор

        public int _getHashId(string id)
        {
            return id.GetHashCode();
        } //Возвращает int

        public string _getName()
        {
            return $"Ваше имя - {_person._name}\nНемного о вас - {_person._someInfo}";
        } //Возвращает string
    }
}
