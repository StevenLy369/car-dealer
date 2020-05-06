namespace Models
{
  public class Car
  {
    private string _MakeModel;
    private int _Price;
    private int _Miles;

    private string _Color;

    private string _Sound;

    public Car(string makeModel, int price, int miles, string color)
    {
      _MakeModel = makeModel;
      _Price = price;
      _Miles = miles;
      _Color = color;
      
    }

    public static string MakeSound(string sound){
        return "Our cars sound like " + sound;
    }

    public void SetPrice(int newPrice){
        _Price = newPrice;
    }
    public void SetColor(string color){
        _Color = color;
    }
    public string GetMakeModel(){
        return _MakeModel;
    }

    public int GetMiles(){
        return _Miles;
    }

    public string getColor(){
        return _Color;
    }

    public int GetPrice(){
        return _Price;
    }
    public string GetSound(){
        return _Sound;
    }
    public bool WorthBuying(int maxPrice)
    {
      return (_Price < maxPrice);
    }
  }
}