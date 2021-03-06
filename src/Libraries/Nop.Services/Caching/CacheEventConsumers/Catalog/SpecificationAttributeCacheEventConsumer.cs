﻿using Nop.Core.Domain.Catalog;
using Nop.Services.Caching.CachingDefaults;

namespace Nop.Services.Caching.CacheEventConsumers.Catalog
{
    /// <summary>
    /// Represents a specification attribute cache event consumer
    /// </summary>
    public partial class SpecificationAttributeCacheEventConsumer : CacheEventConsumer<SpecificationAttribute>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(SpecificationAttribute entity)
        {
            Remove(NopCatalogCachingDefaults.SpecAttributesWithOptionsKey);
            Remove(NopCatalogCachingDefaults.SpecAttributesAllCacheKey);
        }
    }
}
