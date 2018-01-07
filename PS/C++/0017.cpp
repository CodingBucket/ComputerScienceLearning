#include <iostream>

using namespace std;

int main()
{
    int spentTime, speed;

    cin >> spentTime;
    cin >> speed;

    double r = (spentTime * speed) / 12.0;

    cout.precision(3);
    cout << fixed << r << "\n";

    return 0;
}

