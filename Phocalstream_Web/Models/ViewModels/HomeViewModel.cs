﻿using Phocalstream_Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phocalstream_Web.Models.ViewModels
{
    public class HomeViewModel
    {
        public ICollection<Collection> Collections { get; set; }
    }
}