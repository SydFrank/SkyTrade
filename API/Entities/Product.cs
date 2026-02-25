namespace API.Entities;
// This class represents a product in the system. It contains all the necessary information about a product, such as its name, description, price, picture URL, category, brand, and quantity in stock.
public class Product
{
  // primary key
  public int Id { get; set; }
  // required fields
  public required string Name { get; set; }
  // optional fields
  public required string Description { get; set; }
  // price in cents to avoid floating point issues
  public long Price { get; set; }
  // picture url for the product
  public required string PictureUrl { get; set; }
  // category
  public required string Type { get; set; }
   // product type (e.g. "Shirt", "Pants", etc.)
  public required string Brand { get; set; }

  public int QuantityInStock { get; set; }
}
