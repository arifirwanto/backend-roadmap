decimal price = 850000;
decimal additionalCost = 150000;
decimal totalPrice = price + additionalCost;
int passengerCount = 5;
int maxPassenger = 6; 
bool passenger = passengerCount <= maxPassenger;
bool isDriverAvailable = true;
bool isCarReady = true;
bool bookingReady = passenger && isDriverAvailable && isCarReady;
Console.WriteLine("=== ARIN CUSTOMER DATA ===");

Console.WriteLine("Trip Price: " + price);
Console.WriteLine("Additional Cost:" + additionalCost);
Console.WriteLine("Total Price: " + totalPrice);
Console.WriteLine("Passenger Available: " + passenger);
Console.WriteLine("Driver Valid: " + isDriverAvailable);
Console.WriteLine("Car Ready: " + isCarReady);
Console.WriteLine("Can Accept Booking:" + bookingReady);