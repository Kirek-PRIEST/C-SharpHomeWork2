// Поиск индекса массива с указанным значением
int[] array = {1,2,4,5,6,7,8,5,10};
int index = 0;
int find = 5;
int n = array.Length;
while (n > index){
if (find == array[index]) {
    Console.WriteLine("Число в индексе " + index);
    break;
    }
index++;
}


