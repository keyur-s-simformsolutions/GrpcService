using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Net.Client;
using GrpcServer;
using GrpcServer.Protos;
using static GrpcServer.Protos.Product;

namespace GrpcClient
{
    public class Program
    {
        private static GrpcChannel channel; 

        public static async Task Main(string[] args)
        {
            bool exit = false;

            // Initialize the channel once at the start
            channel = GrpcChannel.ForAddress("http://localhost:5056");

            while (!exit)
            {
                Console.WriteLine("\nSelect an option:");
                Console.WriteLine("1 - Add Product");
                Console.WriteLine("2 - Get Product");
                Console.WriteLine("3 - List Products");
                Console.WriteLine("4 - Run all demos");
                Console.WriteLine("0 - Exit");
                Console.Write("Enter your choice: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await AddProduct();
                        break;
                    case "2":
                        await GetProduct();
                        break;
                    case "3":
                        await ListProducts();
                        break;
                    case "4":
                        await AddProduct();
                        await GetProduct();
                        await ListProducts();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            // Shutdown the channel when the program exits
            await channel.ShutdownAsync();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static async Task GetProduct()
        {
            var client = new Product.ProductClient(channel);

            for (int i = 1; i <= 3; i++)
            {
                var productRequest = new ProductRequest { ProductId = i };
                var productResponse = await client.GetProductAsync(productRequest);

                Console.WriteLine($"Request ProductId: {i}");
                Console.WriteLine($"Product Name: {productResponse.ProductName}");
                Console.WriteLine($"Product Description: {productResponse.ProductDescription}");
                Console.WriteLine($"Product Price: {productResponse.ProductPrice}");
                Console.WriteLine("---------------------------------------------------");
            }
        }

        private static async Task AddProduct()
        {
            var client = new Product.ProductClient(channel);

            var newProductRequest = new ProductRequest
            {
                ProductName = "New Product",
                ProductDescription = "A demo product",
                ProductPrice = 499.99
            };

            var response = await client.AddProductAsync(newProductRequest);
            Console.WriteLine($"Added Product - ID: {response.ProductId}, Name: {response.ProductName}");
        }

        private static async Task ListProducts()
        {
            var client = new Product.ProductClient(channel);

            using var call = client.ListProducts(new Empty());

            await foreach (var product in call.ResponseStream.ReadAllAsync())
            {
                Console.WriteLine($"Product - ID: {product.ProductId}, Name: {product.ProductName}");
            }
        }
    }


}