int count = 0;
int distance = 10000;
int frend1speed = 1;
int frend2speed = 2;
int dogSpeed = 5;
int friendNumber = 2;
int currentDogRunTime;

while (distance > 10)
{
    if (friendNumber == 1)
    {
        currentDogRunTime = distance / (frend1speed + dogSpeed);
        friendNumber = 2;
    }
    else
    {
        currentDogRunTime = distance / (frend2speed + dogSpeed);
        friendNumber = 1;
    }
    distance = distance - (frend1speed + frend2speed) * currentDogRunTime;
    count = count + 1;
    Console.Write(", ");
    Console.Write(distance);
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз");
