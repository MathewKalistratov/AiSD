using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rubik;

namespace Rubik
{
    // Тут все необходимые для сборки комбинации поворотов
    public partial class Combinations
    {
        // Собираем крест на первом слое
        public void firstEdgePlace() { }  // Поднять ребро на свое место
        public void firstEdgeConversely() { }  // Ребро стоит наоборот, развернуть его

        // Расставляем углы на первом слое слое по своим местам
        public void firstAnglePlace() { }

        // Собираем средний слой
        public void secondUpAndLeft() { }
        public void secondUpAndRight() { }

        // Неправильный крест на последнем слое
        public void thirdWrongCross() { }

        // Правильный крест на последнем слое
        public void thirdTrueCrossFormer() { }  // Первые две грани
        public void thirdTrueCrossLast() { }  // Последние две грани

        // Расставляем углы на последнем слое по своим местам (там два варианта)
        public void thirdAnglePlace1() { }
        public void thirdAnglePlace2() { }

        // Разворачиваем углы правильными местами (там по факту одна комбинация)
        public void thirdExpandAngles() { }




    }
}
