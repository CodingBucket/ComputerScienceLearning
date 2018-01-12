#include <iostream>

using namespace std;

int main()
{
    int fish = 1;
    cout << &fish << endl;

    int *pointer;
    pointer = &fish;

    cout << pointer;
}



