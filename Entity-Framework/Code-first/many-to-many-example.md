### First we creating the models:

```c#

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<ProductCategory> ProductCategories { get; set; }
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IList<ProductCategory> ProductCategories { get; set; }
}

public class ProductCategory
{
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}


// USING ENTITY FRAMEWORCK
public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductCategory>()
            .HasKey(pc => new { pc.ProductId, pc.CategoryId });
        
        modelBuilder.Entity<ProductCategory>()
            .HasOne(pc => pc.Product)
            .WithMany(p => p.ProductCategories)
            .HasForeignKey(pc => pc.ProductId);
        
        modelBuilder.Entity<ProductCategory>()
            .HasOne(pc => pc.Category)
            .WithMany(c => c.ProductCategories)
            .HasForeignKey(pc => pc.CategoryId);
    }
}



```


### Inersting A dummy data into tables:

```c#
using (var context = new MyContext())
{
    var electronicsCategory = new Category { CategoryName = "Electronics" };
    var fashionCategory = new Category { CategoryName = "Fashion" };
    context.Categories.Add(electronicsCategory);
    context.Categories.Add(fashionCategory);

    var phoneProduct = new Product { ProductName = "Phone" };
    phoneProduct.ProductCategories = new List<ProductCategory>
    {
        new ProductCategory { Category = electronicsCategory },
        new ProductCategory { Category = fashionCategory }
    };
    context.Products.Add(phoneProduct);

    var laptopProduct = new Product { ProductName = "Laptop" };
    laptopProduct.ProductCategories = new List<ProductCategory>
    {
        new ProductCategory { Category = electronicsCategory }
    };
    context.Products.Add(laptopProduct);

    context.SaveChanges();
}
```
