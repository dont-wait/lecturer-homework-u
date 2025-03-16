
public class HinhChuNhat
{
    private Double _length;
    private Double _width;

    public HinhChuNhat(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public HinhChuNhat()
    {
    }

    public HinhChuNhat(HinhChuNhat hcn)
    {
        Length = hcn._length;
        Width = hcn._width;
    }

    public double Length
    {
        get => _length;
        set
        {
            if(value < 0)
                throw new ArgumentException("Length can't be negative");
            _length = value;
        }
    }

    public double Width
    {
        get => _width;
        set
        {
            if(value < 0)
                throw new ArgumentException("Width can't be negative");
            _width = value;
        }
    }
    
    public Double GetPerimeter() => (_length + _width) / 2;
    public Double GetArea() => _length * _width;
    
    //Vie: Duong cheo
    public Double GetDiagonal() => Math.Sqrt(Math.Pow(_width, 2) + Math.Pow(_length, 2));
    
    public void ShowInfo() => Console.WriteLine($"Length: {_length}, Width: {_width}| Perimeter: {GetPerimeter()}| Area: {GetArea()}| Diagonal: {GetDiagonal()}");

    public void InputInfo()
    {
        Console.Write("Length: ");
        Length = Double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        Width = Double.Parse(Console.ReadLine());
    }

    public void ChangeSize(int tx, int ty, int kieu)
    {
        if (kieu == 1)
        {
            Length += tx;
            Width += ty;
        }
        else if(kieu == 0)
        {
            Length -= tx;
            Width -= ty;
        }
    }

    public void ChangeSize(HinhChuNhat hcn, int kieu)
    {
        if (kieu == 1)
        {
            Length += hcn._length;
            Width += hcn._width;
        }
        else if(kieu == 0)
        {
            Length -= hcn._length;
            Width -= hcn._width;
        }
    }
}