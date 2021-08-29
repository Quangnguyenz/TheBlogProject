﻿using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBlogProject.Services
{
    interface IBlogEmailSender : IEmailSender
    {
        Task SendContactEmailAsync(string emailForm, string name, string subject, string htmlMessage);
    }
}
