
namespace CampusBenchApi.Models;

//I can't understand when I placed the order!?!?!??!
public partial class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string dataorder {get; set; }
    
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    public DateTime OrderDate { get; internal set; }
    public Order Id_or { get; internal set; }
}