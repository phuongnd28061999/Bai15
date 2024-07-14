// See https://aka.ms/new-console-template for more information
using Bai15;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Hello, World!");
public interface IProductRepository
{
    IEnumerable<Product> GetAll();
    Product GetById(int id);
    void Add(Product product);
    void Update(Product product);
    void Delete(int id);
}

public class ProductRepository : IProductRepository
{
    private readonly ProductDbContext _context;

    public ProductRepository(ProductDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    public Product GetById(int id)
    {
        return _context.Products.Find(id);
    }

    public void Add(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void Update(Product product)
    {
        _context.Entry(product).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var product = _context.Products.Find(id);
        if (product != null)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}
