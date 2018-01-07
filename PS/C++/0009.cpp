#include <iostream>

using namespace std;

int main()
{
    char name[20];
    double salary;
    double totalSold;

    cin >> name;
    cin >> salary;
    cin >> totalSold;

    double TOTAL = (15 * totalSold) / 100;
    TOTAL = TOTAL + salary;

    cout.precision(2);
    cout << "TOTAL = R$ " << fixed << TOTAL << "\n";

    return 0;
}

