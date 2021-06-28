using TestNet6.Interfaces;

namespace TestNet6.Services
{
    abstract class Shape : IShape
    {
        public string ClassObjective { get; set; }
        public Shape(string objective)
        {
            ClassObjective = objective;
        }
        public string GetClassObjective()
        {
            return ClassObjective;
        }
    }
}
