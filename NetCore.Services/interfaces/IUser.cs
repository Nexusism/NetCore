﻿using NetCore.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Services.interfaces
{
    public interface IUser
    {
        bool MatchTheUserInfo(LoginInfo login);
    }
}
