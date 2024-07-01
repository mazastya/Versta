namespace Versta.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Order
{
        
    public int id { get; set; }
        
    public string CitySender { get; set; }
        
    public string AddressSender { get; set; }
        
    public string CityRecipient { get; set; }
        
    public string AddressRecipient { get; set; }
        
    public double Weight { get; set; }
        
    public DateTime DateTime { get; set; }

}