using static System.Console;
using ProektSort;

int[] arr = { 3, 4, 6, 1, 2, 8, 7, 9, 10 };

BubbleSort bubble = new BubbleSort();

AscendingStrat ascending = new AscendingStrat();
DescendingStrat descending = new DescendingStrat();
//CustomStrat custom = new CustomStrat();

/*foo();
bubble.Sort(arr, ascending);
foo();

bubble.Sort(arr, descending);
foo();

bubble.Sort(arr, custom);
foo();*/


Decorator d = new CustomStrat(new AscendingStrat());

foo();
bubble.Sort(arr, d);
foo();

bubble.Sort(arr, new InverseStrat(d));
foo();


void foo() 
{
    foreach (int el in arr)
        Write(el + " ");
    WriteLine();
}