public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Tỉ giá hôm nay là 26.000 VND/USD");
        Console.Write("Nhập số USD mà bạn muốn quy đổi: ");
        int rate = Convert.ToInt32(Console.ReadLine());
        int convertRate = rate * 26000;
        Console.WriteLine("Số tiền quy đổi ra VND là: " + convertRate + "đ");
    }
}