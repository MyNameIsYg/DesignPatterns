using DesignPatterns.Observer;
using DesignPatterns.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns;

public class VendingMachine : ISubject
{
    public Dictionary<Product, int> inventory { get; set; }
    private List<IObserver> observers;
    public VendingMachine()
    {
        inventory = new Dictionary<Product, int>();
        observers = new List<IObserver>();
        InitializeInventory();
        InitializeObservers();
    }
    private void InitializeInventory()
    {
        inventory.Add(new Snacks() { NameProduct = "Chips", Price = (float)5.5 }, 20);
        inventory.Add(new Snacks() { NameProduct = "Doritos", Price = (float)4.5 }, 15);
        inventory.Add(new Snacks() { NameProduct = "Chocolate", Price = (float)5.0 }, 30);
        inventory.Add(new Snacks() { NameProduct = "Shogi", Price = (float)1.9 }, 25);
        inventory.Add(new Snacks() { NameProduct = "Crackers", Price = (float)10.0 }, 25);
        inventory.Add(new Snacks() { NameProduct = "Waffles", Price = (float)8.9 }, 12);
        inventory.Add(new HotDrink() { NameProduct = "Coffee", Price = (float)6.0 }, 26);
        inventory.Add(new HotDrink() { NameProduct = "Tea", Price = (float)6.0 }, 10);
        inventory.Add(new HotDrink() { NameProduct = "Cappuccino", Price = (float)6.0 }, 9);
        inventory.Add(new HotDrink() { NameProduct = "Choco", Price = (float)6.0 }, 6);
        inventory.Add(new HotDrink() { NameProduct = "Chocolata", Price = (float)6.0 }, 8);
        inventory.Add(new ColdDrink() { NameProduct = "ColaZero", Price = (float)7.0 }, 11);
        inventory.Add(new ColdDrink() { NameProduct = "CocaCola", Price = (float)7.0 }, 20);
        inventory.Add(new ColdDrink() { NameProduct = "FuzeTea", Price = (float)7.0 }, 25);
        inventory.Add(new ColdDrink() { NameProduct = "IceCoffee", Price = (float)6.0 }, 15);
        inventory.Add(new ColdDrink() { NameProduct = "IceVanil", Price = (float)6.0 }, 7);
        inventory.Add(new ColdDrink() { NameProduct = "Sprite", Price = (float)6.0 }, 6);
    }
    private void InitializeObservers()
    {
        observers.Add(new Supplier());
    }
    public void NotifySuppiler(Product product)
    {
        foreach (var observer in observers)
        {
            observer.Update(product);
        }
    }
    public void RegisterSuppiler(IObserver observer)
    {
        observers.Add(observer);
    }
    public void UnregisterSuppiler(IObserver observer)
    {
        observers.Remove(observer);
    }
    public void UpdateInventory(Product product)
    {
        if (product != null)
        {

            inventory[product] -= 1;
            if (inventory[product] < 5)
            {
                NotifySuppiler(product);
            }
        }
        else
        {
            MessageBox.Show("the product is doese'nt exist");
        }
    }
}





