﻿global using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;

namespace Basket.API.Data
{//Redis Cache using proxy and decorator pattern implemented here
    public class CachedBasketRepository
        (IBasketRepository repository, IDistributedCache cache) 
        : IBasketRepository
    {
        public async Task<ShoppingCart> GetBasket(string userName, CancellationToken cancellationToken = default)
        {
            var cachedBasket = await cache.GetStringAsync(userName, cancellationToken);
            if(!string.IsNullOrEmpty(cachedBasket))
                return JsonSerializer.Deserialize<ShoppingCart>(cachedBasket)!;

            var basket = await repository.GetBasket(userName, cancellationToken);
            await cache.SetStringAsync(userName, JsonSerializer.Serialize(basket), cancellationToken);
            return basket;
        }

        public async Task<ShoppingCart> StoreBasket(ShoppingCart basket, CancellationToken cancellation = default)
        {
            await repository.StoreBasket(basket, cancellation);
            await cache.SetStringAsync(basket.UserName, JsonSerializer.Serialize(basket), cancellation);
            
            return basket;
        }

        public async Task<bool> DeleteBasket(string userName, CancellationToken cancellation = default)
        {
            await repository.DeleteBasket(userName, cancellation);

            await cache.RemoveAsync(userName, cancellation);

            return true;
        }
    }
}
