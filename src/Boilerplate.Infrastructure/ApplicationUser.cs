﻿using MassTransit;
using Microsoft.AspNetCore.Identity;
using System;

namespace Boilerplate.Infrastructure;

public class ApplicationUser : IdentityUser<Guid>
{
    public override Guid Id { get; set; } = NewId.NextSequentialGuid();
    public string? FirstName { get; set; }
}

public class ApplicationRole : IdentityRole<Guid>
{
    public override Guid Id { get; set; } = NewId.NextSequentialGuid();
}