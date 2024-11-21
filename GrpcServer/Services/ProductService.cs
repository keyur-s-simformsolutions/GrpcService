using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcServer;
using GrpcServer.Modals;
using GrpcServer.Protos;

namespace GrpcServer.Services
{
    public class ProductService : Product.ProductBase
    {
    
        private static readonly List<ProductItem> Products = new List<ProductItem>
        {
            new ProductItem { ProductId = 1, ProductName = "Product 1", ProductDescription = "Description for Product 1", ProductPrice = 150.00 },
            new ProductItem { ProductId = 2, ProductName = "Product 2", ProductDescription = "Description for Product 2", ProductPrice = 250.00 },
            new ProductItem { ProductId = 3, ProductName = "Product 3", ProductDescription = "Description for Product 3", ProductPrice = 350.00 },
        };

        public override Task<ProductResponse> GetProduct(ProductRequest request, ServerCallContext context)
        {
           
            var product = Products.FirstOrDefault(p => p.ProductId == request.ProductId);

            if (product == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, $"Product with ID {request.ProductId} not found"));
            }

            var response = new ProductResponse
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                ProductPrice = product.ProductPrice
            };

            return Task.FromResult(response);
        }
        public override Task<ProductResponse> AddProduct(ProductRequest request, ServerCallContext context)
        {
            var newProduct = new ProductItem
            {
                ProductId = Products.Count + 1,
                ProductName = request.ProductName,
                ProductDescription = request.ProductDescription,
                ProductPrice = request.ProductPrice
            };

            Products.Add(newProduct);

            var response = new ProductResponse
            {
                ProductId = newProduct.ProductId,
                ProductName = newProduct.ProductName,
                ProductDescription = newProduct.ProductDescription,
                ProductPrice = newProduct.ProductPrice
            };

            return Task.FromResult(response);
        }
        public override async Task ListProducts(Empty request, IServerStreamWriter<ProductResponse> responseStream, ServerCallContext context)
        {
            foreach (var product in Products)
            {
                var response = new ProductResponse
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    ProductDescription = product.ProductDescription,
                    ProductPrice = product.ProductPrice
                };

                await responseStream.WriteAsync(response);
            }
        }
    }
}
