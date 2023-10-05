﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Users.Models
{
    public interface IUserBuilder
    {

        User Id(int id);
        User Name(string name);
        User Email(string email);
        User Password(string password);
        User Phone(string phone);
        User Address(string assdress);
        User Varsta(int varsta);

    }


    private int _id;
    private string _name;
    private string _email;
    private string _password;
    private string _phone;
    private string _address;
    private int _varsta;

}
