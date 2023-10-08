void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
        {

        collection[index] = new Random().Next(1,10);
        index++;
        }



}

void PrintArray(int[] col)
    {
    int count = col.Length;
    int position = 0;
    while (position < count)
        {
        Console.WriteLine(col[position]);
        position++;
        } 
    }

int IndexOf(int[] collectiot, int find)
{
    int count = collectiot.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (find == collectiot[index]) 
        {
            position = index;
            break;
        }
        index++;
    }

return position;
}


int[] array = new int [10];

FillArray(array);
PrintArray(array);
Console.Write("Элемент в позиции ");

int pos = IndexOf(array, 4);
Console.Write(pos);

