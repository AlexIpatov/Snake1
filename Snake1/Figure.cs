﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake1
{
    class Figure
    {
       protected List<Point> pList;

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
