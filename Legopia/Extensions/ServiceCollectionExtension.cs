using Legopia.Data;
using Legopia.Repositories;
using Legopia.Repositories.Implementors;
using Legopia.Services;
using Legopia.Services.Implementors;
using Microsoft.EntityFrameworkCore;

namespace Legopia.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Repository DI
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepositoryImpl<>));
            services.AddScoped<ICartItemRepository, CartItemRepositoryImpl>();
            services.AddScoped<ICartRepository, CartRepositoryImpl>();
            services.AddScoped<ICouponRepository, CouponRepositoryImpl>();
            services.AddScoped<IOrderDetailsRepository, OrderDetailsRepositoryImpl>();
            services.AddScoped<IOrderItemRepository, OrderItemRepositoryImpl>();
            services.AddScoped<IPostCategoryRepository, PostCategoryRepositoryImpl>();
            services.AddScoped<IPostRepository, PostRepositoryImpl>();
            services.AddScoped<IProductCategoryRepository, ProductCategoryRepositoryImpl>();
            services.AddScoped<IProductImageRepository, ProductImageRepositoryImpl>();
            services.AddScoped<IProductRepository, ProductRepositoryImpl>();
            services.AddScoped<IProductReviewRepository, ProductReviewRepositoryImpl>();
            services.AddScoped<ITagRepository, TagRepositoryImpl>();
            services.AddScoped<IUserDetailsRepository, UserDetailsRepositoryImpl>();
            // Service DI
            services.AddScoped<ICartItemService, CartItemServiceImpl>();
            services.AddScoped<ICartService, CartServiceImpl>();
            services.AddScoped<ICouponService, CouponServiceImpl>();
            services.AddScoped<IOrderDetailsService, OrderDetailsServiceImpl>();
            services.AddScoped<IOrderItemService, OrderItemServiceImpl>();
            services.AddScoped<IPostCategoryService, PostCategoryServiceImpl>();
            services.AddScoped<IPostService, PostServiceImpl>();
            services.AddScoped<IProductCategoryService, ProductCategoryServiceImpl>();
            services.AddScoped<IProductImageService, ProductImageServiceImpl>();
            services.AddScoped<IProductService, ProductServiceImpl>();
            services.AddScoped<IProductReviewService, ProductReviewServiceImpl>();
            services.AddScoped<ITagService, TagServiceImpl>();
            services.AddScoped<IUserDetailsService, UserDetailsServiceImpl>();

            return services;
        }

        public static IServiceCollection AddSqlServer(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("LegopiaDbConnection")
                ?? throw new InvalidOperationException("Connection string not found");
            services.AddDbContext<LegopiaDbContext>(options => options.UseSqlServer(connectionString));
            return services;
        }
    }
}
