﻿using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Orders.Service
{
    interface IOrderComandSerice
    {

        int generareIdOrder();

        void saveFisier(string text);

        void load();



    }
}