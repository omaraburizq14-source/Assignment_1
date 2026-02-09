// Asssignment_1 (purchase Discount)

Console.Write("Enter Your Bill Amount: ");
double billAmount = Convert.ToDouble(Console.ReadLine());
double finalPrice=0;

if (billAmount < 0) 
{
    Console.WriteLine("Invalid Amount");
}
else if ( billAmount >= 500 ) 
{
    double discount_20 = (billAmount / 100) * 20;
    finalPrice = billAmount - discount_20;
    Console.WriteLine($"Final Price: {finalPrice}");
}
else if ( billAmount >= 300 && billAmount < 500)
{
    double discount_10 = (billAmount / 100) * 10;
    finalPrice = billAmount - discount_10;
    Console.WriteLine($"Final Price: {finalPrice}");
}
else  // billAmount < 300
{
    Console.WriteLine($"Final Price: {billAmount}");
}




