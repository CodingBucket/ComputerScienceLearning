#include <iostream>
#include <stdlib.h>

using namespace std;

int main()
{
    int X;
    double Y;

    cin >> X;
    cin >> Y;

    double r = X / Y;

    cout.precision(3);
    cout << fixed << r << " km/l" << "\n";

    return 0;
}

