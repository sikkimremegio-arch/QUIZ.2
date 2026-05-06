using System;


public class AgeBracket
{ 
    private int _age;

   public int ageBracket
    {
        get { return _age; }
        set
        {
            if (value >= 1 && value <= 10)
                _age = value;
        }
    }   
}


//2.

using System;


public class Username
{
    private string _username;
    public string username
    {
        get { return _username; }
        set
        {
            if (value != null && value.Length == 10)
            {
                _username = value;
            }
        }
    }
}

//3


using System;

public class StockLimit
{
    private int _stock;
    public int Stock
    {
        get { return _stock; }
        set
        {
            if (value <= 10)
                _stock = value;
        }
    }
}

//4.
using System;


public class HiddenPin
{
    private string _pin;
    public string Pin
    {
        get { return "****"; }
        set
        {
            if (value.Length == 4 && int.TryParse(value, out _))
                _pin = value;
        }
    }
}

//5.
using System;

public class PriceFloor
{
    private double _price;

    public PriceFloor(double price)
    {
        _price = Math.Max(10, price);
    }

    public double Price
    {
        get { return _price; }
        set
        {
            _price = Math.Max(10, value);
        }
    }
}

//6.
using System;

public class ScoreIncrementer
{
    private int _score;
    public int Score
    {
        get { return _score; }
        set
        {
            if (value == _score + 10)
                _score = value;
        }
    }
}


//7.
using System;

public class IdMasking
{
    private string _id;
    public string Id
    {
        get
        {
            if (_id == null) return null;
            return _id.Substring(_id.Length - 4);
        }
        set
        {
            if (value.Length == 10)
                _id = value;
        }
    }
}

//8.
using System;


public class LevelLock
{
    private int _level;
    public int Level
    {
        get { return _level; }
        set
        {
            if (value >= _level)
                _level = value;
        }
    }
}

//9
using System;

public class PercentClamp
{
    private double _value;

    public PercentClamp(double value)
    {
        _value = Clamp(value);
    }

    public double Value
    {
        get { return _value; }
        set { _value = Clamp(value); }
    }

    private double Clamp(double value)
    {
        if (value < 0) return 0;
        if (value > 100) return 100;
        return value;
    }
}


//MAIN
// 1
AgeBracket age = new AgeBracket();
age.ageBracket = 5;

// 2
Username user = new Username();
user.username = "abcdefghij";

// 3
StockLimit stock = new StockLimit();
stock.Stock = 8;

// 4
HiddenPin pin = new HiddenPin();
pin.Pin = "1234";

// 5
PriceFloor price = new PriceFloor(5);
price.Price = 7; // will become 10

// 6
ScoreIncrementer score = new ScoreIncrementer();
score.Score = 10; // valid (0 → 10)
score.Score = 20; // valid (10 → 20)

// 7
IdMasking id = new IdMasking();
id.Id = "AB12345678";

// 8
LevelLock level = new LevelLock();
level.Level = 5;
level.Level = 3; // ignored
level.Level = 10;

// 9
PercentClamp percent = new PercentClamp(150);

// OUTPUT
Console.WriteLine("Age: " + age.ageBracket);
Console.WriteLine("Username: " + user.username);
Console.WriteLine("Stock: " + stock.Stock);
Console.WriteLine("PIN: " + pin.Pin);
Console.WriteLine("Price: " + price.Price);
Console.WriteLine("Score: " + score.Score);
Console.WriteLine("ID (last 4): " + id.Id);
Console.WriteLine("Level: " + level.Level);
Console.WriteLine("Percent: " + percent.Value);

