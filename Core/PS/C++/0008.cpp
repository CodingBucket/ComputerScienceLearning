#include <iostream>

using namespace std;

int main()
{
    int NUMBER;
    int day;
    double perDay;

    cin >> NUMBER;
    cin >> day;
    cin >> perDay;

    double SALARY = day * perDay;

    cout << "NUMBER = " << NUMBER << "\n";
    cout.precision(2);
    cout << "SALARY = U$ " << fixed << SALARY << "\n";

    return 0;
}

