// See https://aka.ms/new-console-template for more information
int count=0;
float distance=10000;
int firstFriendSpeed=1;
int secondFriendSpeed=2;
int dogSpeed=5;
int friend=2;
float time;
while (distance>10)
{
    if (friend==1)
    {
        time=distance/(firstFriendSpeed+dogSpeed);
        friend=2;
    }
    else
    {
        time=distance/(secondFriendSpeed+dogSpeed);
        friend=1;
    }
    distance=distance-time*(firstFriendSpeed+secondFriendSpeed);
    count+=1;
}
Console.Write("Собака пробежит между друзьями ");
Console.Write(count);
Console.WriteLine(" раз.");
