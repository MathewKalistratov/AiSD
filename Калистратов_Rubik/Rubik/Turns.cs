using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rubik;

namespace Rubik
{
    // Тут функции всех возможных вариантов поворотов граней. Рутинные и не веселые. А еще их супермного
    public partial class Turns
    {
        // Крутим горизонтально
        public void horizontalUp(string[] mainArr) { }
        public void horizontalCenter(string[] mainArr) { }
        public void horizontalDown(string[] mainArr) { }
        // Крутим вертикально
        public void verticalLeft(string[] mainArr) { }
        public void verticalCenter(string[] mainArr) { }
        public void verticalRight(string[] mainArr) { }
        // Крутим по третьей оси (хз как ее назвать)
        public void frontClosest(string[] mainArr) { }
        public void frontCenter(string[] mainArr) { }
        public void frontFarthest(string[] mainArr) { }
        // Дальше все против часовой стрелки
        public void againstHorizontalUp(string[] mainArr) { }
        public void againstHorizontalCenter(string[] mainArr) { }
        public void againstHorizontalDown(string[] mainArr) { }

        public void againstVerticalLeft(string[] mainArr) { }
        public void againstVerticalCenter(string[] mainArr) { }
        public void againstVerticalRight(string[] mainArr) { }

        public void againstFrontClosest(string[] mainArr) { }
        public void againstFrontCenter(string[] mainArr) { }
        public void againstFrontFarthest(string[] mainArr) { }
    }
}
