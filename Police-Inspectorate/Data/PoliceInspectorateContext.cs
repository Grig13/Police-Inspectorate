﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Police_Inspectorate.Models;

namespace PoliceInspectorate.Context
{
    public class PoliceInspectorateContext :   IdentityDbContext<IdentityUser>
    {
        public PoliceInspectorateContext(DbContextOptions<PoliceInspectorateContext> options)

        : base(options)

        { }

        public DbSet<Case>? Cases { get; set; }
        public DbSet<Meeting>? Meetings { get; set; }
        public DbSet<PoliceAgent>? PoliceAgents { get; set; }
        public DbSet<Request>? Requests { get; set; }
        public DbSet<Station>? Stations { get; set; }
        public DbSet<Suspect>? Suspects { get; set; }
        public DbSet<Account>? Account { get; set; }
        public DbSet<Police_Inspectorate.Models.InspectorateChief>? InspectorateChief { get; set; }



    }
}
