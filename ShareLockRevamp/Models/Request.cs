﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShareLockRevamp.Models
{
    public class Request
    {
        public string ID { get; set; }
        public string Fullname { get; set; }

        public string Message { get; set; }

        public string DoorLockId { get; set; } ///FK
        public string DoorLockName { get; set; }
        public string RequestDate { get; set; }
        public string OwnerUsername { get; set; }
        public string FamilyName { get; set; }
        public string Address { get; set; }
        public string VisitorUsername { get; set; } ///FK
        public string Status { get; set; } ///FK
        public string OneTimePassword { get; set; } ///FK

    }
}