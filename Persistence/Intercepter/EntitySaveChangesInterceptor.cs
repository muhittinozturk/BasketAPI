﻿using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;


namespace Persistence.Intercepter
{
    public class EntitySaveChangesInterceptor : SaveChangesInterceptor
    {
        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            UpdateEntities(eventData.Context);

            return base.SavingChanges(eventData, result);
        }

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            UpdateEntities(eventData.Context);

            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }

        public void UpdateEntities(DbContext? context)
        {
            if (context == null) return;

            foreach (var entry in context.ChangeTracker.Entries<BaseEntity>())
            {
                
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreateTime= DateTime.UtcNow;
                    entry.Entity.UUID = Guid.NewGuid();
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdateTime = DateTime.UtcNow;
                }
            }
        }
    }
}
