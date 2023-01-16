Console.WriteLine("Задайте длину массива ");
int size = Convert.ToInt32(Console.ReadLine());


int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] =new  Random().Next(0, 100);
    Console.Write(array[i] +  ", ");
}