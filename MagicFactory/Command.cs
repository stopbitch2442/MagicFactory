using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicFactory
{
    public class Command
    {
        public int Value { get; set; }
        public string Description { get; set; }

        public Command RandomDetails = new Command { Value = 1, Description = "Собрать транспорт из рандомных деталей" };
        public Command SelectedDetails = new Command { Value = 2, Description = "Выбрать детали для нашей машины" };
    }
}