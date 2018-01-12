#include <iostream>

using namespace std;

void showNumber(int a){
    cout << "This is int : " << a << endl;
}

void showNumber(float b){
    cout << "This is float : " << b << endl;
}

int main()
{
    int a = 10;
    float b = 20.10;

    showNumber(a);
    showNumber(b);
}



